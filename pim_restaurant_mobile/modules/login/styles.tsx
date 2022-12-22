import { StyleSheet } from "react-native";
import { $pimRestaurantRed, $pimRestaurantSilver } from "../../constants/Colors";

export const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: $pimRestaurantSilver
  },
  text: {
    color: "white"
  },
  button: {
    backgroundColor: $pimRestaurantRed,
  }
});
