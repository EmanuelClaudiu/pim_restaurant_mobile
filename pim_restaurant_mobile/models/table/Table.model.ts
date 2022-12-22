import { TABLE_STATUS } from "./table-status.enum";

export class Table {
  id: number;
  idRestaurant: string;
  status: TABLE_STATUS;

  constructor(table: any) {
    this.id = table.id;
    this.idRestaurant = table.idRestaurant;
    this.status = table.seats;
  }
}
