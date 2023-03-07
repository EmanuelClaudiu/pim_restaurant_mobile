import { ENVIRONMENT } from "../../../env/environment";
import axios from "axios";
import { Sala } from "../models/room/Sala.model";
import { Config } from "../../settings/models/Config.model";

// Actions
export const LOAD_ROOMS_REQUEST = "LOAD_ROOMS_REQUEST";

export const LOAD_ROOMS_SUCCESS = "LOAD_ROOMS_SUCCESS";

export const LOAD_ROOMS_FAILURE = "LOAD_ROOMS_FAILURE";

// Effects
export const loadRooms = (config: Config) => {
  config.dispatch({ type: LOAD_ROOMS_REQUEST });

  axios
    .get(ENVIRONMENT.api.roomsBaseUrl(config.settings.baseUrl))
    .then((response) => {
      config.dispatch({ type: LOAD_ROOMS_SUCCESS, rooms: mapRooms(response.data) });
    })
    .catch((error) => {
      config.dispatch({ type: LOAD_ROOMS_FAILURE, error });
    });
};

// Helpers
const mapRooms = (rooms: any) => {
  return rooms.map((room: any) => {
    return new Sala(room);
  });
};
