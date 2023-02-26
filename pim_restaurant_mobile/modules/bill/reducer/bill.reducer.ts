import { BillItem } from "../models/bill/BillItem.model";
import {
  LOAD_BILL_FAILURE,
  LOAD_BILL_REQUEST,
  LOAD_BILL_SUCCESS,
  PUT_BILL,
  PUT_BILL_FAILURE,
  PUT_BILL_REQUEST,
  PUT_BILL_SUCCESS,
} from "./bill.actions";

export interface BillState {
  bill: BillItem[];
  isLoading: boolean;
  error: any;
}

const initialState: BillState = {
  bill: [],
  isLoading: false,
  error: null,
};

const billReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_BILL_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case LOAD_BILL_SUCCESS:
      return {
        ...state,
        bill: action.bill,
        isLoading: false,
      };
    case LOAD_BILL_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    case PUT_BILL:
      return {
        ...state,
        bill: action.bill,
        error: action.error,
      };
    case PUT_BILL_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case PUT_BILL_SUCCESS:
      return {
        ...state,
        bill: action.bill,
        isLoading: false,
      };
    case PUT_BILL_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default billReducer;
