import { mock_restaurants } from "../../../mock_data/restaurants";
import { mock_waiters } from "../../../mock_data/waiters";
import { Waiter } from "../models/waiter/Waiter.model";

export const LOGIN_REQUEST = "LOGIN_REQUEST";

export const LOGIN_SUCCESS = "LOGIN_SUCCESS";

export const LOGIN_FAILURE = "LOGIN_FAILURE";

export const LOGOUT_REQUEST = "LOGOUT_REQUEST";

export const LOGOUT_SUCCESS = "LOGOUT_REQUEST";

export const LOGOUT_FAILURE = "LOGOUT_REQUEST";

export const login = (dispatch: any, email: string, password: string) => {
  try {
    dispatch({ type: LOGIN_REQUEST });

    // do REST API login call
    const waiter = mock_waiters[0];
    const restaurant = mock_restaurants[0];

    dispatch({ type: LOGIN_SUCCESS, waiter, restaurant });
  } catch (error) {
    dispatch({ type: LOGIN_FAILURE, error });
  }
};

export const logout = (dispatch: any) => {
    try {
      dispatch({ type: LOGIN_REQUEST });
  
      // do REST API login call
      const waiter = new Waiter({});
  
      dispatch({ type: LOGIN_SUCCESS, waiter });
    } catch (error) {
      dispatch({ type: LOGIN_FAILURE, error });
    }
  };
