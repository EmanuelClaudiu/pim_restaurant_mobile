import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import * as React from "react";
import { useEffect, useState } from "react";
import { useSelector } from "react-redux";
import LoginScreen from "../modules/login";
import TablesScreen from "../modules/tables";
import { RootState } from "../Store";
import AsyncStorage from "@react-native-community/async-storage";
import TableScreen from "../modules/table";

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
          <Stack.Screen name="Tables" component={TablesScreen} />
          <Stack.Screen name="Table" component={TableScreen} />
        </>
      )}
    </Stack.Navigator>
  );
}
