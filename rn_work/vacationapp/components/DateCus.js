import React, { useState } from "react";
import { Button } from "react-native";
import DateTimePickerModal from "react-native-modal-datetime-picker";

const DateCus = ({setStartdate}) => {
  const [isDatePickerVisible, setDatePickerVisibility] = useState(false);

  const showDatePicker = () => {
    setDatePickerVisibility(true);
  };

  const hideDatePicker = () => {
    setDatePickerVisibility(false);
  };

  const handleConfirm = (date) => {
    console.warn("A date has been picked: ", date);
    try{
      setStartdate(date.toLocaleString().substring(0,9));
    }catch(e){
      console.log(e);
    }
    hideDatePicker();
  };

  return (
    <>
      <Button title="startdate" onPress={showDatePicker} />
      <DateTimePickerModal
        isVisible={isDatePickerVisible}
        mode="date"
        onConfirm={handleConfirm}
        onCancel={hideDatePicker}
      />
    </>
  );
};

export default DateCus;