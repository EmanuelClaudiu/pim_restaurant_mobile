import { TABLE_STATUS } from "../modules/tables/models/table/table-status.enum";
import { Table } from "../modules/tables/models/table/Table.model";


export const mock_tables : Table[] = [
    {
        id: 1,
        idRestaurant: 1,
        status: TABLE_STATUS.OCCUPIED
    },
    {
        id: 2,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
    {
        id: 3,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
    {
        id: 4,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
    {
        id: 5,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
    {
        id: 6,
        idRestaurant: 1,
        status: TABLE_STATUS.OCCUPIED
    },
    {
        id: 7,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
    {
        id: 8,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
    {
        id: 9,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
    {
        id: 10,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
    {
        id: 11,
        idRestaurant: 1,
        status: TABLE_STATUS.FREE
    },
]