import { useState } from 'react';
import './App.css';
import Child1 from './components/Child1';
import {Button} from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useCallback } from 'react';
import MyUseMemo from './components/MyUseMemo';

function App() {
  console.log('App 랜더링');
  const [cnt,setCnt] = useState(0);
  const [name,setName] = useState('홍길동');

  const onClickBtn = ()=>{
    setCnt(cnt+1);
  }
  const onClickBtn1 = ()=>{
    setName('김길동');
  }
  const cntReset = useCallback(()=>{
    setCnt(0);
  },[]);
  return (
    <div className="App">
      <MyUseMemo/>
      <h1>App cnt = {cnt}</h1>
      <h1>App name = {name}</h1>
      <Button onClick={onClickBtn}>버튼1</Button>
      <Button onClick={onClickBtn1}>버튼2</Button>
      <Child1 cnt={cnt} name={name} cntReset={cntReset}></Child1>
    </div>
  );
}

export default App;
