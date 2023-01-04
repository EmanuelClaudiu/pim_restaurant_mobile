import { LOAD_TABLES_FAILURE, LOAD_TABLES_REQUEST, LOAD_TABLES_SUCCESS } from './tables.actions';
import { Table } from "../models/table/Table.model";

interface TablesState {
  tables: Table[];
  loading: boolean;
  error: any;
}

const initialState: TablesState = {
  tables: null,
  loading: false,
  error: null,
};

const tablesReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_TABLES_REQUEST:
      return {
        ...state,
        loading: true,
        error: null,
      };
    case LOAD_TABLES_SUCCESS:
      return {
        ...state,
        tables: action.tables,
        loading: false,
      };
    case LOAD_TABLES_FAILURE:
      return {
        ...state,
        loading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default tablesReducer;
