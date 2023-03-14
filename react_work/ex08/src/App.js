import './App.css';
import Counter, {AA as A} from './components/Counter';
// import RandomNum from './components/RandomNum';
import React, { useEffect, useState } from 'react';

function App() {
    console.log('랜더링...');
    const [count, setCount] = useState(0);
    const [count2, setCount2] = useState(0);
    useEffect(() => {
        alert('useEffect');
    }, []);
    const doButton = () => {
        setCount(count + 1);
    };
    const doButton2 = () => {
        setCount2(count2 + 1);
    };
    return (
        <div className="App">
            <A></A>
            <h1>count = {count}</h1>
            <h1>count2 = {count2}</h1>
            <button onClick={doButton}>버튼1</button>
            <button onClick={doButton2}>버튼2</button>
            {/* <RandomNum/>
      <Counter name="1번"></Counter>
      <Counter name="2번"></Counter>
      <Counter name="3번"></Counter> */}
        </div>
    );
}

export default App;
