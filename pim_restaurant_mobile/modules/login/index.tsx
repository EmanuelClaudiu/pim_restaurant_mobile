import { useNavigation } from "@react-navigation/native";
import { useState } from "react";
import {
  Alert,
  TextInput,
  Text,
  View,
  Pressable,
} from "react-native";
import * as LoginService from "./login.service";
import { styles } from "./styles";

export default function LoginScreen() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const navigation = useNavigation();

  async function handleLogin() {
    console.log("Login button pressed");
    const response = await LoginService.login(username, password);
    const data = await response;
    // error handling here
    // save user to state
    Alert.alert("Success", "You are now logged in");
    navigation.navigate("NotFound");
  }

  return (
    <View style={styles.container}>
      <Text>Waiter Login</Text>
      <TextInput
        value={username}
        onChangeText={setUsername}
        placeholder="Username"
      />
      <TextInput
        value={password}
        onChangeText={setPassword}
        placeholder="Password"
        secureTextEntry
      />
      <Pressable onPress={handleLogin} style={styles.button}>
        <Text>Log In</Text>
      </Pressable>
    </View>
  );
}
