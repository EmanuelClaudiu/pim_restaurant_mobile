export class Waiter {
  id: number;
  name: string;
  surname: string;
  email: string;
  idRestaurant: number;

  constructor(waiter: any) {
    this.id = waiter.id;
    this.name = waiter.name;
    this.surname = waiter.surname;
    this.email = waiter.email;
    this.idRestaurant = waiter.idRestaurant;
  }
}