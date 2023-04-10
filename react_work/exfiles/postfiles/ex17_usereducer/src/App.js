import { useReducer, useState } from 'react';
import './App.css';
import { Header, LeftDiv, MyButton, MyInput, RightDiv } from './styedcomponents/MyStylesCom';

const reducer = (state, action )=>{ 
  console.log(`state = ${state}`);
  console.log(`action = ${action.type}`);
  switch (action.type) {
    case 'increment':
      return state+parseInt(action.value);
    case 'decrement':
      return state-parseInt(action.value);
    default:
      return 10;
  }
}
function App() {
  const [inputValue,setInputValue] = useState("");
  const [num,dispath] = useReducer( reducer, 0 );
  const inputfn = (e) =>{ setInputValue(e.target.value) }
  return (
    <div className="App">
      <Header>
        <LeftDiv>왼쪽</LeftDiv>        
        헤더
        <RightDiv>오른쪽</RightDiv>   
      </Header>
      <h2>num = {num}</h2>
      <MyInput type='number' onChange={inputfn} value={inputValue}></MyInput>
      <MyButton onClick={ ()=>{dispath( {type:"increment",value:inputValue});} }>증가버튼</MyButton>
      <MyButton onClick={ ()=>{dispath( {type:"decrement",value:inputValue});} }>감소버튼</MyButton>
    </div>
  );
}

export default App;
