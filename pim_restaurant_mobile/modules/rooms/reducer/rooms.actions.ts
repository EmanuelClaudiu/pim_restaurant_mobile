import { ENVIRONMENT } from "../../../env/environment";
import axios from "axios";
import { Sala } from "../models/room/Sala.model";

// Actions
export const LOAD_ROOMS_REQUEST = "LOAD_ROOMS_REQUEST";

export const LOAD_ROOMS_SUCCESS = "LOAD_ROOMS_SUCCESS";

export const LOAD_ROOMS_FAILURE = "LOAD_ROOMS_FAILURE";

// Effects
export const loadRooms = (dispatch: any) => {
  dispatch({ type: LOAD_ROOMS_REQUEST });

  axios
    .get(ENVIRONMENT.api.roomsBaseUrl)
    .then((response) => {
      dispatch({ type: LOAD_ROOMS_SUCCESS, rooms: mapRooms(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOAD_ROOMS_FAILURE, error });
    });
};

// Helpers
const mapRooms = (rooms: any) => {
  return rooms.map((room: any) => {
    return new Sala(room);
  });
};
