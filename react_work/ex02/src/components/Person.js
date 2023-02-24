// imr import React from 'react';
// sfc 화살표 함수 컴퍼넌트 만들기

import React, { useState } from "react";

const Person = (props) => {
  const name = props.name;
  const [age,setAge] = useState(props.age);

  const addAge = () => {
    setAge(age + 1);
  };
  const subAge = () => {
    setAge(age - 1);
  };
  return (
    <div>
      <h1>PERSON</h1>
      <p>
        안녕하세요 이름은{name}이이고 나이는 {age}살 입니다.
      </p>
      <button onClick={addAge}>나이 올리기</button>
      <button onClick={subAge}>나이 줄이기</button>
    </div>
  );
};

export default Person;
