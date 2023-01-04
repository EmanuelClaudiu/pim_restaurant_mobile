import { createStore, combineReducers } from 'redux';
import authReducer from './modules/login/reducer/auth.reducer';
import tableReducer from './modules/table/reducer/table.reducer';
import tablesReducer from './modules/tables/reducer/tables.reducer';

const rootReducer = combineReducers({
  auth: authReducer,
  tables: tablesReducer,
  table: tableReducer,
});

export type RootState = ReturnType<typeof rootReducer>;

const store = createStore(rootReducer);

export default store;