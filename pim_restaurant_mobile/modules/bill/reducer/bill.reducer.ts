import { Bill } from "./../models/bill/Bill.model";
import {
  LOAD_BILLS_FAILURE,
  LOAD_BILLS_REQUEST,
  LOAD_BILLS_SUCCESS,
} from "./bill.actions";

interface BillState {
  bills: Bill[];
  loading: boolean;
  error: any;
}

const initialState: BillState = {
  bills: [],
  loading: false,
  error: null,
};

const billReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_BILLS_REQUEST:
      return {
        ...state,
        loading: true,
        error: null,
      };
    case LOAD_BILLS_SUCCESS:
      return {
        ...state,
        bills: action.bills,
        loading: false,
      };
    case LOAD_BILLS_FAILURE:
      return {
        ...state,
        loading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default billReducer;
