import { useEffect } from "react";
import { Text, View } from "react-native";
import { useSelector } from "react-redux";
import { RootState } from "../../Store";

export default function TableScreen({
  route,
  navigation,
}: {
  route: any;
  navigation: any;
}) {
  const { table } = route.params;
  const authState = useSelector((state: RootState) => state.auth);
  // const tableState = useSelector((state: RootState) => state.tables);
  // const dispatch = useDispatch();

  useEffect(() => {
    
  }, []);

  return <View>
    <Text></Text>
  </View>
}
