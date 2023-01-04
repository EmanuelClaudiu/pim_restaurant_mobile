import { Category } from "../modules/table/models/category/Category.model";

export const mock_categories: Category[] = [
    new Category({
        id: 1,
        name: 'Pizza',
        idSection: 1,
    }),
    new Category({
        id: 2,
        name: 'Drinks',
        idSection: 2,
    }),
    new Category({
        id: 3,
        name: 'Coffee',
        idSection: 2,
    }),
    new Category({
        id: 4,
        name: 'Wines',
        idSection: 2,
    }),
    new Category({
        id: 5,
        name: 'Beers',
        idSection: 2,
    }),
    new Category({
        id: 6,
        name: 'Fish',
        idSection: 1,
    }),
    new Category({
        id: 7,
        name: 'Whisky',
        idSection: 2,
    }),
    new Category({
        id: 8,
        name: 'Side dishes',
        idSection: 1,
    }),
    new Category({
        id: 9,
        name: 'Grill',
        idSection: 2,
    }),
    new Category({
        id: 10,
        name: 'Soups',
        idSection: 1,
    }),
    new Category({
        id: 11,
        name: 'Specialities',
        idSection: 1,
    }),
] 