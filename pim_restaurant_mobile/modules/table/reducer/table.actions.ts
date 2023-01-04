import { mock_categories } from '../../../mock_data/categories';
import { mock_products } from '../../../mock_data/products';
import { mock_sections } from '../../../mock_data/sections';
import { mock_tables } from '../../../mock_data/tables';
import { Restaurant } from '../../tables/models/restaurant/Restaurant.model';

export const LOAD_PRODUCTS_REQUEST = "LOAD_PRODUCTS_REQUEST";

export const LOAD_PRODUCTS_SUCCESS = "LOAD_PRODUCTS_SUCCESS";

export const LOAD_PRODUCTS_FAILURE = "LOAD_PRODUCTS_FAILURE";

export const loadTables = (dispatch: any, restaurant: Restaurant) => {
    try {
      dispatch({ type: LOAD_PRODUCTS_REQUEST });
  
      // do REST API login call
      const sections = mock_sections;
      const categories = mock_categories;
      const products = mock_products;
  
      dispatch({ type: LOAD_PRODUCTS_SUCCESS, sections, categories, products });
    } catch (error) {
      dispatch({ type: LOAD_PRODUCTS_FAILURE, error });
    }
  };