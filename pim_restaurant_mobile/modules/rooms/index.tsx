import { useEffect } from "react";
import { Text, TouchableOpacity, View } from "react-native";
import { styles } from "./styles";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { RoomsState } from "./reducer/rooms.reducer";
import { loadRooms } from "./reducer/rooms.actions";
import { AuthState } from "../login/reducer/auth.reducer";

export default function RoomsScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const authState: AuthState = useSelector(
    (state: RootState) => state.auth
  );
  const roomsState: RoomsState = useSelector(
    (state: RootState) => state.rooms
  );
  const dispatch = useDispatch();

  useEffect(() => {
    loadRooms(dispatch);
  }, []);

  const dataFinishedLoading = () => {
    return !roomsState.isLoading && !authState.isLoading;
  };

  return dataFinishedLoading() ? (
    <View style={styles.container}>
      <Text style={styles.welcomeText}>Bună { authState.waiter.numeUtilizator }</Text>
      <Text style={styles.restaurantText}>Restaurant Test</Text>
      {roomsState.rooms.map((room, index) => (
        <TouchableOpacity key={index} style={styles.room} onPress={() => {
          navigation.navigate("Tables", { room: room });
        }}>
          <Text style={styles.roomText}>{room.denumireSala}</Text>
        </TouchableOpacity>
      ))}
    </View>
  ) : (
    <View style={styles.container}>
      <Text style={styles.genericText}>Se încarcă...</Text>
    </View>
  );
} 
