﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIMRestaurantAPI.DTOs;
using PIMRestaurantAPI.DTOs.Enums;
using System.Drawing;
using System.Drawing.Printing;

namespace PIMRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeseController : ControllerBase
    {
        private readonly PossistemContext _context;
        private readonly IMapper _mapper;
        private IConfigurationRoot _appSettings;

        public MeseController(PossistemContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            this._appSettings = builder.Build();
        }

        [HttpGet]
        public async Task<ActionResult<List<MasaDTO>>> GetMese([FromQuery] int? idSala = null, [FromQuery] int? idUser = null)
        {
            var productsOnTable = await _context.ProdusePeMasas.ToListAsync();
            IQueryable<MeseScaune> mese = _context.MeseScaunes;
            if (idSala.HasValue)
            {
                mese = mese.Where(x => x.Idsala == idSala.Value);
            }
            if (idUser.HasValue)
            {
                mese = mese.Where(table => 
                _context.UtilizatoriMeses.Any(x => 
                    x.Idutilizator == idUser && x.Idmasa == table.Id ||
                    x.Idutilizator == idUser && x.Idmasa == table.Idcopil));
            }
            var result = await mese.ToListAsync();

            if (!result.Any())
            {
                return Ok(new List<MasaDTO>() { });
            }

            return Ok(result.Select(masa => {
                var masaDTO = _mapper.Map<MasaDTO>(masa);
                var product = productsOnTable.FirstOrDefault(x => x.Idscaun == masa.Id);
                if (product != null)
                {
                    masaDTO.Occupied = true;
                    masaDTO.IdUser = product.Iduser;
                    masaDTO.Status = MasaStatus.IN_LUCRU;
                    if (masa.NotaDePlata != -1)
                    {
                        masaDTO.Status = MasaStatus.NOTA_EMISA;
                    }
                } else
                {
                    masaDTO.Occupied = false;
                    masaDTO.Status = MasaStatus.LIBERA;
                }
                return masaDTO;
            }));
        }

        [HttpPut("{id}/Bill")]
        public async Task<ActionResult<List<BillItemDTO>>> UpdateTableBill(int id, [FromBody] List<BillItemDTO> bill, string? waiterName)
        {
            bill = bill.Where(b => b.orderSent == false).ToList();

            var locations = await _context.NomenclatorLocaties.ToListAsync();
            foreach (var location in locations)
            {
                var locationBillItems = bill.Where(item => item.Product.Locatie == location.Id).ToList();
                if (locationBillItems.Count() > 0)
                {
                    var printer = _context.SetariImprimantaLocaties.FirstOrDefault(x => x.Idlocatie == location.Id);
                    if (printer != null && printer.Imprimanta != "Fara printare")
                    {
                        var table = await _context.MeseScaunes.FirstOrDefaultAsync(t => t.Id == bill[0].idTable);
                        var time = DateTime.Now;
                        PrintOrder(locationBillItems.ToList(), waiterName, location, table, time, printer.Imprimanta);
                    }
                }
            }

            foreach(var billItem in bill)
            {
                var productOnTable = await _context.ProdusePeMasas.FirstOrDefaultAsync(tableProduct => tableProduct.Id == billItem.Id);
                if (productOnTable!= null)
                {
                    if (billItem.Quantity == 0)
                    {
                        _context.ProdusePeMasas.Remove(productOnTable);
                        await _context.SaveChangesAsync();
                    } else
                    {
                        productOnTable.Cantitate = billItem.Quantity;
                        productOnTable.ComandaEfectuata = true;
                        await _context.SaveChangesAsync();
                    }
                    if (billItem.Mention != null)
                    {
                        _context.ProdusePeMasaMnetiunis.Add(new ProdusePeMasaMnetiuni()
                        {
                            Idprodus = productOnTable.Id,
                            Mentiune = billItem.Mention,
                            ComandaEfectuata = true
                        });
                        await _context.SaveChangesAsync();
                    }
                } else
                {
                    return NotFound($"Bill Item with id {billItem.Id} not found.");
                }
            }

            IQueryable<ProdusePeMasa> productsOnTable = _context.ProdusePeMasas.Where(x => x.Idscaun == id);
            var result = await productsOnTable.ToListAsync();

            var returnBill = await GetBillFromProductsOnTableAsync(result);

            return Ok(returnBill);
        }

        private async Task<List<BillItemDTO>> GetBillFromProductsOnTableAsync(List<ProdusePeMasa> productsOnTable)
        {
            var products = await this._context.Produses.ToListAsync();
            var predefinedQuantitiesList = await _context.ProdusCantitatiPredefinites.ToListAsync();
            var basePrices = await _context.PretProdusGestiunes.ToListAsync();
            var discountPrices = await _context.FidelizareProduses.ToListAsync();

            if (products.Count == 0 || predefinedQuantitiesList.Count == 0 || basePrices.Count == 0 || discountPrices.Count == 0)
            {
                return new List<BillItemDTO>();
            }

            var bill = productsOnTable.Select(productOnTable =>
            {
                var product = products.FirstOrDefault(product => product.Id == productOnTable.Idprodus);
                var predefinedQuantities = predefinedQuantitiesList.FindAll(q => q.Idprodus == product.Id);
                var mention = _context.ProdusePeMasaMnetiunis.FirstOrDefault(p_m => p_m.Idprodus == productOnTable.Id);

                var billItemDTO = new BillItemDTO();
                if (product != null)
                {
                    var basePrice = basePrices.FirstOrDefault(price => price.Idprodus == product.Id);
                    var discountPrice = discountPrices.FirstOrDefault(price => price.Produs == product.Id);
                    var productDTO = _mapper.Map<Produse, ProdusDTO>(product);
                    productDTO.CantitatiPredefinite = predefinedQuantities.Select(q => _mapper.Map<ProdusCantitatiPredefinite, CantitatePredefinitaDTO>(q)).ToList();
                    if (basePrice != null)
                    {
                        productDTO.Pret = basePrice.PretVanzare;
                    }
                    if (discountPrice != null)
                    {
                        productDTO.Pret = discountPrice.PretNou;
                    }
                    if (mention != null)
                    {
                        billItemDTO.Mention = mention.Mentiune;
                    }
                    billItemDTO.Id = productOnTable.Id;
                    billItemDTO.Product = productDTO;
                    billItemDTO.orderSent = productOnTable.ComandaEfectuata;
                    billItemDTO.PredefinedQuantity = productOnTable.CantitatePredefinita;
                }
                billItemDTO.idTable = productOnTable.Idscaun;
                billItemDTO.Quantity = productOnTable.Cantitate;
                return billItemDTO;
            });

            return bill.ToList();
        }

        private void PrintOrder(List<BillItemDTO> billItems, string waiterName, NomenclatorLocatie location, MeseScaune table, DateTime time, string printerName)
        {
            // Create a new PrintDocument object
            PrintDocument pd = new PrintDocument();
            var billPrintConfig = this._appSettings.GetSection("BillPrintConfig");

            // Set the printer name
            pd.PrinterSettings.PrinterName = printerName;

            // Set the page settings, such as paper size and orientation
            /*pd.DefaultPageSettings.PaperSize = new PaperSize("Thermal Printer Paper", 272, 1000);*/
            pd.DefaultPageSettings.PaperSize = new PaperSize(
                "Thermal Printer Paper",
                Int32.Parse(billPrintConfig.GetValue<string>("PaperHeight")),
                272
            );

            pd.DefaultPageSettings.Landscape = false;

            // Attach an event handler for the PrintPage event and pass arguments to it
            pd.PrintPage += new PrintPageEventHandler((sender, e) => PrintPageHandler(sender, e, billItems, waiterName, location, table, time));

            // Print the document
            try
            {
                pd.Print();
            } catch (Exception e) { }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e, List<BillItemDTO> billItems, string waiterName, NomenclatorLocatie location, MeseScaune table, DateTime time)
        {
            // Draw the contents of the document to the printer graphics object
            Graphics g = e.Graphics;
            var billPrintConfig = this._appSettings.GetSection("BillPrintConfig");
            var x = 16;
            var y = 24;
            /*var dataSource = myConfig.GetValue<string>("DataSource");*/
            var fontSize = Int32.Parse(billPrintConfig.GetValue<string>("FontSize"));
            var lineHeight = Int32.Parse(billPrintConfig.GetValue<string>("LineHeight"));
            var paperWidth = Int32.Parse(billPrintConfig.GetValue<string>("PaperWidth"));

            g.DrawString("Comandă Nouă", new Font("Arial", fontSize), Brushes.Black, x, y);
            y += fontSize + lineHeight * 2;
            g.DrawString($"Ospătar: {waiterName}", new Font("Arial", fontSize), Brushes.Black, x, y);
            y += fontSize + lineHeight * 2;
            g.DrawString($"Masa: {table.ToolTip}", new Font("Arial", fontSize), Brushes.Black, x, y);
            y += fontSize + lineHeight * 2;
            g.DrawString($"Scaun: {table.Name}", new Font("Arial", fontSize), Brushes.Black, x, y);
            y += fontSize + lineHeight * 2;
            g.DrawString($"Data/Ora: {time}", new Font("Arial", fontSize), Brushes.Black, x, y);
            y += fontSize + lineHeight * 2;
            g.DrawString("----------------------------------------", new Font("Arial", fontSize), Brushes.Black, x, y);
            y += fontSize + lineHeight * 2;
            foreach (var item in billItems)
            {
                var toDraw = $"{item.Product.Denumire}, ${item.Mention} - {item.Quantity} buc.";
                var multipleLines = ChunksUpTo(toDraw, paperWidth);
                foreach (var line in multipleLines)
                {
                    g.DrawString(line.ToString(), new Font("Arial", 12), Brushes.Black, x, y);
                    y += fontSize + (lineHeight * 3);
                }
            }
            g.DrawString("----------------------------------------", new Font("Arial", fontSize), Brushes.Black, x, y);
        }

        private IEnumerable<string> ChunksUpTo(string str, int maxChunkSize)
        {
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

    }
}
