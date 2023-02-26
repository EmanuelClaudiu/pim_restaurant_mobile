import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import * as React from "react";
import { useSelector } from "react-redux";
import LoginScreen from "../modules/login";
import TablesScreen from "../modules/tables";
import { RootState } from "../Store";
import TableScreen from "../modules/table";
import { $pimRestaurantSilver } from "../constants/colors";
import BillScreen from "../modules/bill";
import RoomsScreen from "../modules/rooms";

export default function Navigation() {
  return (
    <NavigationContainer>
      <RootNavigator />
    </NavigationContainer>
  );
}

const Stack = createNativeStackNavigator();

function RootNavigator() {
  const authState = useSelector((state: RootState) => state.auth);

  return (
    <Stack.Navigator>
      {!!authState.waiter === false ? (
        <Stack.Screen
          name="Root"
          component={LoginScreen}
          options={{ headerShown: false }}
        />
      ) : (
        <>
          <Stack.Screen
            name="Rooms"
            component={RoomsScreen}
            options={{ headerStyle: { backgroundColor: $pimRestaurantSilver }, title: "Încăperi" }}
          />
          <Stack.Screen
            name="Tables"
            component={TablesScreen}
            options={{ headerStyle: { backgroundColor: $pimRestaurantSilver }, title: "Mese" }}
          />
          <Stack.Screen
            name="Table"
            component={TableScreen}
            options={{ headerStyle: { backgroundColor: $pimRestaurantSilver } }}
          />
          <Stack.Screen
            name="Bill"
            component={BillScreen}
            options={{ headerStyle: { backgroundColor: $pimRestaurantSilver } }}
          />
        </>
      )}
    </Stack.Navigator>
  );
}
