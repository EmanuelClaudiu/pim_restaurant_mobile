import { PredefinedQuantity } from "./../models/product/PredefinedCategory.model";
import { PUT_BILL } from "./../../bill/reducer/bill.actions";
import { Masa } from "./../../tables/models/table/Masa.model";
import { ProductsFilters } from "./../index";
import axios from "axios";
import { ENVIRONMENT } from "../../../env/environment";
import { Group } from "../models/group/Group.model";
import { Location } from "../models/location/Location.model";
import { Product } from "../models/product/Product.model";
import { Waiter } from "../../login/models/waiter/Waiter.model";
import { Config } from "../../settings/models/Config.model";

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
export const loadProducts = (
  config: Config,
  filters: ProductsFilters = null
) => {
  config.dispatch({ type: LOAD_PRODUCTS_REQUEST });
  const params = configureQueryParams(filters);
  axios
    .get(ENVIRONMENT.api.productsBaseUrl(config.settings.baseUrl), { params })
    .then((response) => {
      config.dispatch({
        type: LOAD_PRODUCTS_SUCCESS,
        products: mapProducts(response.data),
      });
    })
    .catch((error) => {
      config.dispatch({ type: LOAD_PRODUCTS_FAILURE, error });
    });
};

export const addProductOnBill = (
  config: Config,
  product: Product,
  table: Masa,
  user: Waiter,
  orderNumber: string,
  predefinedQuantity: PredefinedQuantity = null
) => {
  config.dispatch({ type: ADD_PRODUCT_REQUEST });
  axios
    .post(
      `${ENVIRONMENT.api.productsBaseUrl(config.settings.baseUrl)}/${product.id}/AddToBill/${table.id}`,
      {
        iduser: user.id,
        idProdusCantitatePredefinita: !!predefinedQuantity
          ? predefinedQuantity.id
          : null,
        numarComanda: orderNumber,
      }
    )
    .then((response) => {
      config.dispatch({ type: ADD_PRODUCT_SUCCESS });
      config.dispatch({ type: PUT_BILL, bill: response.data });
    })
    .catch((error) => {
      config.dispatch({ type: ADD_PRODUCT_FAILURE, error });
    });
};

export const loadLocations = (config: Config) => {
  config.dispatch({ type: LOAD_LOCATIONS_REQUEST });

  axios
    .get(ENVIRONMENT.api.locationsBaseUrl(config.settings.baseUrl))
    .then((response) => {
      config.dispatch({
        type: LOAD_LOCATIONS_SUCCESS,
        locations: mapLocations(response.data),
      });
    })
    .catch((error) => {
      config.dispatch({ type: LOAD_LOCATIONS_FAILURE, error });
    });
};

export const loadGroups = (config: Config) => {
  config.dispatch({ type: LOAD_GROUPS_REQUEST });

  axios
    .get(ENVIRONMENT.api.groupsBaseUrl(config.settings.baseUrl))
    .then((response) => {
      config.dispatch({ type: LOAD_GROUPS_SUCCESS, groups: mapGroups(response.data) });
    })
    .catch((error) => {
      config.dispatch({ type: LOAD_GROUPS_FAILURE, error });
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
};

const mapProducts = (products: any) => {
  return products.map((product: any) => {
    return new Product(product);
  });
};

const mapLocations = (locations: any) => {
  return locations.map((location: any) => {
    return new Location(location);
  });
};

const mapGroups = (groups: any) => {
  return groups.map((group: any) => {
    return new Group(group);
  });
};
