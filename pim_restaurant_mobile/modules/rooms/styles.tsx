import { StyleSheet } from "react-native";
import { $pimRestaurantBlack, $pimRestaurantRed, $pimRestaurantSilver } from "../../constants/Colors";
import { $gridSize } from "../../constants/sizing";

export const styles = StyleSheet.create({
  container: {
    display: "flex",
    minHeight: "100vh",
    alignItems: "center",
    backgroundColor: $pimRestaurantBlack
  },
  genericText: {
    color: $pimRestaurantSilver,
    letterSpacing: 1.25,
    fontWeight: "500",
  },
  welcomeText: {
    color: $pimRestaurantSilver,
    fontSize: 24,
    marginTop: $gridSize * 3,
    marginBottom: $gridSize * 3,
    letterSpacing: 1.25,
  },
  restaurantText: {
    color: $pimRestaurantRed,
    fontSize: 24,
    fontWeight: "bold",
    marginBottom: $gridSize * 3,
    letterSpacing: 1.25,
  },
  room: {
    backgroundColor: $pimRestaurantSilver,
    width: "80%",
    height: 50,
    borderRadius: 5,
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
    marginTop: $gridSize * 2,
    marginBottom: $gridSize * 2,
  },
  roomText: {
    color: $pimRestaurantBlack,
    fontSize: 18,
    fontWeight: "bold",
    letterSpacing: 1.25,
  }
});
