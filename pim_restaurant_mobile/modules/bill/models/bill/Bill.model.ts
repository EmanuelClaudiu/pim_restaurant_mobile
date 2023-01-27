import { BillItem } from "./BillItem.model";

export class Bill {
    id: number;
    idTable: number;
    items: BillItem[];
    price: number;

    constructor(bill: any) {
        this.id = bill.id;
        this.idTable = bill.idTable;
        this.items = bill.items || [];
        this.price = bill.price || 0;
    }
}