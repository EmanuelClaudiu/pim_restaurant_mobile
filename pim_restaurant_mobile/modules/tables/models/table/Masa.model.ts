
export class Masa {
    id: number;
    idsala: number;
    name: string;
    acumPeScaun: number;

    constructor(masa: any) {
        this.id = masa.id;
        this.idsala = masa.idsala;
        this.name = masa.name;
        this.acumPeScaun = masa.acumPeScaun;
    }
}