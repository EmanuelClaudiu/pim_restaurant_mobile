export class Locatie {
  id: number;
  denumire: string;
  departament: number;

  constructor(locatie: any) {
    this.id = locatie.id;
    this.denumire = locatie.denumire;
    this.departament = locatie.departament;
  }
}
