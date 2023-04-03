import { useState } from 'react';
import './App.css';
import Page from './components/Page';
import { MyCss } from './context/MyCssContext';
import { MyName } from './context/MyNameContext';

function App() {
  const [name, setName] = useState('홍길동');

  return (
    <div className="App">
      <MyCss.Provider 
          value={{ fontSize: '2rem', backgroundColor: 'red' }}
          >
        <MyName.Provider value={{ name, setName }}>
          <Page />
        </MyName.Provider>
      </MyCss.Provider>
    </div>
  );
}

export default App;
