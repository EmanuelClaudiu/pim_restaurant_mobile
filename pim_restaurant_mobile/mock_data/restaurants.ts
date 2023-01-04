import { mock_sections } from './sections';
import { Restaurant } from "../modules/tables/models/restaurant/Restaurant.model";

export const mock_restaurants : Restaurant[] = [
    new Restaurant({
        id: 1,
        name: 'Restaurant Bella Roma',
        address: 'Via Roma 1',
        city: 'Roma',
        country: 'Italy',
        email: 'via_roma@yahoo.com',
        password: '123456',
        phone: '1234567890',
        postalCode: '00100',
        province: 'Roma',
        sections: mock_sections,
        tables: [],
        waiters: [],
        receipts: [],
    }),
    new Restaurant({
        id: 2,
        name: 'Restaurant 2',
        address: 'Via Roma 2',
        city: 'Roma',
        country: 'Italy',
        email: 'not_via_roma@gmail.com',
        password: '123456',
        phone: '1234567890',
        postalCode: '00100',
        province: 'Roma',
        tables: [],
        waiters: [],
        receipts: [],
    })
];