import { StyleSheet } from "react-native";
import { $pimRestaurantBlack, $pimRestaurantBlackTints, $pimRestaurantRed, $pimRestaurantSilver } from "../../constants/colors";

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
    height: "25vh",
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
  button: {
    backgroundColor: $pimRestaurantRed,
    color: 'white',
    width: '80%',
    height: '32px',
    marginBottom: '8px',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    borderRadius: 8,
  },
  buttonText : {
    color: 'white',
    letterSpacing: 1.2,
    fontWeight: '500'
  }
});
