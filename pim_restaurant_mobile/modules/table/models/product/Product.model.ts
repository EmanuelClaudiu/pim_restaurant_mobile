export class Product {
    id: number;
    name: string;
    idCategory: number;
    price: number;
    description: string;
    image: string;

    constructor(product: any) {
        this.id = product.id;
        this.name = product.name;
        this.idCategory = product.idSection;
        this.price = product.price;
        this.description = product.description;
        this.image = product.image;
    }
}