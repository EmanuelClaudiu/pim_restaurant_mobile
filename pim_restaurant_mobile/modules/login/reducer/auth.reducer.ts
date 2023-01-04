import { Restaurant } from './../../tables/models/restaurant/Restaurant.model';
import { Waiter } from "../models/waiter/Waiter.model";
import { LOGIN_FAILURE, LOGIN_REQUEST, LOGIN_SUCCESS } from "./auth.actions";

interface AuthState {
  waiter: Waiter;
  restaurant: Restaurant;
  loading: boolean;
  error: any;
}

const initialState : AuthState = {
  waiter: null,
  restaurant: null,
  loading: false,
  error: null,
};

const authReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOGIN_REQUEST:
      return {
        ...state,
        loading: true,
        error: null,
      };
    case LOGIN_SUCCESS:
      return {
        ...state,
        waiter: action.waiter,
        restaurant: action.restaurant,
        loading: false,
      };
    case LOGIN_FAILURE:
      return {
        ...state,
        loading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default authReducer;
