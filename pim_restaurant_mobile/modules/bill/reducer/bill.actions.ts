import { mock_bills } from './../../../mock_data/bills';
export const LOAD_BILLS_REQUEST = "LOAD_BILLS_REQUEST";

export const LOAD_BILLS_SUCCESS = "LOAD_BILLS_SUCCESS";

export const LOAD_BILLS_FAILURE = "LOAD_BILLS_FAILURE";

export const loadBills = (dispatch: any) => {
    try {
      dispatch({ type: LOAD_BILLS_REQUEST });

      // do REST API login call
      const bills = mock_bills;

      dispatch({ type: LOAD_BILLS_SUCCESS, bills });
    } catch (error) {
      dispatch({ type: LOAD_BILLS_FAILURE, error });
    }
  };
