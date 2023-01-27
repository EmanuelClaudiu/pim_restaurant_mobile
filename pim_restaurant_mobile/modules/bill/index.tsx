import { useEffect, useState } from "react";
import {
  Pressable,
  Text,
  View,
  FlatList,
  ScrollView,
  TouchableOpacity,
} from "react-native";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { styles } from "./styles";
import { FontAwesome } from "@expo/vector-icons";
import {
  $pimRestaurantSilver,
  $pimRestaurantSilverTints,
} from "../../constants/Colors";
import { $gridSize, $iconSize } from "../../constants/sizing";
import { Flex } from "@react-native-material/core";
import { loadBills } from "./reducer/bill.actions";

export default function BillScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const [bill, setBill] = useState(route.params.bill);
  const billsState = useSelector((state: RootState) => state.bills);
  const dispatch = useDispatch();

  useEffect(() => {
    console.log(bill);
    navigation.setOptions({ title: "Nota" });
  }, []);

  return !!billsState.bills ? (
    <View style={styles.container}>
      <View style={styles.bill}>
        <View style={styles.billHeader}>
          <Text style={styles.billHeaderTitle}>
            Nota de plată masa nr. {bill.idTable}
          </Text>
        </View>
        <View style={styles.billProducts}>
          <View style={styles.billProduct}>
            <Text style={[styles.billProductText, { fontWeight: "bold" }]}>
              Produs
            </Text>
            <Text style={[styles.billProductText, { fontWeight: "bold" }]}>
              Preț
            </Text>
            <Text style={[styles.billProductText, { fontWeight: "bold" }]}>
              Cantitate
            </Text>
          </View>
          <View style={{ borderBottomColor: "black", borderBottomWidth: 1 }} />
          {bill.items.map((item, index) => (
            <View key={index}>
              <View style={styles.billProduct}>
                <Text style={styles.billProductText}>{item.product.name}</Text>
                <Text style={styles.billProductText}>{item.product.price}</Text>
                <Text style={styles.billProductText}>{item.quantity}</Text>
              </View>
              <View
                style={{ borderBottomColor: "black", borderBottomWidth: 1 }}
              />
            </View>
          ))}
          <View style={styles.totalSection}>
            <Text style={styles.totalSectionText}>
              Total:{" "}
              {bill.items.reduce(
                (totalPrice, currentItem) =>
                  totalPrice + currentItem.product.price * currentItem.quantity,
                0
              )}{" "}
              lei
            </Text>
          </View>
        </View>
        <View style={styles.billActions}>
          <TouchableOpacity style={styles.sendBillButton}>
            <Text style={styles.sendBillButtonText}>TRIMITE NOTA</Text>
          </TouchableOpacity>
        </View>
      </View>
    </View>
  ) : (
    <View>
      <Text>Loading...</Text>
    </View>
  );
}
