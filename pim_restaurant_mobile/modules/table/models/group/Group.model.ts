export class Group {
    id: number;
    denumire: string;

    constructor(group: any) {
        this.id = group.id;
        this.denumire = group.denumire || '';
    }
}