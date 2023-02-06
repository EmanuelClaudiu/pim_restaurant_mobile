import { Masa } from './../../tables/models/table/Masa.model';
import { ProductsFilters } from './../index';
import axios from "axios";
import { ENVIRONMENT } from "../../../env/environment";
import { mock_categories } from "../../../mock_data/categories";
import { mock_products } from "../../../mock_data/products";
import { mock_sections } from "../../../mock_data/sections";
import { mock_tables } from "../../../mock_data/tables";
import { Restaurant } from "../../tables/models/restaurant/Restaurant.model";
import { Group } from "../models/group/Group.model";
import { Location } from "../models/location/Location.model";
import { Product } from "../models/product/Product.model";

// Actions
export const LOAD_PRODUCTS_REQUEST = "LOAD_PRODUCTS_REQUEST";
export const LOAD_PRODUCTS_SUCCESS = "LOAD_PRODUCTS_SUCCESS";
export const LOAD_PRODUCTS_FAILURE = "LOAD_PRODUCTS_FAILURE";

export const ADD_PRODUCT_REQUEST = "ADD_PRODUCT_REQUEST";
export const ADD_PRODUCT_SUCCESS = "ADD_PRODUCT_SUCCESS";
export const ADD_PRODUCT_FAILURE = "ADD_PRODUCT_FAILURE";

export const LOAD_LOCATIONS_REQUEST = "LOAD_LOCATIONS_REQUEST";
export const LOAD_LOCATIONS_SUCCESS = "LOAD_LOCATIONS_SUCCESS";
export const LOAD_LOCATIONS_FAILURE = "LOAD_LOCATIONS_FAILURE";

export const LOAD_GROUPS_REQUEST = "LOAD_GROUPS_REQUEST";
export const LOAD_GROUPS_SUCCESS = "LOAD_GROUPS_SUCCESS";
export const LOAD_GROUPS_FAILURE = "LOAD_GROUPS_FAILURE";

// Effects
export const loadProducts = (dispatch: any, filters: ProductsFilters = null) => {
  dispatch({ type: LOAD_PRODUCTS_REQUEST });
  const params = configureQueryParams(filters);
  axios
    .get(ENVIRONMENT.api.productsBaseUrl, { params })
    .then((response) => {
      dispatch({ type: LOAD_PRODUCTS_SUCCESS, products: mapProducts(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOAD_PRODUCTS_FAILURE, error });
    });
};

export const addProductOnBill = (dispatch: any, product: Product, table: Masa) => {
  dispatch({ type: ADD_PRODUCT_REQUEST });
  axios
    .post(`${ENVIRONMENT.api.productsBaseUrl}/${product.id}/AddToBill/${table.id}`)
    .then((response) => {
      dispatch({ type: ADD_PRODUCT_SUCCESS});
    })
    .catch((error) => {
      dispatch({ type: ADD_PRODUCT_FAILURE, error });
    });  
}

export const loadLocations = (dispatch: any) => {
  dispatch({ type: LOAD_LOCATIONS_REQUEST });

  axios
    .get(ENVIRONMENT.api.locationsBaseUrl)
    .then((response) => {
      dispatch({ type: LOAD_LOCATIONS_SUCCESS, locations: mapLocations(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOAD_LOCATIONS_FAILURE, error });
    });
};

export const loadGroups = (dispatch: any) => {
  dispatch({ type: LOAD_GROUPS_REQUEST });

  axios
    .get(ENVIRONMENT.api.groupsBaseUrl)
    .then((response) => {
      dispatch({ type: LOAD_GROUPS_SUCCESS, groups: mapGroups(response.data) });
    })
    .catch((error) => {
      dispatch({ type: LOAD_GROUPS_FAILURE, error });
    });
};

// Helpers
const configureQueryParams = (filters: ProductsFilters) => {
  const queryParams = {};

  if (!!filters && !!filters.group) {
    queryParams["idGroup"] = filters.group.id;
  }

  if (!!filters && !!filters.location) {
    queryParams["idLocation"] = filters.location.id;
  }

  return queryParams;
}

const mapProducts = (products: any) => {
  return products.map((product: any) => {
    return new Product(product);
  });
}

const mapLocations = (locations: any) => {
  return locations.map((location: any) => {
    return new Location(location);
  });
}

const mapGroups = (groups: any) => {
  return groups.map((group: any) => {
    return new Group(group);
  });
}