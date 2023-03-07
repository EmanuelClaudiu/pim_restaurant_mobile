import { StyleSheet } from "react-native";
import { $pimRestaurantBlack, $pimRestaurantBlackTints, $pimRestaurantRed, $pimRestaurantSilver } from "../../constants/colors";
import { $gridSize } from "../../constants/sizing";

export const styles = StyleSheet.create({
  container: {
    display: "flex",
    height: "100vh",
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: $pimRestaurantBlackTints[500],
  },
  loginCard: {
    backgroundColor: $pimRestaurantBlack,
    height: "35vh",
    width: "70vw",
    display: "flex",
    alignItems: "center",
    justifyContent: "space-evenly",
    rowGap: 24,
    borderRadius: 25,
  },
  formTitle: {
    color: 'white',
    fontSize: 32,
    letterSpacing: 1.25,
  },
  input: {
    backgroundColor: 'white',
    width: '80%',
    height: '32px',
    padding: '8px',
    borderRadius: 8,
    letterSpacing: 1.2,
  },
  buttons: {
    width: '80%',
    marginBottom: '8px',
    display: 'flex',
    rowGap: $gridSize * 3,
  },
  accessButton: {
    backgroundColor: $pimRestaurantRed,
    color: 'white',
    width: '100%',
    height: '32px',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    borderRadius: 8,
  },
  accessButtonText : {
    color: 'white',
    letterSpacing: 1.2,
    fontWeight: '500'
  },
  settingsButton: {
    backgroundColor: $pimRestaurantSilver,
    width: '100%',
    height: '32px',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    borderRadius: 8,
  },
  settingsButtonText : {
    color: $pimRestaurantBlack,
    letterSpacing: 1.2,
    fontWeight: '500'
  }
});
