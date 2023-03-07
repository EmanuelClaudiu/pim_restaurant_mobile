import { StyleSheet } from "react-native";
import { $pimRestaurantBlackTints, $pimRestaurantGreen, $pimRestaurantSilver } from "../../constants/colors";
import { $gridSize } from "../../constants/sizing";

export const styles = StyleSheet.create({
  container: {
    display: "flex",
    height: "100vh",
    rowGap: $gridSize * 3,
    padding: $gridSize * 3,
    alignItems: "center",
    backgroundColor: $pimRestaurantBlackTints[100],
  },
  row: {
    display: "flex",
    width: "100%",
    rowGap: $gridSize,
  },
  rowLabel: {
    color: $pimRestaurantSilver,
    fontSize: 21,
    letterSpacing: 1.25,
  },
  rowForm: {
    display: "flex",
    width: "100%",
    flexDirection: "row",
    columnGap: $gridSize,
  },
  saveButton: {
    backgroundColor: $pimRestaurantGreen,
    width: '30%',
    height: '32px',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    borderRadius: 8,
  },
  saveButtonText : {
    color: $pimRestaurantSilver,
    letterSpacing: 1.2,
    fontWeight: '500'
  },
  input: {
    backgroundColor: 'white',
    width: '70%',
    height: '32px',
    padding: '8px',
    borderRadius: 8,
    letterSpacing: 1.2,
  },
});
