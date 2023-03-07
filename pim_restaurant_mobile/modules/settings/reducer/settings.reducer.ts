import AsyncStorage from "@react-native-community/async-storage";
import { SET_BASE_URL } from './settings.actions';


export interface SettingsState {
  baseUrl: string;
}

const initialState : SettingsState = {
  baseUrl: 'https://localhost:7107'
};

const settingsReducer = (state = initialState, action: any) => {
  switch (action.type) {
    case SET_BASE_URL:
      return {
        ...state,
        baseUrl: action.baseUrl
      };
    default:
      return state;
  }
};

export default settingsReducer;
