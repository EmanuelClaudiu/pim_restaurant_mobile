import { useNavigation } from "@react-navigation/native";
import { useEffect, useState } from "react";
import { Alert, TextInput, Text, View, Pressable } from "react-native";
import * as LoginService from "./login.service";
import { styles } from "./styles";
import * as SecureStore from 'expo-secure-store';
import AsyncStorage from '@react-native-community/async-storage';

export default function LoginScreen({ navigation } : {navigation: any}) {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  useEffect(() => {
    AsyncStorage.getItem("waiterId").then((waiterId) => {
      if (!!waiterId) {
        navigation.navigate("Tables", {waiterId: waiterId});
      }
    });
  }, []);

  async function handleLogin() {
    console.log("Login button pressed");
    const response = await LoginService.login(username, password);
    const data = await response;
    // error handling here
    // save user to state
    Alert.alert("Success", "You are now logged in");
    AsyncStorage.setItem("waiterId", data.toString());
    navigation.navigate("Tables", {waiterId: data});
  }

  return (
    <View style={styles.container}>
      <View style={styles.loginCard}>
        <Text style={styles.formTitle}>Waiter Login</Text>
        <TextInput
          value={username}
          onChangeText={setUsername}
          placeholder="Username"
          style={styles.input}
        />
        <TextInput
          value={password}
          onChangeText={setPassword}
          placeholder="Password"
          style={styles.input}
          secureTextEntry
        />
        <Pressable onPress={handleLogin} style={styles.button}>
          <Text style={styles.button.text}>LOG IN</Text>
        </Pressable>
      </View>
    </View>
  );
}
