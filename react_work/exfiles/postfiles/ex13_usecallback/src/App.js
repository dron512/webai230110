import './App.css';

import React, { useState,memo, useCallback, useMemo } from 'react';

const Component = memo((props) => {
  console.log("Component 랜더링");
  const [a, setA] = useState('aaa');
  const test = props.fn;
  return (
    <>
      <h2>{a}</h2>
      <button onClick={() => {setA(a==='aaa'?'bbb':'aaa');}}>버튼</button>
      <button onClick={test}>함수호출</button>
    </>
  );
});
function App() {
  console.log("App 랜더링");
  // const fns = () => {  console.log('함수 호출됨'); }
  const fns = useCallback(() => {
    console.log('함수 호출됨');
  },[]);
  // const aa = {aa:10};
  const aa = useMemo(()=>{ return {aa:10} },[]);
  const [name,setName] = useState('홍길동');
  return (
    <div className="App">
      <h1>App</h1>
      <h2>{name}</h2>
      <button onClick={()=>{setName( name==='홍길동'?'김길동':'홍길동'); }}>버튼</button>
      <Component fn={fns} a={aa}/>
    </div>
  );
}

export default App;
