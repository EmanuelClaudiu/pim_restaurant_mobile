import { Product } from "./../modules/table/models/product/Product.model";
import { BillItem } from "./../modules/bill/models/bill/BillItem.model";
import { Bill } from "../modules/bill/models/bill/Bill.model";

export const mock_bills: Bill[] = [
  new Bill({
    idTable: 1,
    items: [
      new BillItem({
        product: new Product({
          id: 1,
          name: "Pizza Margherita",
          idCategory: 1,
          price: 25.0,
          description: "Pizza Margherita",
          image:
            "https://www.pizzaprimo.it/wp-content/uploads/2019/03/pizza-margherita.jpg",
        }),
        quantity: 2,
      }),
      new BillItem({
        product: new Product({
          id: 14,
          name: "Coca Cola",
          idCategory: 2,
          price: 6.0,
          description: "Coca Cola",
          image:
            "https://www.pizzaprimo.it/wp-content/uploads/2019/03/coca-cola.jpg",
        }),
        quantity: 2,
      }),
    ],
    price: 62.0,
  }),
  new Bill({
    idTable: 2,
    items: [],
    price: 0.0,
  }),
  new Bill({
    idTable: 3,
    items: [],
    price: 0.0,
  }),
  new Bill({
    idTable: 4,
    items: [],
    price: 0.0,
  }),
  new Bill({
    idTable: 5,
    items: [],
    price: 0.0,
  }),
  new Bill({
    idTable: 6,
    items: [
      new BillItem({
        product: new Product({
          id: 24,
          name: "Ceafă de porc",
          idCategory: 9,
          price: 28.0,
          description: "Ceafă de porc",
          image:
            "https://www.pizzaprimo.it/wp-content/uploads/2019/03/ceafa-de-porc.jpg",
        }),
        quantity: 1,
      }),
      new BillItem({
        product: new Product({
          id: 21,
          name: "Păstrăv File",
          idCategory: 6,
          price: 30.0,
          description: "Păstrăv File",
          image:
            "https://www.pizzaprimo.it/wp-content/uploads/2019/03/pastrav-file.jpg",
        }),
        quantity: 1,
      }),
      new BillItem({
        product: new Product({
          id: 17,
          name: "Apă Plată",
          idCategory: 2,
          price: 5.0,
          description: "Apă Plată",
          image:
            "https://www.pizzaprimo.it/wp-content/uploads/2019/03/acqua.jpg",
        }),
        quantity: 2,
      }),
    ],
    price: 68.00,
  }),
  new Bill({
    idTable: 7,
    items: [],
    price: 0.0,
  }),
  new Bill({
    idTable: 8,
    items: [],
    price: 0.0,
  }),
  new Bill({
    idTable: 9,
    items: [],
    price: 0.0,
  }),
  new Bill({
    idTable: 10,
    items: [],
    price: 0.0,
  }),
  new Bill({
    idTable: 11,
    items: [],
    price: 0.0,
  }),
];
