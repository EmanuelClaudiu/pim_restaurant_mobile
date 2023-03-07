import { Config } from '../../settings/models/Config.model';
import axios from "axios";
import { ENVIRONMENT } from "../../../env/environment";
import { Waiter } from "../models/waiter/Waiter.model";

export const LOGIN_REQUEST = "LOGIN_REQUEST";

export const LOGIN_SUCCESS = "LOGIN_SUCCESS";

export const LOGIN_FAILURE = "LOGIN_FAILURE";

export const LOGOUT_REQUEST = "LOGOUT_REQUEST";

export const LOGOUT_SUCCESS = "LOGOUT_REQUEST";

export const LOGOUT_FAILURE = "LOGOUT_REQUEST";

export const login = (config: Config, code: string) => {
  const dispatch = config.dispatch;
  const settings = config.settings;
  
  dispatch({ type: LOGIN_REQUEST });

  axios
    .post(ENVIRONMENT.api.loginBaseUrl(settings.baseUrl), { code })
    .then((response) => {
      dispatch({ type: LOGIN_SUCCESS, waiter: new Waiter(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOGIN_FAILURE, error });
    });
};
