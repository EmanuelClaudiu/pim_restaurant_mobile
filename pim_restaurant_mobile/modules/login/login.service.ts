import { mock_waiters } from './../../mock_data/waiters';
import { Waiter } from "../../models/waiter/Waiter.model";

export const login = (email: string, password: string) : Promise<Waiter> => {
    return Promise.resolve(mock_waiters[0]);
}