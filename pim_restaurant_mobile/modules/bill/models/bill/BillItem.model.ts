import { Product } from './../../../table/models/product/Product.model';

export class BillItem {
    id: number;
    product: Product;
    idTable: number;
    orderSent: boolean;
    quantity: number;
    predefinedQuantity: number;

    constructor(billItem: any) {
        this.id = billItem.id;
        this.product = new Product(billItem.product) || null;
        this.idTable = billItem.idTable || 0;
        this.orderSent = billItem.orderSent || false;
        this.quantity = billItem.quantity || 0;
        this.predefinedQuantity = billItem.predefinedQuantity != null ? billItem.predefinedQuantity : 1;
    }
}