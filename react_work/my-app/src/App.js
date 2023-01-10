import React from 'react';
import './App.css';
import BooleanComponent from './01/BooleanComponent';
import Ex01 from './01/Ex01';

/*
  내장 함수 String() 과 Object.entries()를 사용하여 객체를 문자열로 변환하여 출력합니다.
  객체 프로퍼티의 자료형은 PropTypes의 shape을 사용하여 정의합니다.
*/

function App() {
  return (
    <div className="App">
      <div>
        <h1 className='title'>Test안녕하세요</h1>
        <BooleanComponent name="홍길동" boolValue={true} numValue={3.0} objValue={{ test:"test"}}/>
        <Ex01 test></Ex01>
        <Ex01></Ex01>
      </div>
    </div>
  );
}

export default App;
