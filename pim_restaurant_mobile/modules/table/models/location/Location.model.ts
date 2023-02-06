export class Location {
    id: number;
    denumire: string;
    departament: number;

    constructor(location: any) {
        this.id = location.id;
        this.denumire = location.denumire || '';
        this.departament = location.departament || 0;
    }
}