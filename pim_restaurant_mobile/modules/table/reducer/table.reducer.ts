import { Section } from "./../models/section/Section.model";
import { Table } from "../../tables/models/table/Table.model";
import { Category } from "../models/category/Category.model";
import { Product } from "../models/product/Product.model";
import { LOAD_PRODUCTS_FAILURE, LOAD_PRODUCTS_REQUEST, LOAD_PRODUCTS_SUCCESS } from "./table.actions";

interface TableState {
  sections: Section[];
  categories: Category[];
  products: Product[];
  loading: boolean;
  error: any;
}

const initialState: TableState = {
  sections: null,
  categories: null,
  products: null,
  loading: false,
  error: null,
};

const tableReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_PRODUCTS_REQUEST:
      return {
        ...state,
        loading: true,
        error: null,
      };
    case LOAD_PRODUCTS_SUCCESS:
      return {
        ...state,
        sections: action.sections,
        categories: action.categories,
        products: action.products,
        loading: false,
      };
    case LOAD_PRODUCTS_FAILURE:
      return {
        ...state,
        loading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default tableReducer;
