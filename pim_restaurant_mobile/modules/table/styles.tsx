import { StyleSheet } from "react-native";
import { $pimRestaurantBlack, $pimRestaurantBlackTints, $pimRestaurantGreen, $pimRestaurantRed, $pimRestaurantSilver, $pimRestaurantSilverTints } from "../../constants/Colors";
import { $gridSize } from "../../constants/sizing";

export const styles = StyleSheet.create({
  container: {
    display: "flex",
    height: '100%',
  },
  sections: {
    flexDirection: "row",
    paddingHorizontal: $gridSize * 4,
    paddingVertical: $gridSize * 2,
    height: '10%',
    backgroundColor: $pimRestaurantBlack,
    columnGap: $gridSize * 4,
    alignItems: 'center'
  },
  section: {
    display: 'flex',
    alignItems: 'center',
  },
  sectionText: {
    color: $pimRestaurantSilver,
    fontSize: 16,
    letterSpacing: 1.25,
  },
  categories: {
    width: '30vw',
    maxWidth: '30vw',
    height: '75vh',
    backgroundColor: $pimRestaurantBlackTints[200],
  },
  category: {
    height: '6vh',
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
    borderTopWidth: 0.5,
    borderTopColor: $pimRestaurantSilver,
  },
  categoryText: {
    color: $pimRestaurantSilverTints[200],
    fontSize: 12,
    letterSpacing: 1.2,
    textAlign: 'center',
  },
  products: {
    height: '75vh',
    maxWidth: '70vw',
  },
  productRow: {
    display: 'flex',
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-around',
    height: '11.1vh',
  },
  product: {
    backgroundColor: $pimRestaurantBlackTints[500],
    width: '50%',
    height: '100%',
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'space-around',
    borderWidth: 0.5,
    borderColor: $pimRestaurantBlack,
  },
  productText: {
    display: 'flex',
    flexDirection: 'row',
    color: $pimRestaurantSilverTints[300],
    textAlign: 'center',
    letterSpacing: 1.25,
  },
  quantityLabel: {
    backgroundColor: $pimRestaurantRed,
    width: '1.5em',
    height: '1.5em',
    borderRadius: 50,
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
  },
  quantityLabelText: {
    color: $pimRestaurantSilverTints[500],
    fontSize: 12
  },
  receiptPane: {
    backgroundColor: $pimRestaurantGreen,
    height: '8vh',
    display: 'flex',
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'flex-end',
    paddingRight: $gridSize * 4,
  },
  receiptPaneText: {
    color: $pimRestaurantSilverTints[500],
    fontSize: 24,
    letterSpacing: 1.25,
  }
});
