import { Button, Image, StyleSheet, Text, View } from "react-native";
import Constants from "expo-constants";
import { useState } from "react";

const VaForm = ({ navigation }) => {
  const [title, setTitle] = useState("Menu1");
  const doA = () => {
    navigation.replace("main");
  };
  return (
    <>
      <View
        style={{
          marginTop: 20,
          flexDirection: "column",
          justifyContent: "center",
          alignItems: "center",
        }}
      >
        <Image style={styles.tinyLogo} source={require("../assets/img.jpg")} />
        <Text style={styles.titleText}>
          {title}
          {"\n"}
          {"\n"}
        </Text>
        <Text>Menu1</Text>
        <Button
          style={styles.button}
          onPress={() => {
            return title === "content" ? setTitle("menu") : setTitle("content");
          }}
          title="MENU1바꿈"
        ></Button>
      </View>
      <View style={styles.containerBottom}>
        <Button style={styles.button} onPress={doA} title="휴가계목록"></Button>
        <Button style={styles.button} onPress={doA} title="회원가입"></Button>
        <Button style={styles.button} onPress={doA} title="회원목록"></Button>
      </View>
    </>
  );
};

export default VaForm;
const styles = StyleSheet.create({
  container: {
    padding: 10,
    paddingTop: Constants.statusBarHeight,
    height: 100,
  },
  containerBottom: {
    position: "absolute",
    left: 0,
    right: 0,
    bottom: 0,
    height: 100,
    flexDirection: "row",
    flex: 1,
    justifyContent: "center",
  },
  tinyLogo: {
    width: 50,
    height: 50,
  },
  logo: {
    width: 66,
    height: 58,
  },
  titleText: {
    fontSize: 20,
    fontWeight: "bold",
  },
  button: {
    padding: 30,
    marginVertical: 8,
    marginHorizontal: 16,
    borderBottomColor: "#737373",
  },
});
