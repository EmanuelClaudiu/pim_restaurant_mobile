import { StyleSheet } from "react-native";
import { $pimRestaurantBlack, $pimRestaurantRed, $pimRestaurantSilver } from "../../constants/Colors";
import { $gridSize } from "../../constants/sizing";

export const styles = StyleSheet.create({
  container: {
    display: "flex",
    height: "100vh",
    alignItems: "center",
    backgroundColor: $pimRestaurantBlack
  },
  welcomeText: {
    color: $pimRestaurantSilver,
    fontSize: 24,
    marginTop: $gridSize * 3,
    marginBottom: $gridSize * 3
  },
  restaurantText: {
    color: $pimRestaurantRed,
    fontSize: 24,
    fontWeight: "bold",
    marginBottom: $gridSize * 3
  },
  tablesContainer: {
    display: "flex",
    flexWrap: "wrap",
    flexDirection: "row",
    width: "90%",
    columnGap: $gridSize * 4,
    rowGap: $gridSize * 4,
    alignContent: "center",
    justifyContent: "center",
    marginTop: $gridSize * 3,
  },
  table: {
    display: "flex",
    width: "25%",
    height: 100,
    color: $pimRestaurantSilver,
    backgroundColor: $pimRestaurantRed,
    borderRadius: 10,
    alignItems: "center",
    justifyContent: "center",
  },
  text: {
    color: $pimRestaurantSilver,
  },
});
