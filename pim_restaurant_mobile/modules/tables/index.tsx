import { useEffect, useState } from "react";
import { Text, View, Pressable } from "react-native";
import { styles } from "./styles";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { $pimRestaurantGreen, $pimRestaurantRed } from "../../constants/Colors";
import { TablesState } from "./reducer/tables.reducer";
import { Sala } from "../rooms/models/room/Sala.model";
import { loadBillByTable } from "../bill/reducer/bill.actions";
import { loadGroups, loadProducts } from "../table/reducer/table.actions";
import { loadLocations } from "../locations/reducer/locations.actions";

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
              loadBillByTable(dispatch, table);
              loadProducts(dispatch);
              loadLocations(dispatch);
              loadGroups(dispatch);
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

const dataFinishedLoading = (tablesState: TablesState) => {
  return !tablesState.isLoading;
};