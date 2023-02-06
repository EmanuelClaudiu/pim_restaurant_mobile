import { Product } from './../../../table/models/product/Product.model';

export class BillItem {
    id: number;
    product: Product;
    idTable: number;
    quantity: number;

    constructor(billItem: any) {
        this.id = billItem.id;
        this.product = new Product(billItem.product) || null;
        this.idTable = billItem.idTable || 0;
        this.quantity = billItem.quantity || 0;
    }
}