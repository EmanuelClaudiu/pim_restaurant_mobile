import { RECEIPT_STATUS } from "./receipt-status.enum";

export class Receipt {
  id: number;
  idRestaurant: string;
  idTable: number;
  idWaiter: string;
  date: Date;
  total: number;
  status: RECEIPT_STATUS;

  constructor(receipt: any) {
    this.id = receipt.id;
    this.idRestaurant = receipt.idRestaurant;
    this.idTable = receipt.idTable;
    this.idWaiter = receipt.idWaiter;
    this.date = receipt.date;
    this.total = receipt.total;
    this.status = receipt.status;
  }
}
