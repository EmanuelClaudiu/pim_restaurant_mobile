import { StyleSheet } from "react-native";
import { $pimRestaurantBlack, $pimRestaurantRed, $pimRestaurantSilver } from "../../constants/colors";
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
  }
});
