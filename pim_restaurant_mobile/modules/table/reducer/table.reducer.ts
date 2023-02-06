import { Section } from "./../models/section/Section.model";
import { Table } from "../../tables/models/table/Table.model";
import { Category } from "../models/category/Category.model";
import { Product } from "../models/product/Product.model";
import {
  ADD_PRODUCT_FAILURE,
  ADD_PRODUCT_REQUEST,
  ADD_PRODUCT_SUCCESS,
  LOAD_GROUPS_FAILURE,
  LOAD_GROUPS_REQUEST,
  LOAD_GROUPS_SUCCESS,
  LOAD_LOCATIONS_FAILURE,
  LOAD_LOCATIONS_REQUEST,
  LOAD_LOCATIONS_SUCCESS,
  LOAD_PRODUCTS_FAILURE,
  LOAD_PRODUCTS_REQUEST,
  LOAD_PRODUCTS_SUCCESS,
} from "./table.actions";
import { Location } from "../models/location/Location.model";
import { Group } from "../models/group/Group.model";

export interface TableState {
  products: Product[];
  locations: Location[];
  groups: Group[];
  isLoading: boolean;
  error: any;
}

const initialState: TableState = {
  products: null,
  locations: null,
  groups: null,
  isLoading: false,
  error: null,
};

const tableReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_PRODUCTS_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case LOAD_PRODUCTS_SUCCESS:
      return {
        ...state,
        products: action.products,
        isLoading: false,
      };
    case LOAD_PRODUCTS_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    case ADD_PRODUCT_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case ADD_PRODUCT_SUCCESS:
      return {
        ...state,
        isLoading: false,
      };
    case ADD_PRODUCT_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    case LOAD_LOCATIONS_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case LOAD_LOCATIONS_SUCCESS:
      return {
        ...state,
        locations: action.locations,
        isLoading: false,
      };
    case LOAD_LOCATIONS_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    case LOAD_GROUPS_REQUEST:
      return {
        ...state,
        isLoading: true,
        error: null,
      };
    case LOAD_GROUPS_SUCCESS:
      return {
        ...state,
        groups: action.groups,
        isLoading: false,
      };
    case LOAD_GROUPS_FAILURE:
      return {
        ...state,
        isLoading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default tableReducer;
