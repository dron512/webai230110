import { memo, useState } from 'react';
import './App.css';

const Child = memo((props) => {
  const name = props.name;
  console.log("자식 컴포넌트가 랜더링 되었습니다");
  return (
    <>
      <h1>Child</h1>
      <h2>{name}</h2>
    </>
  );
});

function App() {
  console.log("부모 컴포넌트가 랜더링 되었습니다");
  const [num,setNum] = useState(0);
  const [name,setName] = useState("홍길동");
  const addNum = () => {
    setNum(num+1);
  }
  const chName = () => {
    const temp = name==='홍길동'?'김길동':'홍길동';
    return setName(temp);
  }
   
  return (
    <div className="App">
      <h1>{num}</h1>
      <button onClick={addNum}>버튼</button>
      <Child name={name}/>
      <button onClick={chName}>버튼</button>
    </div>
  );
}

export default App;
