import { Masa } from "./../models/table/Masa.model";
import axios from "axios";
import { ENVIRONMENT } from "../../../env/environment";
import { Sala } from "../../rooms/models/room/Sala.model";
import { Config } from "../../settings/models/Config.model";

// Actions
export const LOAD_TABLES_REQUEST = "LOAD_TABLES_REQUEST";
export const LOAD_TABLES_SUCCESS = "LOAD_TABLES_SUCCESS";
export const LOAD_TABLES_FAILURE = "LOAD_TABLES_FAILURE";

export const LOAD_TABLES_BY_ROOM_REQUEST = "LOAD_TABLES_BY_ROOM_REQUEST";
export const LOAD_TABLES_BY_ROOM_SUCCESS = "LOAD_TABLES_BY_ROOM_SUCCESS";
export const LOAD_TABLES_BY_ROOM_FAILURE = "LOAD_TABLES_BY_ROOM_FAILURE";

// Effects
export const loadTables = (config: Config) => {
  config.dispatch({ type: LOAD_TABLES_REQUEST });

  axios
    .get(ENVIRONMENT.api.tablesBaseUrl(config.settings.baseUrl))
    .then((response) => {
      config.dispatch({ type: LOAD_TABLES_SUCCESS, tables: mapTables(response.data) });
    })
    .catch((error) => {
      config.dispatch({ type: LOAD_TABLES_FAILURE, error });
    });
};

export const loadTablesByRoom = (config: Config, room: Sala) => {
  config.dispatch({ type: LOAD_TABLES_BY_ROOM_REQUEST });

  axios
    .get(ENVIRONMENT.api.tablesBaseUrl(config.settings.baseUrl), { params: { idSala: room.id } })
    .then((response) => {
      config.dispatch({ type: LOAD_TABLES_BY_ROOM_SUCCESS, tables: mapTables(response.data) });
    })
    .catch((error) => {
      config.dispatch({ type: LOAD_TABLES_BY_ROOM_FAILURE, error });
    });
};

// Helpers
const mapTables = (tables: any) => {
  return tables.map((table: any) => {
    return new Masa(table);
  });
};
