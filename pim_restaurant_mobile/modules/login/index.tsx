import { useState } from "react";
import {
  TextInput,
  Text,
  View,
  Pressable,
  TouchableOpacity,
} from "react-native";
import { styles } from "./styles";
import { login } from "./reducer/auth.actions";
import { useDispatch } from "react-redux";

export default function LoginScreen({ navigation }: { navigation: any }) {
  const [code, setCode] = useState("");

  const dispatch = useDispatch();

  const handleCodeChange = (input: any) => {
    setCode(isNaN(parseInt(input)) ? "" : input);
  };

  async function handleLogin() {
    login(dispatch, code);
  }

  return (
    <View style={styles.container}>
      <View style={styles.loginCard}>
        <Text style={styles.formTitle}>Login Ospătar</Text>
        <TextInput
          value={code}
          placeholder="Introdu parola"
          style={styles.input}
          onChangeText={(input) => {
            handleCodeChange(input);
          }}
          keyboardType="number-pad"
        />
        <TouchableOpacity onPress={handleLogin} style={styles.button}>
          <Text style={styles.buttonText}>ACCESEAZĂ</Text>
        </TouchableOpacity>
      </View>
    </View>
  );
}
