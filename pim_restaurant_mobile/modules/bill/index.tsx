import { useEffect, useState } from "react";
import { Text, View, TouchableOpacity, Button } from "react-native";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import { styles } from "./styles";
import { BillState } from "./reducer/bill.reducer";
import { TextInput } from "@react-native-material/core";
import { BillItem } from "./models/bill/BillItem.model";
import { PUT_BILL, updateTableBill } from "./reducer/bill.actions";

export default function BillScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const [table, setTable] = useState(route.params.table);
  const state = useSelector((state: RootState) => state);
  const billState: BillState = useSelector((state: RootState) => state.bills);
  const dispatch = useDispatch();

  useEffect(() => {
    navigation.setOptions({ title: "Nota" });
  }, []);

  const handleQuantityChange = (item: BillItem, input: any) => {
    if (input < 0) {
      return;
    }
    const newBill = billState.bill.map((billItem) => {
      if (billItem.product.id === item.product.id) {
        return {
          ...billItem,
          quantity: parseFloat(parseFloat(input).toFixed(2)),
        };
      }
      return billItem;
    });
    console.log(newBill);
    dispatch({ type: PUT_BILL, bill: newBill });
  };

  return dataFinishedLoading(billState) ? (
    <View style={styles.container}>
      <View style={styles.bill}>
        <View style={styles.billHeader}>
          <Text style={styles.billHeaderTitle}>
            Nota de plată masa nr. {table.id}
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
          {billState.bill.map((item, index) => (
            <View key={index}>
              <View
                style={[
                  styles.billProduct,
                  { opacity: item.orderSent ? 0.5 : 1 },
                ]}
              >
                <Text style={styles.billProductText}>
                  {item.product.denumire}
                </Text>
                <Text style={styles.billProductText}>{item.product.pret}</Text>
                <View style={styles.quantityStepper}>
                  <TextInput
                    style={styles.quantityInput}
                    value={parseFloat(item.quantity.toString()).toFixed(2)}
                    editable={false}
                    keyboardType="number-pad"
                  />
                  <View style={styles.stepButtons}>
                    <TouchableOpacity
                      style={styles.stepButton}
                      onPress={() => {
                        handleQuantityChange(
                          item,
                          item.quantity - item.predefinedQuantity
                        );
                      }}
                    >
                      <Text style={styles.stepButtonText}>-</Text>
                    </TouchableOpacity>
                    <TouchableOpacity
                      style={styles.stepButton}
                      onPress={() => {
                        handleQuantityChange(
                          item,
                          item.quantity + item.predefinedQuantity
                        );
                      }}
                    >
                      <Text style={styles.stepButtonText}>+</Text>
                    </TouchableOpacity>
                  </View>
                </View>
              </View>
              <View
                style={{ borderBottomColor: "black", borderBottomWidth: 1 }}
              />
            </View>
          ))}
          <View style={styles.totalSection}>
            <Text style={styles.totalSectionText}>
              Total:{" "}
              {billState.bill
                .reduce(
                  (totalPrice, currentItem) =>
                    totalPrice +
                    currentItem.product.pret * currentItem.quantity,
                  0
                )
                .toFixed(2)}{" "}
              lei
            </Text>
          </View>
        </View>
        <View style={styles.billActions}>
          <TouchableOpacity
            style={styles.sendBillButton}
            onPress={() => {
              updateTableBill(dispatch, table, billState.bill);
            }}
          >
            <Text style={styles.sendBillButtonText}>SALVEAZĂ NOTA</Text>
          </TouchableOpacity>
          <TouchableOpacity
            style={styles.homeButton}
            onPress={() => {
              navigation.navigate("Rooms");
            }}
          >
            <Text style={styles.homeButtonText}>ACASĂ</Text>
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

const dataFinishedLoading = (billState: BillState) => {
  return !billState.isLoading;
};
