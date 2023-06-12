import { Button, View, StyleSheet } from "react-native";

const Main = ({navigation}) => {

  return (
    <View style={styles.container}>
      <Button
        style={styles.mybtn}
        onPress={() => {
          navigation.navigate("VacationWrite");
        }}
        title="휴가계작성"
      ></Button>
      <Button
        style={styles.mybtn}
        onPress={() => {
          navigation.navigate("VacationList");
        }}
        title="휴가계목록"
      ></Button>
    </View>
  );
}
 
export default Main;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    justifyContent: 'center',
    alignItems:"center",
  },
  mybtn:{
    // width:100,
    // margin:5
  }
});