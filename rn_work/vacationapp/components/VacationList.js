import axios from "axios";
import { useEffect, useState } from "react";
import { View,Text,StyleSheet,ScrollView} from "react-native";

const  VacationList = () => {

  const [list,setList]= useState([]);

  useEffect(()=>{
    axios.get('http://192.168.0.80:8080/vacationapi/select')
    .then(result=>{
      console.log(result.data);
      setList(result.data);
    }).catch(err=>{
      console.log(err);
    })
    console.log('화면 불러올때 한번...');
  },[]);

  return (
    <ScrollView>
      <View style={styles.inner}>
        <Text style={styles.header}>휴가계목록</Text>
        {list.map((vacation) => {
          return (
            <View>
              <Text>휴가기간 {vacation.startdate}~{vacation.enddate}</Text>
              <View style={{flexDirection:"row"}}>
                <Text>성명 {vacation.name}</Text>
                <Text>과정명 {vacation.classname}</Text>
              </View>
              <Text>제출 사유 {vacation.reason}</Text>
            </View>
          );
        })}
      </View>
    </ScrollView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  inner: {
    padding: 24,
    flex: 1,
    justifyContent: "space-around",
  },
  header: {
    fontSize: 36,
    marginBottom: 10,
  },
  subheader: {
    fontSize: 22,
    margin: 5,
  },
  textInput: {
    fontSize: 22,
    height: 40,
    width:200,
    borderColor: "#000000",
    borderBottomWidth: 1,
    marginBottom: 10,
    marginLeft:5
  },
  btnContainer: {
    backgroundColor: "white",
    marginTop: 12,
  },
  date: {
    fontSize: 20,
    fontWeight: "bold",
  },
});
 
export default VacationList;
