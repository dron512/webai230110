import { useCallback, useEffect, useMemo, useState } from 'react';
import './App.css';
import MyComponent from './components/MyComponent';

/*
  memo 컴포넌트 저장
  useMemo 변수 저장
  useCallback 함수 저장
*/
function App() {
  console.log('App 랜더링');
  const [appcnt, setAppcnt] = useState(0);
  const doA = () => {
    console.log('useEffect 호출');
  };
  const doB = () => {
    return { child: 10 };
  };

  // const doC = (a,b) => {return a*b };
  // const child2 = doC(10,20);

  useEffect(doA, []);
  let child = useMemo(doB, []);
  // let child = { child: 10 };
  // const child2 = (a,b)=>{ return a * b;};
  const child2 = useCallback(() => {
    return (a, b) => {
      return a * b;
    };
  }, []);
  return (
    <div className="App">
      <h2>app cnt = {appcnt}</h2>
      <button
        onClick={() => {
          setAppcnt(appcnt + 1);
        }}
      >
        버튼
      </button>
      <MyComponent child={child} child2={child2} />
    </div>
  );
}

export default App;
