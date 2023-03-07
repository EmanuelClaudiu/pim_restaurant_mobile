import { useEffect, useState } from "react";
import {
  Pressable,
  Text,
  View,
  FlatList,
  ScrollView,
  TouchableOpacity,
  Modal,
} from "react-native";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../Store";
import {
  addProductOnBill,
  loadGroups,
  loadLocations,
  loadProducts,
} from "./reducer/table.actions";
import { styles } from "./styles";
import { FontAwesome } from "@expo/vector-icons";
import {
  $pimRestaurantSilver,
  $pimRestaurantSilverTints,
} from "../../constants/colors";
import { $gridSize, $iconSize } from "../../constants/sizing";
import { BillState } from "../bill/reducer/bill.reducer";
import { TableState } from "./reducer/table.reducer";
import { Group } from "./models/group/Group.model";
import { Location } from "./models/location/Location.model";
import { loadBillByTable } from "../bill/reducer/bill.actions";
import { Product } from "./models/product/Product.model";
import { PredefinedQuantity } from "./models/product/PredefinedCategory.model";
import { AuthState } from "../login/reducer/auth.reducer";
import DeviceInfo from "react-native-device-info";
import AsyncStorage from "@react-native-community/async-storage";
import { SettingsState } from "../settings/reducer/settings.reducer";
import { Config } from "../settings/models/Config.model";

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
  const [isModalVisible, setIsModalVisible] = useState(false);
  const [modalData, setModalData] = useState(null);

  const tableState: TableState = useSelector((state: RootState) => state.table);
  const authState: AuthState = useSelector((state: RootState) => state.auth);
  const billState: BillState = useSelector((state: RootState) => state.bills);
  const settingsState: SettingsState = useSelector((state: RootState) => state.settings);
  const dispatch = useDispatch();

  const [config, setConfig] = useState(new Config(dispatch, settingsState));

  useEffect(() => {
    navigation.setOptions({ title: `${table.name} ${room.denumireSala}` });
    loadBillByTable(config, table);
    loadProducts(config);
    loadLocations(config);
    loadGroups(config);
    setIsLoading(false);
  }, []);

  const toggleModal = (product: Product = null) => {
    setModalData(product);
    setIsModalVisible(!isModalVisible);
  };

  const setLocationFilter = (location: Location | null) => {
    const newFilters = {
      ...productsFilters,
      location,
    };
    loadProducts(config, newFilters);
    setProductsFilters(newFilters);
  };

  const setGroupFilter = (group: Group | null) => {
    const newFilters = {
      ...productsFilters,
      group,
    };
    loadProducts(config, newFilters);
    setProductsFilters(newFilters);
  };

  const getOrderNumber = async (): Promise<string> => {
    const deviceName = await DeviceInfo.getDeviceName();
    const orderNumber = +JSON.parse(await AsyncStorage.getItem(`orderNumber`));
    if (billState.bill.length === 0) {
      await AsyncStorage.setItem(
        `orderNumber`,
        JSON.stringify(orderNumber + 1)
      );
      return `${deviceName}-${orderNumber + 1}`;
    } else {
      return `${deviceName}-${orderNumber}`;
    }
  };

  const dataFinishedLoading = (
    tableState: TableState,
    billState: BillState
  ) => {
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
        <Modal
          visible={isModalVisible}
          animationType="fade"
          transparent={true}
          onRequestClose={() => toggleModal()}
        >
          <View
            style={{ flex: 1, justifyContent: "center", alignItems: "center" }}
          >
            <View style={styles.modalContainer}>
              <Text style={styles.modalTitle}>Alege cantitatea</Text>
              {modalData?.cantitatiPredefinite.map(
                (predefinedQuantity: PredefinedQuantity, index) => (
                  <TouchableOpacity
                    style={styles.predefinedQuantity}
                    onPress={async () => {
                      addProductOnBill(
                        config,
                        modalData,
                        table,
                        authState.waiter,
                        await getOrderNumber(),
                        predefinedQuantity
                      );
                      toggleModal();
                    }}
                  >
                    <Text style={styles.predefinedQuantityText}>
                      {predefinedQuantity.alias}
                    </Text>
                  </TouchableOpacity>
                )
              )}
              <TouchableOpacity
                style={styles.closeButton}
                onPress={() => toggleModal()}
              >
                <Text style={styles.closeButtonText}>Închide</Text>
              </TouchableOpacity>
            </View>
          </View>
        </Modal>
        <FlatList
          data={tableState.products}
          numColumns={2}
          renderItem={({ item }) => (
            <TouchableOpacity
              style={styles.product}
              onPress={async () => {
                if (!!item.cantitatiPredefinite.length) {
                  toggleModal(item);
                } else {
                  addProductOnBill(
                    config,
                    item,
                    table,
                    authState.waiter,
                    await getOrderNumber()
                  );
                }
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
                      {item.cantitatiPredefinite?.length > 0
                        ? billState.bill
                            .filter(
                              (billItem) => billItem.product.id === item.id
                            )
                            .reduce(
                              (acc, billItem) => acc + billItem.quantity,
                              0
                            )
                            .toFixed(2)
                        : billState.bill
                            .filter(
                              (billItem) => billItem.product.id === item.id
                            )
                            .reduce(
                              (acc, billItem) => acc + billItem.quantity,
                              0
                            )}
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
