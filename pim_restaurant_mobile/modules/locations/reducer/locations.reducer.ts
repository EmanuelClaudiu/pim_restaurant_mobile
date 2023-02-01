import { Locatie } from './../models/location/Locatie.model';
import { LOAD_LOCATIONS_FAILURE, LOAD_LOCATIONS_REQUEST, LOAD_LOCATIONS_SUCCESS } from './locations.actions';

export interface LocationsState {
  locations: Locatie[];
  isLoading: boolean;
  error: any;
}

const initialState: LocationsState = {
  locations: null,
  isLoading: false,
  error: null,
};

const locationsReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case LOAD_LOCATIONS_REQUEST:
      return {
        ...state,
        loading: true,
        error: null,
      };
    case LOAD_LOCATIONS_SUCCESS:
      return {
        ...state,
        locations: action.locations,
        loading: false,
      };
    case LOAD_LOCATIONS_FAILURE:
      return {
        ...state,
        loading: false,
        error: action.error,
      };
    default:
      return state;
  }
};

export default locationsReducer;
