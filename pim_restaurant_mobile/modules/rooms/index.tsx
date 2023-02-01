import { useEffect } from "react";
import { Text, TouchableOpacity, View } from "react-native";
import { styles } from "./styles";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { RoomsState } from "./reducer/rooms.reducer";
import { loadRooms } from "./reducer/rooms.actions";
import { loadTablesByRoom } from "../tables/reducer/tables.actions";

export default function RoomsScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const roomsState: RoomsState = useSelector(
    (state: RootState) => state.rooms
  );
  const dispatch = useDispatch();

  useEffect(() => {
    loadRooms(dispatch);
  }, []);

  return dataFinishedLoading(roomsState) ? (
    <View style={styles.container}>
      <Text style={styles.welcomeText}>Bună Ospatar Test</Text>
      <Text style={styles.restaurantText}>Restaurant Test</Text>
      {roomsState.rooms.map((room, index) => (
        <TouchableOpacity key={index} style={styles.room} onPress={() => {
          loadTablesByRoom(dispatch, room)
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

const dataFinishedLoading = (roomsState: RoomsState) => {
  return !roomsState.isLoading;
};
