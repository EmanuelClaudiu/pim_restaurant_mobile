import { LOAD_ROOMS_FAILURE, LOAD_ROOMS_REQUEST, LOAD_ROOMS_SUCCESS } from './rooms.actions';
import { Sala } from "../models/room/Sala.model";

export interface RoomsState {
  rooms: Sala[];
  isLoading: boolean;
  error: any;
}

const initialState: RoomsState = {
  rooms: null,
  isLoading: true,
  error: null,
};

const roomsReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_ROOMS_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case LOAD_ROOMS_SUCCESS:
      return {
        ...state,
        rooms: action.rooms,
        isLoading: false,
      };
    case LOAD_ROOMS_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default roomsReducer;
