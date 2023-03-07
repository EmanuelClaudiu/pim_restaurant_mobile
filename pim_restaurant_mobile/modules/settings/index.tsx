import { useState } from "react";
import { TextInput, Text, View, TouchableOpacity } from "react-native";
import { styles } from "./styles";
import { useDispatch, useSelector } from "react-redux";
import AsyncStorage from "@react-native-community/async-storage";
import { SettingsState } from "./reducer/settings.reducer";
import { RootState } from "../../Store";
import { SET_BASE_URL } from "./reducer/settings.actions";

export default function SettingsScreen({ navigation }: { navigation: any }) {
  const dispatch = useDispatch();
  const settingsState: SettingsState = useSelector(
    (state: RootState) => state.settings
  );
  const [baseUrl, setBaseUrl] = useState(settingsState.baseUrl);

  const useEffect = async () => {};

  const handleBaseUrlChange = (input: any) => {
    setBaseUrl(input);
  };

  return (
    <View style={styles.container}>
      <View style={styles.row}>
        <Text style={styles.rowLabel}>Base URL</Text>
        <View style={styles.rowForm}>
          <TextInput
            value={baseUrl}
            placeholder="Base URL"
            style={styles.input}
            onChangeText={(input) => {
              handleBaseUrlChange(input);
            }}
          />
          <TouchableOpacity style={styles.saveButton} onPress={() => {
            AsyncStorage.setItem(`baseUrl`, JSON.stringify(baseUrl));
            dispatch({ type: SET_BASE_URL, baseUrl });
          }}><Text style={styles.saveButtonText}>SALVEAZĂ</Text></TouchableOpacity>
        </View>
      </View>
    </View>
  );
}
