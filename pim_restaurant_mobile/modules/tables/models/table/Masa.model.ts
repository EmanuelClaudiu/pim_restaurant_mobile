
export class Masa {
    id: number;
    idsala: number;
    name: string;
    occupied: boolean;
    acumPeScaun: number;

    constructor(masa: any) {
        this.id = masa.id;
        this.idsala = masa.idsala;
        this.name = masa.name;
        this.occupied = masa.occupied;
        this.acumPeScaun = masa.acumPeScaun;
    }
}