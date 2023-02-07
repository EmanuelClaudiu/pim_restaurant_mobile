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
import { addProductOnBill, loadGroups, loadLocations, loadProducts } from "./reducer/table.actions";
import { styles } from "./styles";
import { FontAwesome } from "@expo/vector-icons";
import {
  $pimRestaurantBlack,
  $pimRestaurantSilver,
  $pimRestaurantSilverTints,
} from "../../constants/Colors";
import { $gridSize, $iconSize } from "../../constants/sizing";
import { Category } from "./models/category/Category.model";
import { BillState } from "../bill/reducer/bill.reducer";
import { TableState } from "./reducer/table.reducer";
import { Group } from "./models/group/Group.model";
import { Locatie } from "../locations/models/location/Locatie.model";
import { Location } from "./models/location/Location.model";
import { loadBillByTable } from "../bill/reducer/bill.actions";

export interface ProductsFilters {
  location: Location;
  group: Group;
}

export default function TableScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const [isLoading, setIsLoading] = useState(true);
  const [table, setTable] = useState(route.params.table);
  const [room, setRoom] = useState(route.params.room);
  const [productsFilters, setProductsFilters] = useState<ProductsFilters>({
    location: null,
    group: null,
  });
  const tableState: TableState = useSelector((state: RootState) => state.table);
  const billState: BillState = useSelector((state: RootState) => state.bills);
  const dispatch = useDispatch();

  useEffect(() => {
    navigation.setOptions({ title: `${table.name} ${room.denumireSala}` });
    loadBillByTable(dispatch, table);
    loadProducts(dispatch);
    loadLocations(dispatch);
    loadGroups(dispatch);
    setIsLoading(false);
  }, []);

  const setLocationFilter = (location: Location | null) => {
    const newFilters = {
      ...productsFilters,
      location,
    };
    loadProducts(dispatch, newFilters);
    setProductsFilters(newFilters);
  };

  const setGroupFilter = (group: Group | null) => {
    const newFilters = {
      ...productsFilters,
      group,
    };
    loadProducts(dispatch, newFilters);
    setProductsFilters(newFilters);
  };

  const dataFinishedLoading = (tableState: TableState, billState: BillState) => {
    return (
      !isLoading &&
      !tableState.isLoading &&
      !billState.isLoading &&
      !!tableState.products &&
      !!tableState.groups &&
      !!tableState.locations
    );
  };

  return dataFinishedLoading(tableState, billState) ? (
    <View style={styles.container}>
      <View style={styles.sections}>
        <TouchableOpacity
          style={styles.section}
          onPress={() => {
            setLocationFilter(null);
          }}
        >
          <FontAwesome
            name="list-ul"
            size={$iconSize}
            color={$pimRestaurantSilver}
            style={{ marginBottom: $gridSize }}
          />
          <Text style={styles.sectionText}>Toate</Text>
        </TouchableOpacity>
        {tableState.locations.map((location: Location, index: number) => (
          <TouchableOpacity
            style={styles.section}
            key={index}
            onPress={() => {
              setLocationFilter(location);
            }}
          >
            <FontAwesome
              name={
                location.denumire.toLowerCase().includes("buc")
                  ? "cutlery"
                  : location.denumire.toLowerCase().includes("bar")
                  ? "glass"
                  : "star"
              }
              size={$iconSize}
              color={$pimRestaurantSilver}
              style={{ marginBottom: $gridSize }}
            />
            <Text style={styles.sectionText}>{location.denumire}</Text>
          </TouchableOpacity>
        ))}
      </View>
      <View
        style={{
          display: "flex",
          flexDirection: "row",
        }}
      >
        <ScrollView style={styles.categories}>
          {tableState.groups.map((group: Group, key: number) => (
            <TouchableOpacity
              key={key}
              style={styles.category}
              onPress={() => {
                setGroupFilter(group);
              }}
            >
              <Text style={styles.categoryText}>{group.denumire}</Text>
            </TouchableOpacity>
          ))}
        </ScrollView>
        <FlatList
          data={tableState.products}
          numColumns={2}
          renderItem={({ item }) => (
            <TouchableOpacity
              style={styles.product}
              onPress={() => {
                addProductOnBill(dispatch, item, table);
                loadBillByTable(dispatch, table);
              }}
            >
              <Text style={styles.productText}>{item.denumire}</Text>
              <Text style={styles.productText}>
                Preț: {item.pret} lei{" "}
                {!!billState.bill.find(
                  (billItem) => billItem.product.id === item.id
                ) ? (
                  <View style={styles.quantityLabel}>
                    <Text style={styles.quantityLabelText}>
                      {
                        billState.bill.find(
                          (billItem) => billItem.product.id === item.id
                        ).quantity
                      }
                    </Text>
                  </View>
                ) : (
                  <></>
                )}
              </Text>
            </TouchableOpacity>
          )}
          style={styles.products}
          columnWrapperStyle={styles.productRow}
        />
      </View>
      <Pressable
        style={styles.receiptPane}
        onPress={() => {
          navigation.navigate("Bill", { table });
        }}
      >
        <Text style={styles.receiptPaneText}>
          Vezi nota de plată{" "}
          <FontAwesome
            name="check-square-o"
            size={24}
            style={{
              color: $pimRestaurantSilverTints[500],
              marginLeft: $gridSize,
            }}
          />
        </Text>
      </Pressable>
    </View>
  ) : (
    <View style={styles.container}>
      <View style={styles.sections}></View>
      <View
        style={{
          display: "flex",
          flexDirection: "row",
        }}
      >
        <View style={styles.categories}></View>
        <View style={styles.products}>
          <Text>Loading...</Text>
        </View>
      </View>
      <View style={styles.receiptPane}></View>
    </View>
  );
}
