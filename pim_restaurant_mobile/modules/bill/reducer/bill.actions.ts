import { Masa } from './../../tables/models/table/Masa.model';
import { BillItem } from "./../models/bill/BillItem.model";
import axios from "axios";
import { ENVIRONMENT } from "../../../env/environment";
import { Product } from '../../table/models/product/Product.model';

// Actions
export const LOAD_BILL_REQUEST = "LOAD_BILL_REQUEST";
export const LOAD_BILL_SUCCESS = "LOAD_BILL_SUCCESS";
export const LOAD_BILL_FAILURE = "LOAD_BILL_FAILURE";

// Effects
export const loadBillByTable = (dispatch: any, table: Masa) => {
  dispatch({ type: LOAD_BILL_REQUEST });

  axios
    .get(ENVIRONMENT.api.billItemsBaseUrl, { params: { idTable: table.id } })
    .then((response) => {
      dispatch({ type: LOAD_BILL_SUCCESS, bill: mapBillItems(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOAD_BILL_FAILURE, error });
    });
};

// Helpers
const mapBillItems = (billItems: any) => {
  return billItems.map((billItem: any) => {
    return new BillItem(billItem);
  });
};
