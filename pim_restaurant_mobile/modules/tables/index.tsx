import { useNavigation } from "@react-navigation/native";
import { useEffect, useState } from "react";
import { Alert, TextInput, Text, View, Pressable } from "react-native";
import * as TablesService from "./tables.service";
import { styles } from "./styles";
import { mock_waiters } from "../../mock_data/waiters";
import * as SecureStore from "expo-secure-store";
import { Waiter } from "../login/models/waiter/Waiter.model";
import AsyncStorage from "@react-native-community/async-storage";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { loadTables } from "./reducer/tables.actions";
import { TABLE_STATUS } from "./models/table/table-status.enum";
import { $pimRestaurantGreen, $pimRestaurantRed } from "../../constants/Colors";

export default function TablesScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const authState = useSelector((state: RootState) => state.auth);
  const tableState = useSelector((state: RootState) => state.tables);
  const dispatch = useDispatch();

  useEffect(() => {
    loadTables(dispatch, authState.restaurant);
  }, []);

  return !!tableState.tables ? (
    <View style={styles.container}>
      <Text style={styles.welcomeText}>Welcome {authState.waiter.name}</Text>
      <Text style={styles.restaurantText}>{authState.restaurant.name}</Text>
      <View style={styles.tablesContainer}>
        {tableState.tables.map((table, key) => (
          <Pressable
            key={key}
            onPress={() => {
              navigation.navigate("Table", { table });
            }}
            style={[
              styles.table,
              {
                backgroundColor:
                  table.status === TABLE_STATUS.FREE
                    ? $pimRestaurantGreen
                    : $pimRestaurantRed,
              },
            ]}
          >
            <Text style={styles.text}>Table {key + 1}</Text>
          </Pressable>
        ))}
      </View>
    </View>
  ) : (
    <View style={styles.container}>
      <Text style={styles.welcomeText}>Loading...</Text>
    </View>
  );
}
