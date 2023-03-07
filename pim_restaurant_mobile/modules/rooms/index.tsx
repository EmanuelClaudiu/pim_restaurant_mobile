import { useEffect, useState } from "react";
import { Text, TouchableOpacity, View } from "react-native";
import { styles } from "./styles";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { RoomsState } from "./reducer/rooms.reducer";
import { loadRooms } from "./reducer/rooms.actions";
import { AuthState } from "../login/reducer/auth.reducer";
import { FontAwesome } from "@expo/vector-icons";
import { $pimRestaurantBlack } from "../../constants/colors";
import { $gridSize } from "../../constants/sizing";
import AsyncStorage from "@react-native-community/async-storage";
import { SET_BASE_URL } from "../settings/reducer/settings.actions";
import { Config } from "../settings/models/Config.model";
import { SettingsState } from "../settings/reducer/settings.reducer";

export default function RoomsScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const authState: AuthState = useSelector(
    (state: RootState) => state.auth
  );
  const roomsState: RoomsState = useSelector(
    (state: RootState) => state.rooms
  );
  const settingsState: SettingsState = useSelector((state: RootState) => state.settings);
  const dispatch = useDispatch();
  
  const [config, setConfig] = useState(new Config(dispatch, settingsState));

  useEffect(() => {
    navigation.setOptions({
      headerRight: () => (
        <TouchableOpacity onPress={() => navigation.navigate('Settings')}>
          <FontAwesome
            name="gear"
            size={24}
            style={{
              color: $pimRestaurantBlack,
              paddingRight: $gridSize * 2,
            }}
          />
        </TouchableOpacity>
      ),
    });

    const configureSettings = async () => {
      const baseUrl = JSON.parse(await AsyncStorage.getItem(`baseUrl`));
      if (!!baseUrl) {
        dispatch({ type: SET_BASE_URL, baseUrl });
      }
    };

    configureSettings();
    loadRooms(config);
  }, []);

  const dataFinishedLoading = () => {
    return !roomsState.isLoading && !authState.isLoading;
  };

  return dataFinishedLoading() ? (
    <View style={styles.container}>
      <Text style={styles.welcomeText}>Bună { authState.waiter.numeUtilizator }</Text>
      <Text style={styles.restaurantText}>PIM Restaurant</Text>
      {roomsState.rooms.map((room, index) => (
        <TouchableOpacity key={index} style={styles.room} onPress={() => {
          navigation.navigate("Tables", { room: room });
        }}>
          <Text style={styles.roomText}>{room.denumireSala}</Text>
        </TouchableOpacity>
      ))}
    </View>
  ) : (
    <View style={styles.container}>
      <Text style={styles.genericText}>Se încarcă...</Text>
    </View>
  );
} 
