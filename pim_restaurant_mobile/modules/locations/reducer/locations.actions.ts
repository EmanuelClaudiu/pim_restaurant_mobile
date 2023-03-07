import { Locatie } from './../models/location/Locatie.model';
import { ENVIRONMENT } from "./../../../env/environment";
import axios from "axios";
import { Config } from '../../settings/models/Config.model';

// Actions
export const LOAD_LOCATIONS_REQUEST = "LOAD_LOCATIONS_REQUEST";

export const LOAD_LOCATIONS_SUCCESS = "LOAD_LOCATIONS_SUCCESS";

export const LOAD_LOCATIONS_FAILURE = "LOAD_LOCATIONS_FAILURE";

// Effects
export const loadLocations = (config: Config) => {
  config.dispatch({ type: LOAD_LOCATIONS_REQUEST });

  axios
    .get(ENVIRONMENT.api.locationsBaseUrl(config.settings.baseUrl))
    .then((response) => {
      config.dispatch({ type: LOAD_LOCATIONS_SUCCESS, locations: mapLocations(response.data) });
    })
    .catch((error) => {
      config.dispatch({ type: LOAD_LOCATIONS_FAILURE, error });
    });
};

// Helpers
const mapLocations = (locations: any) => {
  return locations.map((location: any) => {
    return new Locatie(location);
  });
};
