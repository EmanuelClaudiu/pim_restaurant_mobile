import { Waiter } from '../models/waiter/Waiter.model';

export const mock_waiters : Waiter[] = [
    new Waiter({
        id: 1,
        name: 'John',
        surname: 'Doe',
        email: 'john_doe@yahoo.com',
        password: '123456',
        idRestaurant: 1,
    }),
    new Waiter({
        id: 2,
        name: 'Jane',
        surname: 'Doe',
        email: 'jane_doe@gmail.com',
        password: '123456',
        idRestaurant: 1,
    }),
    new Waiter({
        id: 3,
        name: 'John',
        surname: 'Smith',
        email: 'john.smith@outlook.com',
        password: '123456',
        idRestaurant: 1,
    })
];