import { PredefinedQuantity } from './PredefinedCategory.model';
export class Product {
    id: number;
    categorie: string;
    denumire: string;
    grupa: number;
    locatie: number;
    pret: number;
    cantitatiPredefinite: PredefinedQuantity[];

    constructor(product: any) {
        this.id = product.id;
        this.categorie = product.categorie || '';
        this.denumire = product.denumire || '';
        this.grupa = product.grupa || 0;
        this.locatie = product.locatie || 0;
        this.pret = product.pret || 0;
        this.cantitatiPredefinite = !!product.cantitatiPredefinite ? product.cantitatiPredefinite.map(c => new PredefinedQuantity(c)) : [];
    }
}