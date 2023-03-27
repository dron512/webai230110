import logo from './logo.svg';
import './App.css';

import React, { useEffect, useMemo, useState } from 'react';

function App() {
  console.log('App 랜더링...');
  const [number, setNumber] = useState(0);
  const [location, setLocation] = useState({ contury: '한국' });
  const numberChange = (e) => {
    setNumber(number==0?1:0);
  };
  const locationChange = useMemo((e) => {
    return setLocation({
      contury: location.contury == '한국' ? '일본' : '한국',
    });
  },[]);
  useEffect(() => {
    console.log('useEffect');
  }, [number]);
  return (
    <div className="App">
      <header className="App-header">
        <input type="number" onChange={numberChange} />
        <h1>{number}</h1>
        <h1>{location.contury}</h1>
        <button onClick={locationChange}>나라변경</button>
      </header>
    </div>
  );
}

export default App;
