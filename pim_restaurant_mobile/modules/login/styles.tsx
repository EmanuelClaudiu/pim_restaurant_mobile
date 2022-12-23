import { StyleSheet } from "react-native";
import { $pimRestaurantBlack, $pimRestaurantRed, $pimRestaurantSilver } from "../../constants/Colors";

export const styles = StyleSheet.create({
  container: {
    display: "flex",
    height: "100vh",
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: $pimRestaurantSilver
  },
  loginCard: {
    backgroundColor: $pimRestaurantBlack,
    height: "30vh",
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
  },
  input: {
    backgroundColor: 'white',
    width: '80%',
    height: '32px',
    padding: '8px',
    borderRadius: 8,
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

    text : {
      color: 'white',
    }
  }
});
