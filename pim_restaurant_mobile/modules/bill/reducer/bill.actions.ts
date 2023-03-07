import { Masa } from './../../tables/models/table/Masa.model';
import { BillItem } from "./../models/bill/BillItem.model";
import axios from "axios";
import { ENVIRONMENT } from "../../../env/environment";
import { Config } from '../../settings/models/Config.model';
import { Waiter } from '../../login/models/waiter/Waiter.model';

// Actions
export const LOAD_BILL_REQUEST = "LOAD_BILL_REQUEST";
export const LOAD_BILL_SUCCESS = "LOAD_BILL_SUCCESS";
export const LOAD_BILL_FAILURE = "LOAD_BILL_FAILURE";

export const PUT_BILL = "PUT_BILL";

export const PUT_BILL_REQUEST = "PUT_BILL_REQUEST";
export const PUT_BILL_SUCCESS = "PUT_BILL_SUCCESS";
export const PUT_BILL_FAILURE = "PUT_BILL_FAILURE";

// Effects
export const loadBillByTable = (config: Config, table: Masa) => {
  config.dispatch({ type: LOAD_BILL_REQUEST });
  axios
    .get(ENVIRONMENT.api.billItemsBaseUrl(config.settings.baseUrl), { params: { idTable: table.id } })
    .then((response) => {
      config.dispatch({ type: LOAD_BILL_SUCCESS, bill: mapBillItems(response.data) });
    })
    .catch((error) => {
      config.dispatch({ type: LOAD_BILL_FAILURE, error });
    });
};

export const updateTableBill = (config: Config, table: Masa, waiter: Waiter, bill: BillItem[]) => {
  config.dispatch({ type: PUT_BILL_REQUEST });

  axios
    .put(`${ENVIRONMENT.api.tablesBaseUrl(config.settings.baseUrl)}/${table.id}/Bill`, bill, {params: {waiterName: waiter.numeUtilizator}})
    .then((response) => {
      config.dispatch({ type: PUT_BILL_SUCCESS, bill: mapBillItems(response.data) });
    })
    .catch((error) => {
      config.dispatch({ type: PUT_BILL_FAILURE, error });
    });
};

// Helpers
const mapBillItems = (billItems: any) => {
  return billItems.map((billItem: any) => {
    return new BillItem(billItem);
  });
};
