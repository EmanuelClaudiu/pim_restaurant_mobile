import { Category } from "../category/Category.model";

export class Section {
    id: number;
    name: string;
    idRestaurant: number;
    categories: Category[];

    constructor(section: any) {
        this.id = section.id;
        this.name = section.name;
        this.idRestaurant = section.idRestaurant;
        this.categories = section.categories;
    }
}