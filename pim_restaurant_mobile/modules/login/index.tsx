import { useState } from "react";
import { TextInput, Text, View, Pressable } from "react-native";
import { styles } from "./styles";
import { login } from "./reducer/auth.actions";
import { useDispatch } from "react-redux";

export default function LoginScreen({ navigation } : {navigation: any}) {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const dispatch = useDispatch();

  async function handleLogin() {
    login(dispatch, username, password);
  }

  return (
    <View style={styles.container}>
      <View style={styles.loginCard}>
        <Text style={styles.formTitle}>Login Ospătar</Text>
        <TextInput
          value={username}
          onChangeText={setUsername}
          placeholder="Nume de utilizator"
          style={styles.input}
        />
        <TextInput
          value={password}
          onChangeText={setPassword}
          placeholder="Parola"
          style={styles.input}
          secureTextEntry
        />
        <Pressable onPress={handleLogin} style={styles.button}>
          <Text style={styles.button.text}>ACCESEAZĂ</Text>
        </Pressable>
      </View>
    </View>
  );
}
