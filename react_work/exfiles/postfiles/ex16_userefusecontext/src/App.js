import './App.scss';
import React, { useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import Login, { AA } from './components/Login';
import Main from './components/Main';
import { A } from './context/MyAContext';

function App() {
  const [cnt, setCnt] = useState(0);
  const [globalA, setGlobalA] = useState(2222);

  return (
    <A.Provider value={{globalA,setGlobalA}}>
      <div>
        <Routes>
          <Route path="/" element={<Login />}></Route>
          <Route path="/main" element={<Main />}></Route>
          <Route path="/aa" element={<AA />}></Route>
        </Routes>
      </div>
    </A.Provider>
  );
}

export default App;
