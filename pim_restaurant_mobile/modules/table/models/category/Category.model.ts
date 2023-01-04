import { Product } from "../product/Product.model";

export class Category {
    id: number;
    name: string;
    idSection: number;
    products: Product[];

    constructor(category: any) {
        this.id = category.id;
        this.name = category.name;
        this.idSection = category.idSection;
    }
}