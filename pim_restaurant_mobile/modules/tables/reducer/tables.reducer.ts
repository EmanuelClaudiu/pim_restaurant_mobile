import { Masa } from "./../models/table/Masa.model";
import {
  LOAD_TABLES_BY_ROOM_FAILURE,
  LOAD_TABLES_BY_ROOM_REQUEST,
  LOAD_TABLES_BY_ROOM_SUCCESS,
  LOAD_TABLES_FAILURE,
  LOAD_TABLES_REQUEST,
  LOAD_TABLES_SUCCESS,
} from "./tables.actions";

export interface TablesState {
  tables: Masa[];
  isLoading: boolean;
  error: any;
}

const initialState: TablesState = {
  tables: null,
  isLoading: false,
  error: null,
};

const tablesReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_TABLES_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case LOAD_TABLES_SUCCESS:
      return {
        ...state,
        tables: action.tables,
        isLoading: false,
      };
    case LOAD_TABLES_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    case LOAD_TABLES_BY_ROOM_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case LOAD_TABLES_BY_ROOM_SUCCESS:
      return {
        ...state,
        tables: action.tables,
        isLoading: false,
      };
    case LOAD_TABLES_BY_ROOM_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default tablesReducer;
