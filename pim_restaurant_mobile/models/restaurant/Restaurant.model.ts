import { Receipt } from "../receipt/Receipt.model";
import { Table } from "../table/Table.model";
import { Waiter } from "../waiter/Waiter.model";

export class Restaurant {
  id: number;
  name: string;
  address: string;
  city: string;
  country: string;
  email: string;
  password: string;
  phone: string;
  postalCode: string;
  province: string;
  tables: Table[];
  waiters: Waiter[];
  receipts: Receipt[];

  constructor(restaurant: any) {
    this.id = restaurant.id;
    this.name = restaurant.name;
    this.address = restaurant.address;
    this.city = restaurant.city;
    this.country = restaurant.country;
    this.email = restaurant.email;
    this.password = restaurant.password;
    this.phone = restaurant.phone;
    this.postalCode = restaurant.postalCode;
    this.province = restaurant.province;
    this.tables = restaurant.tables;
    this.waiters = restaurant.waiters;
    this.receipts = restaurant.receipts;
  }
}
