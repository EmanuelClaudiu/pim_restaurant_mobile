import { useEffect, useState } from "react";
import { Text, View } from "react-native";
import { styles } from "./styles";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { LocationsState } from "./reducer/locations.reducer";
import { SettingsState } from "../settings/reducer/settings.reducer";
import { Config } from "../settings/models/Config.model";

export default function LocationsScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const locationsState: LocationsState = useSelector(
    (state: RootState) => state.locations
  );
  const settingsState: SettingsState = useSelector((state: RootState) => state.settings);
  const dispatch = useDispatch();
  
  const [config, setConfig] = useState(new Config(dispatch, settingsState));

  useEffect(() => {
    // loadLocations(dispatch);
  }, []);

  return dataFinishedLoading(locationsState) ? (
    <View style={styles.container}>
    </View>
  ) : (
    <View style={styles.container}>
      <Text style={styles.genericText}>Se încarcă...</Text>
    </View>
  );
}

const dataFinishedLoading = (locationState: LocationsState) => {
  return !!locationState.locations;
};
