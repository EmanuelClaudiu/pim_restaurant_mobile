import { createStore, combineReducers } from 'redux';
import billReducer from './modules/bill/reducer/bill.reducer';
import locationsReducer from './modules/locations/reducer/locations.reducer';
import authReducer from './modules/login/reducer/auth.reducer';
import roomsReducer from './modules/rooms/reducer/rooms.reducer';
import tableReducer from './modules/table/reducer/table.reducer';
import tablesReducer from './modules/tables/reducer/tables.reducer';

const rootReducer = combineReducers({
  auth: authReducer,
  tables: tablesReducer,
  table: tableReducer,
  bills: billReducer,
  locations: locationsReducer,
  rooms: roomsReducer
});

export type RootState = ReturnType<typeof rootReducer>;

const store = createStore(rootReducer);

export default store;