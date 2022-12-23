import { useNavigation } from "@react-navigation/native";
import { useEffect, useState } from "react";
import { Alert, TextInput, Text, View, Pressable } from "react-native";
import * as TablesService from "./tables.service";
import { styles } from "./styles";
import { mock_waiters } from "../../mock_data/waiters";
import * as SecureStore from "expo-secure-store";
import { Waiter } from "../../models/waiter/Waiter.model";
import AsyncStorage from "@react-native-community/async-storage";

export interface TableScreenProps {
  waiterId: number;
}

export default function TablesScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const [waiter, setWaiter] = useState(new Waiter({}));

  useEffect(() => {
    AsyncStorage.getItem("waiterId").then((waiterId) => {
      if (!!waiterId) {
        setWaiter(mock_waiters[+waiterId]);
      }
    });
  }, []);

  return (
    <View style={styles.container}>
      <Text>Tables Screen</Text>
      <Text>Welcome {waiter.name}</Text>
      <Pressable onPress={() => {
        AsyncStorage.removeItem("waiterId");
        navigation.navigate("Root");
      }} >
        <Text>Log Out</Text>
      </Pressable>
    </View>
  );
}
