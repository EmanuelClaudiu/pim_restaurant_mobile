import { Category } from "../modules/table/models/category/Category.model";

export const mock_categories: Category[] = [
    new Category({
        id: 1,
        name: 'Pizza',
        idSection: 1,
    }),
    new Category({
        id: 2,
        name: 'Băuturi',
        idSection: 2,
    }),
    new Category({
        id: 3,
        name: 'Cafea',
        idSection: 2,
    }),
    new Category({
        id: 4,
        name: 'Vinuri',
        idSection: 2,
    }),
    new Category({
        id: 5,
        name: 'Bere',
        idSection: 2,
    }),
    new Category({
        id: 6,
        name: 'Pește',
        idSection: 1,
    }),
    new Category({
        id: 7,
        name: 'Whisky',
        idSection: 2,
    }),
    new Category({
        id: 8,
        name: 'Garnituri',
        idSection: 1,
    }),
    new Category({
        id: 9,
        name: 'Preparate la grătar',
        idSection: 2,
    }),
    new Category({
        id: 10,
        name: 'Ciorbe',
        idSection: 1,
    }),
    new Category({
        id: 11,
        name: 'Specialități',
        idSection: 1,
    }),
] 