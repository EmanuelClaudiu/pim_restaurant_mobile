import axios from "axios";
import { ENVIRONMENT } from "../../../env/environment";
import { mock_restaurants } from "../../../mock_data/restaurants";
import { mock_waiters } from "../../../mock_data/waiters";
import { Waiter } from "../models/waiter/Waiter.model";

export const LOGIN_REQUEST = "LOGIN_REQUEST";

export const LOGIN_SUCCESS = "LOGIN_SUCCESS";

export const LOGIN_FAILURE = "LOGIN_FAILURE";

export const LOGOUT_REQUEST = "LOGOUT_REQUEST";

export const LOGOUT_SUCCESS = "LOGOUT_REQUEST";

export const LOGOUT_FAILURE = "LOGOUT_REQUEST";

export const login = (dispatch: any, code: string) => {
  dispatch({ type: LOGIN_REQUEST });

  axios
    .post(`${ENVIRONMENT.api.loginBaseUrl}`, { code })
    .then((response) => {
      dispatch({ type: LOGIN_SUCCESS, waiter: new Waiter(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOGIN_FAILURE, error });
    });
};
