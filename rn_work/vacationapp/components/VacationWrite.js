import React, { useState } from "react";
import {
  View,
  KeyboardAvoidingView,
  TextInput,
  StyleSheet,
  Text,
  Platform,
  TouchableWithoutFeedback,
  Button,
  Keyboard,
  Alert,
  ScrollView,
} from "react-native";
import axios from "axios";
import DateCus from "./DateCus";

const VacationWrite = ({navigation}) => {
  const [birthdate, setBirthdate] = useState(new Date().toLocaleDateString());
  const [enddate, setEnddate] = useState(new Date().toLocaleDateString());
  const [fordate, setFordate] = useState("");
  const [month, setMonth] = useState("");
  const [reasondate, setReasondate] = useState(new Date().toLocaleDateString());
  const [startdate, setStartdate] = useState(new Date().toLocaleDateString());
  const [address, setAddress] = useState("");
  const [classname, setClassname] = useState("");
  const [name, setName] = useState("");
  const [phonenumber, setPhonenumber] = useState("");
  const [reason, setReason] = useState("");

  const doSubmit = () => {
    const data = {
      birthdate,
      enddate,
      fordate,
      month,
      reasondate,
      startdate,
      address,
      classname,
      name,
      phonenumber,
      reason,
    };

    axios
      .post("http://192.168.0.80:8080/vacationapi/insert", data, {
        headers: {
          "Content-Type": "application/json",
        },
      })
      .then((success) => {
        Alert.alert("휴가계작성", "작성하였습니다.", [
          {
            text: "확인",
            onPress: () =>
              navigation.goBack(),
          },
        ]);
      })
      .catch((err) => {
        console.log(err);
      });
  };

  return (
    <ScrollView>
      <View style={styles.inner}>
        <Text style={styles.header}>휴가계작성</Text>
        <DateCus setStartdate={setStartdate}/>
        <Text style={styles.header}>
          ({parseInt(new Date().getMonth()) + 1})월 휴가계
        </Text>
        <Text style={styles.subheader}>기간</Text>
        <View style={{ flexDirection: "row", paddingLeft: 20 }}>
          <TextInput
            placeholder="startdate"
            style={styles.date}
            defaultValue={startdate}
            onChangeText={(date) => {
              setStartdate(date);
            }}
          />
          <Text style={styles.subheader}>~</Text>
          <TextInput
            placeholder="enddate"
            style={styles.date}
            defaultValue={enddate}
            onChangeText={(date) => {
              setEnddate(date);
            }}
          />
          <Text style={styles.subheader}>( 1 )일간</Text>
        </View>
        <View style={{ flexDirection: "row" }}>
          <Text style={styles.subheader}>훈련과정</Text>
          <TextInput
            placeholder="훈련과정"
            style={styles.textInput}
            defaultValue={classname}
            onChangeText={(input) => {
              setClassname(input);
            }}
          />
        </View>
        <View style={{ flexDirection: "row" }}>
          <Text style={styles.subheader}>생년월일</Text>
          <TextInput
            placeholder="생년월일"
            style={styles.date}
            defaultValue={birthdate}
            onChangeText={(date) => {
              setBirthdate(date);
            }}
          />
        </View>
        <View style={{ flexDirection: "row" }}>
          <Text style={styles.subheader}>성명</Text>
          <TextInput
            placeholder="성명"
            style={styles.textInput}
            defaultValue={name}
            onChangeText={(input) => {
              setName(input);
            }}
          />
        </View>
        <View style={{ flexDirection: "row" }}>
          <Text style={styles.subheader}>주소</Text>
          <TextInput
            placeholder="주소"
            style={styles.textInput}
            defaultValue={address}
            onChangeText={(input) => {
              setAddress(input);
            }}
          />
        </View>
        <View style={{ flexDirection: "row" }}>
          <Text style={styles.subheader}>연락처</Text>
          <TextInput
            placeholder="연락처"
            style={styles.textInput}
            defaultValue={phonenumber}
            onChangeText={(input) => {
              setPhonenumber(input);
            }}
          />
        </View>
        <View style={{ flexDirection: "row" }}>
          <Text style={styles.subheader}>작성사유</Text>
          <TextInput
            placeholder="작성사유"
            style={styles.textInput}
            defaultValue={reason}
            onChangeText={(input) => {
              setReason(input);
            }}
          />
        </View>
        <Text style={styles.subheader}>
          작성일자 {new Date().getFullYear()} 년 {new Date().getMonth() + 1} 월{" "}
          {new Date().getDate()} 일
        </Text>
        <View style={styles.btnContainer}>
          <Button title="작성완료" onPress={doSubmit} />
        </View>
      </View>
    </ScrollView>
  );
};

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

export default VacationWrite;
