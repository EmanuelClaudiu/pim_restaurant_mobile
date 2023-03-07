import { SettingsState } from '../reducer/settings.reducer';
export class Config {
  dispatch: any;
  settings: SettingsState;

  constructor(dispatch: any, settings: any) {
    this.dispatch = dispatch;
    this.settings = settings;
  }
}
