import { Product } from './../../../table/models/product/Product.model';

export class BillItem {
    id: number;
    product: Product;
    quantity: number;

    constructor(billItem: any) {
        this.id = billItem.id;
        this.product = new Product(billItem.product) || null;
        this.quantity = billItem.quantity || 0;
    }
}