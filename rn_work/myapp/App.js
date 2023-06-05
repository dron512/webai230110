import Main from "./components/main";
import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import VaForm from "./components/vaform";

const Stack = createNativeStackNavigator();

export default function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen
          name="main"
          component={Main}
          options={{ title: "경북산업직업전문학교" }}
        ></Stack.Screen>
        <Stack.Screen
          name="vaform"
          component={VaForm}
          options={{ title: "경북산업직업전문학교" }}
        ></Stack.Screen>
      </Stack.Navigator>
    </NavigationContainer>
  );
}
