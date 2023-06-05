import { Button, Image, Text, View, StyleSheet } from "react-native";
import Constants from "expo-constants";
import { useState } from "react";

const Main = ({navigation}) => {
  console.log("test");
  const [a, setA] = useState(0);
  const doA = () => {
    console.log("test");
    setA(a + 1);
    navigation.replace('vaform');
  };
  const [titleText, setTitleText] = useState(0);
  const onPressTitle = () => {
    setTitleText(titleText+1);
    
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
        <Text style={styles.titleText} onPress={onPressTitle}>
          {titleText}
          {"\n"}
          {"\n"}
        </Text>
      </View>
      <View
        style={{
          height: 100,
          padding: 20,
        }}
      >
        <View style={{ margin: 10 }}>
          <Button
            style={styles.button}
            onPress={doA}
            title="휴가계작성"
          ></Button>
        </View>
        <View style={{ margin: 10 }}>
          <Button
            style={styles.button}
            onPress={doA}
            title="휴가계목록"
          ></Button>
        </View>
        <View style={{ margin: 10 }}>
          <Button style={styles.button} onPress={doA} title="회원가입"></Button>
        </View>
        <View style={{ margin: 10 }}>
          <Button style={styles.button} onPress={doA} title="회원목록"></Button>
        </View>
      </View>
    </>
  );
};

export default Main;
const styles = StyleSheet.create({
  container: {
    padding: 10,
    paddingTop: Constants.statusBarHeight,
    height: 100,
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
    marginVertical: 8,
    marginHorizontal: 16,
    borderBottomColor: "#737373",
    borderBottomWidth: StyleSheet.hairlineWidth,
  },
});