// import A, { B } from './components/MyUse';
import MyUse from './components/MyUse';
import {
  Link,
  Route,
  Routes,
  useNavigate,
} from 'react-router-dom';
import { useRef } from 'react';

const App1 = () => {
  const inputRef = useRef();
  const myNavigate = useNavigate();
  const doA = () => {
    const inputText = inputRef.current.value;
    myNavigate(`/MyUse/${inputText}`);
  };
  const doB = (e) =>{
    console.log("doB 함수 호출"+e.target.value);
    const inputText = e.target.value;
    myNavigate(`/MyUse/${inputText}`);
  }
  return (
    <>
      <h1>다들</h1>
      <p>....</p>
      <input type="text" ref={inputRef} onChange={doB}></input>
      <button onClick={doA}>버튼</button>
      <nav>
        <Link to="/MyUse/1">1번</Link>
        <Link to="/MyUse/2">2번</Link>
        <Link to="/MyUse/3">3번</Link>
      </nav>
      <Routes>
        <Route path="/MyUse/:idx" element={<MyUse />}></Route>
      </Routes>
    </>
  );
};

export default App1;
