import { useEffect, useState } from "react";
import { Text, View, Pressable } from "react-native";
import { styles } from "./styles";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { $pimRestaurantGreen, $pimRestaurantRed } from "../../constants/colors";
import { TablesState } from "./reducer/tables.reducer";
import { Sala } from "../rooms/models/room/Sala.model";
import { loadTablesByRoom } from "./reducer/tables.actions";
import { useIsFocused } from "@react-navigation/native";
import { SettingsState } from "../settings/reducer/settings.reducer";
import { Config } from "../settings/models/Config.model";

export default function TablesScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const [room, setRoom] = useState<Sala>(route.params.room);
  const [isLoading, setIsLoading] = useState(true);
  const tablesState: TablesState = useSelector((state: RootState) => state.tables);
  const settingsState: SettingsState = useSelector((state: RootState) => state.settings);
  const dispatch = useDispatch();
  const isFocused = useIsFocused();

  const [config, setConfig] = useState(new Config(dispatch, settingsState));

  useEffect(() => {
    navigation.setOptions({ title: `${room.denumireSala}` });
    loadTablesByRoom(config, room);
    setIsLoading(false);
  }, []);

  useEffect(() => {
    isFocused && loadTablesByRoom(config, room);
  }, [isFocused]);
  
  const dataFinishedLoading = (tablesState: TablesState) => {
    return !isLoading && !tablesState.isLoading;
  };

  return dataFinishedLoading(tablesState) ? (
    <View style={styles.container}>
      <View style={styles.tablesContainer}>
        {tablesState.tables.map((table, key) => (
          <Pressable
            key={key}
            onPress={() => {
              navigation.navigate("Table", { table, room });
            }}
            style={[
              styles.table,
              {
                backgroundColor:
                  !table.occupied 
                    ? $pimRestaurantGreen
                    : $pimRestaurantRed,
              },
            ]}
          >
            <Text style={styles.text}>{table.name}</Text>
          </Pressable>
        ))}
      </View>
    </View>
  ) : (
    <View style={styles.container}>
      <Text style={styles.welcomeText}>Se încarcă...</Text>
    </View>
  );
}