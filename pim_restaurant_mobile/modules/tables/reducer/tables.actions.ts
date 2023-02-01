import { Masa } from "./../models/table/Masa.model";
import axios from "axios";
import { ENVIRONMENT } from "../../../env/environment";
import { Sala } from "../../rooms/models/room/Sala.model";

// Actions
export const LOAD_TABLES_REQUEST = "LOAD_TABLES_REQUEST";
export const LOAD_TABLES_SUCCESS = "LOAD_TABLES_SUCCESS";
export const LOAD_TABLES_FAILURE = "LOAD_TABLES_FAILURE";

export const LOAD_TABLES_BY_ROOM_REQUEST = "LOAD_TABLES_BY_ROOM_REQUEST";
export const LOAD_TABLES_BY_ROOM_SUCCESS = "LOAD_TABLES_BY_ROOM_SUCCESS";
export const LOAD_TABLES_BY_ROOM_FAILURE = "LOAD_TABLES_BY_ROOM_FAILURE";

// Effects
export const loadTables = (dispatch: any) => {
  dispatch({ type: LOAD_TABLES_REQUEST });

  axios
    .get(ENVIRONMENT.api.tablesBaseUrl)
    .then((response) => {
      dispatch({ type: LOAD_TABLES_SUCCESS, tables: mapTables(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOAD_TABLES_FAILURE, error });
    });
};

export const loadTablesByRoom = (dispatch: any, room: Sala) => {
  dispatch({ type: LOAD_TABLES_BY_ROOM_REQUEST });

  axios
    .get(ENVIRONMENT.api.tablesBaseUrl, { params: { idSala: room.id } })
    .then((response) => {
      dispatch({ type: LOAD_TABLES_BY_ROOM_SUCCESS, tables: mapTables(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOAD_TABLES_BY_ROOM_FAILURE, error });
    });
};

// Helpers
const mapTables = (tables: any) => {
  return tables.map((table: any) => {
    return new Masa(table);
  });
};
