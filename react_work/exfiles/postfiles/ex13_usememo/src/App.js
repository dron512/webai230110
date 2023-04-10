import './App.css';
import React, { useEffect, useState,useMemo } from 'react';

function App() {

  const a = 10;
  const b = {b:10};

  const c = a;
  const d = b;


  const [num, setNum] = useState(0);
  const addNum = () => {
    setNum(num + 1);
  };

  const [isKorea, setIskorea] = useState('한국');
  const ChContury = () => {
    const temp = isKorea === '한국' ? '일본' : '한국';
    setIskorea(temp);
  };

  const location = useMemo(() => {
    return { contury: isKorea === '한국' ? '일본' : '한국' };
  }, [isKorea]);

  useEffect(() => {
    console.log('useEffect 호출됨...');
  }, [location]);

  return (
    <div className="App">
      <h1>{num}</h1>
      <button onClick={addNum}>버튼</button>
      <h1>나라 {location.contury}</h1>
      <button onClick={ChContury}>버튼</button>
    </div>
  );
}

export default App;
