import { useEffect, useState } from "react";
import { Text, View, Pressable } from "react-native";
import { styles } from "./styles";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { $pimRestaurantGreen, $pimRestaurantRed } from "../../constants/Colors";
import { TablesState } from "./reducer/tables.reducer";
import { Sala } from "../rooms/models/room/Sala.model";

export default function TablesScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const [room, setRoom] = useState<Sala>(route.params.room);
  const tablesState: TablesState = useSelector((state: RootState) => state.tables);
  const dispatch = useDispatch();

  useEffect(() => {
    navigation.setOptions({ title: `${room.denumireSala}` });
  }, []);

  return dataFinishedLoading(tablesState) ? (
    <View style={styles.container}>
      <View style={styles.tablesContainer}>
        {tablesState.tables.map((table, key) => (
          <Pressable
            key={key}
            onPress={() => {
              navigation.navigate("Table", { table: table });
            }}
            style={[
              styles.table,
              {
                backgroundColor:
                  table.acumPeScaun === -1
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

const dataFinishedLoading = (tablesState: TablesState) => {
  return !tablesState.isLoading;
};