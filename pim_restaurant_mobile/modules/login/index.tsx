import { useEffect, useState } from "react";
import { TextInput, Text, View, TouchableOpacity } from "react-native";
import { styles } from "./styles";
import { login } from "./reducer/auth.actions";
import { useDispatch, useSelector } from "react-redux";
import AsyncStorage from "@react-native-community/async-storage";
import { SET_BASE_URL } from "../settings/reducer/settings.actions";
import { SettingsState } from "../settings/reducer/settings.reducer";
import { RootState } from "../../Store";
import { Config } from "../settings/models/Config.model";

export default function LoginScreen({ navigation }: { navigation: any }) {
  
  const dispatch = useDispatch();
  const settingsState: SettingsState = useSelector((state: RootState) => state.settings);
  
  const [code, setCode] = useState("");
  const [config, setConfig] = useState(new Config(dispatch, settingsState));

  useEffect(() => {
    const configureOrderNumber = async () => {
      const orderNumber = JSON.parse(await AsyncStorage.getItem(`orderNumber`));
      if (!!!orderNumber) {
        await AsyncStorage.setItem(`orderNumber`, JSON.stringify(0));
      }
    };

    const configureSettings = async () => {
      const baseUrl = JSON.parse(await AsyncStorage.getItem(`baseUrl`));
      if (!!baseUrl) {
        dispatch({ type: SET_BASE_URL, baseUrl });
      }
    };

    configureOrderNumber();
    configureSettings();
  }, []);

  const handleCodeChange = (input: any) => {
    setCode(isNaN(parseInt(input)) ? "" : input);
  };

  async function handleLogin() {
    login(config, code);
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
        <View style={styles.buttons}>
          <TouchableOpacity onPress={handleLogin} style={styles.accessButton}>
            <Text style={styles.accessButtonText}>ACCESEAZĂ</Text>
          </TouchableOpacity>
          <TouchableOpacity
            onPress={() => {
              navigation.navigate("Settings");
            }}
            style={styles.settingsButton}
          >
            <Text style={styles.settingsButtonText}>SETĂRI</Text>
          </TouchableOpacity>
        </View>
      </View>
    </View>
  );
}
