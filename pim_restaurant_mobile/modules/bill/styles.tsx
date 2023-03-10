import { StyleSheet } from "react-native";
import {
  $pimRestaurantBlack,
  $pimRestaurantBlackTints,
  $pimRestaurantGreen,
  $pimRestaurantRed,
  $pimRestaurantSilver,
  $pimRestaurantSilverTints,
} from "../../constants/colors";
import { $gridSize } from "../../constants/sizing";

export const styles = StyleSheet.create({
  container: {
    display: "flex",
    backgroundColor: $pimRestaurantBlack,
    minHeight: "100%",
    padding: $gridSize * 2,
  },
  bill: {
    display: "flex",
    flexDirection: "column",
    minHeight: "100%",
    backgroundColor: $pimRestaurantSilver,
  },
  billHeader: {
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
  },
  billHeaderTitle: {
    color: $pimRestaurantBlack,
    fontSize: 24,
    fontWeight: "bold",
    padding: $gridSize * 4,
  },
  billProducts: {},
  billProduct: {
    flex: 1,
    alignSelf: "stretch",
    flexDirection: "row",
    alignItems: "center",
    padding: $gridSize,
    maxWidth: "80%",
  },
  billProductText: {
    color: $pimRestaurantBlack,
    flex: 1,
    alignSelf: "stretch",
  },
  quantityStepper: {
    flex: 1,
    alignSelf: "stretch",
  },
  quantityInput: {
    backgroundColor: $pimRestaurantSilverTints[500],
    color: $pimRestaurantBlack,
    borderRadius: $gridSize,
  },
  stepButtons: {
    display: "flex",
    flexDirection: "row",
    width: "100%",
    justifyContent: "space-between",
  },
  stepButton: {
    backgroundColor: $pimRestaurantBlackTints[500],
    borderRadius: $gridSize,
    width: "2.5em",
    height: "2em",
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
  },
  stepButtonText: {
    color: $pimRestaurantSilverTints[500],
    fontSize: 24,
    fontWeight: "bold",
  },
  totalSection: {
    display: "flex",
    flexDirection: "row",
    justifyContent: "flex-end",
    alignItems: "center",
    padding: $gridSize * 2,
  },
  totalSectionText: {
    color: $pimRestaurantBlack,
    fontSize: 18,
    fontWeight: "bold",
    letterSpacing: 1.2,
  },
  billActions: {
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
  },
  sendBillButton: {
    backgroundColor: $pimRestaurantGreen,
    padding: $gridSize * 2,
    borderRadius: $gridSize,
    margin: $gridSize * 2,
    width: "90%",
  },
  sendBillButtonText: {
    color: $pimRestaurantSilverTints[500],
    textAlign: "center",
    fontSize: 18,
    fontWeight: "bold",
    letterSpacing: 1.2,
  },
  homeButton: {
    backgroundColor: $pimRestaurantSilverTints[500],
    border: `2px solid ${$pimRestaurantBlack}`,
    padding: $gridSize * 2,
    borderRadius: $gridSize,
    margin: $gridSize * 2,
    marginTop: $gridSize,
    width: "90%",
  },
  homeButtonText: {
    color: $pimRestaurantBlack,
    textAlign: "center",
    fontSize: 18,
    fontWeight: "bold",
    letterSpacing: 1.2,
  },
});
