export class Product {
    id: number;
    categorie: string;
    denumire: string;
    grupa: number;
    locatie: number;
    pret: number;

    constructor(product: any) {
        this.id = product.id;
        this.categorie = product.categorie || '';
        this.denumire = product.denumire || '';
        this.grupa = product.grupa || 0;
        this.locatie = product.locatie || 0;
        this.pret = product.pret || 0;
    }
}