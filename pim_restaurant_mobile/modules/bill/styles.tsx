import { StyleSheet } from "react-native";
import { $pimRestaurantBlack, $pimRestaurantBlackTints, $pimRestaurantGreen, $pimRestaurantRed, $pimRestaurantSilver, $pimRestaurantSilverTints } from "../../constants/Colors";
import { $gridSize } from "../../constants/sizing";

export const styles = StyleSheet.create({
  container: {
    display: "flex",
    backgroundColor: $pimRestaurantBlack,
    minHeight: '100%',
    padding: $gridSize * 2,
  },
  bill: {
    display: 'flex',
    flexDirection: 'column',
    minHeight: '100%',
    backgroundColor: $pimRestaurantSilver,
  },
  billHeader: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
  },
  billHeaderTitle: {
    color: $pimRestaurantBlack,
    fontSize: 24,
    fontWeight: 'bold',
    padding: $gridSize * 4,
  },
  billProducts: {},
  billProduct: {
    flex: 1,
    alignSelf: 'stretch',
    flexDirection: 'row',
    alignItems: 'center',
    padding: $gridSize,
  },
  billProductText: {
    color: $pimRestaurantBlack,
    flex: 1,
    alignSelf: 'stretch',
  },
  totalSection: {
    display: 'flex',
    flexDirection: 'row',
    justifyContent: 'flex-end',
    alignItems: 'center',
    padding: $gridSize * 2,
  },
  totalSectionText: {
    color: $pimRestaurantBlack,
    fontSize: 18,
    fontWeight: 'bold',
    letterSpacing: 1.2,
  },
  billActions: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
  },
  sendBillButton: {
    backgroundColor: $pimRestaurantGreen,
    padding: $gridSize * 2,
    borderRadius: $gridSize,
    margin: $gridSize * 2,
    width: '90%'
  },
  sendBillButtonText: {
    color: $pimRestaurantSilverTints[500],
    textAlign: 'center',
    fontSize: 18,
    fontWeight: 'bold',
    letterSpacing: 1.2,
  },
});
