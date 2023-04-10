import './App.css';
import React, { useState } from 'react';
import Chapter2 from './components/Chapter2';

function App() {
  const [data,setData] = useState('init');
  const dataload = ()=>{
    fetch(`http://localhost:5000/`)
    .then(result => result.text())
    .then(data =>{
      console.log(data);
      setData(data);
    })
  };

  return (
    <div className="App">
      <button onClick={dataload}>데이터 가져오기</button>
      <p>{data}</p>
      <Chapter2/>
    </div>
  );
}

export default App;
