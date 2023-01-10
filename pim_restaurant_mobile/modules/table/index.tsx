import { useEffect } from "react";
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
import { Section } from "./models/section/Section.model";
import { loadProducts } from "./reducer/table.actions";
import { styles } from "./styles";
import { FontAwesome } from "@expo/vector-icons";
import {
  $pimRestaurantSilver,
  $pimRestaurantSilverTints,
} from "../../constants/Colors";
import { $gridSize, $iconSize } from "../../constants/sizing";
import { Flex } from "@react-native-material/core";
import { Category } from "./models/category/Category.model";
import { Product } from "./models/product/Product.model";

export default function TableScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const { table } = route.params.table;
  const authState = useSelector((state: RootState) => state.auth);
  const tableState = useSelector((state: RootState) => state.table);
  const dispatch = useDispatch();

  useEffect(() => {
    navigation.setOptions({ title: `Masa nr. ${route.params.table.id}` });
    loadProducts(dispatch, authState.restaurant);
  }, []);

  return !!tableState.sections &&
    !!tableState.categories &&
    !!tableState.products ? (
    <View style={styles.container}>
      <View style={styles.sections}>
        <Pressable style={styles.section}>
          <FontAwesome
            name="list-ul"
            size={$iconSize}
            color={$pimRestaurantSilver}
            style={{ marginBottom: $gridSize }}
          />
          <Text style={styles.sectionText}>Toate</Text>
        </Pressable>
        <Pressable style={styles.section}>
          <FontAwesome
            name="cutlery"
            size={$iconSize}
            color={$pimRestaurantSilver}
            style={{ marginBottom: $gridSize }}
          />
          <Text style={styles.sectionText}>Bucătărie</Text>
        </Pressable>
        <Pressable style={styles.section}>
          <FontAwesome
            name="glass"
            size={$iconSize}
            color={$pimRestaurantSilver}
            style={{ marginBottom: $gridSize }}
          />
          <Text style={styles.sectionText}>Bar</Text>
        </Pressable>
      </View>
      <View
        style={{
          display: "flex",
          flexDirection: "row",
        }}
      >
        <ScrollView style={styles.categories}>
          {tableState.categories.map((category: Category, key: number) => (
            <Pressable key={key} style={styles.category}>
              <Text style={styles.categoryText}>{category.name}</Text>
            </Pressable>
          ))}
        </ScrollView>
        <FlatList
          data={tableState.products}
          numColumns={2}
          renderItem={({ item }) => (
            <TouchableOpacity style={styles.product} onPress={() => {}}>
              <Text style={styles.productText}>{item.name}</Text>
              <Text style={styles.productText}>Preț: {item.price} lei</Text>
            </TouchableOpacity>
          )}
          keyExtractor={(item) => item.id}
          style={styles.products}
          columnWrapperStyle={styles.productRow}
        />
      </View>
      <View style={styles.receiptPane}>
        <Text style={styles.receiptPaneText}>
          Vezi nota de plată{" "}
          <FontAwesome
            name="check-square-o"
            size={24}
            style={{ color: $pimRestaurantSilverTints[500], marginLeft: $gridSize }}
          />
        </Text>
      </View>
    </View>
  ) : (
    <View>
      <Text>Loading...</Text>
    </View>
  );
}
