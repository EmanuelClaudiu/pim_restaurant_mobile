import { mock_tables } from './../../../mock_data/tables';
import { Restaurant } from "../models/restaurant/Restaurant.model";

export const LOAD_TABLES_REQUEST = "LOAD_TABLES_REQUEST";

export const LOAD_TABLES_SUCCESS = "LOAD_TABLES_SUCCESS";

export const LOAD_TABLES_FAILURE = "LOAD_TABLES_FAILURE";

export const loadTables = (dispatch: any, restaurant: Restaurant) => {
    try {
      dispatch({ type: LOAD_TABLES_REQUEST });
  
      // do REST API login call
      const tables = mock_tables;
  
      dispatch({ type: LOAD_TABLES_SUCCESS, tables });
    } catch (error) {
      dispatch({ type: LOAD_TABLES_FAILURE, error });
    }
  };