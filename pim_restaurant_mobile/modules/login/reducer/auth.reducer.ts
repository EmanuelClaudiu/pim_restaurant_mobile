import { Waiter } from "../models/waiter/Waiter.model";
import { LOGIN_FAILURE, LOGIN_REQUEST, LOGIN_SUCCESS } from "./auth.actions";
import { ENVIRONMENT } from '../../../env/environment';

export interface AuthState {
  waiter: Waiter;
  restaurant: string;
  isLoading: boolean;
  error: any;
}

const initialState : AuthState = {
  waiter: null,
  restaurant: null,
  isLoading: false,
  error: null,
};

const authReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOGIN_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case LOGIN_SUCCESS:
      return {
        ...state,
        waiter: action.waiter,
        isLoading: false,
      };
    case LOGIN_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default authReducer;
