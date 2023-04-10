import { useContext, useRef, useState } from 'react';
import { A } from '../context/MyAContext';

const Main = () => {

  const {globalA,setGlobalA} =useContext(A);

  const [cnt, setCnt] = useState(0);
  const a = useRef(0);
  const b = useRef(0);
  console.log('b = ');
  console.log(b);
  const doA = () => {
    setCnt(cnt + 1);
  };

  const doB = () => {
    console.log('a = ');
    console.log(a);
    a.current = a.current + 1;
  };
  const doC = () => {
    console.log('b = ');
    console.log(b);
    b.current.value = b.current.value + 1;
  };
  const doGlobalA = ()=>{ setGlobalA(globalA+1); }

  return (
    <>
      <h3>globalA = {globalA}</h3>
      <button className='fb-btn' onClick={doGlobalA}>doGlobalA</button>
      <h1>Main</h1>
      <h2>cnt = {cnt}</h2>
      <h2>a = {a.current}</h2>
      <label>
        <span>inputValue</span>
        <input type="text" ref={b} className="" />
      </label>
      <button onClick={doA} type="button" className="fb-btn">
        doA
      </button>
      <button onClick={doB} type="button" className="fb-btn">
        doB
      </button>
      <button onClick={doC} type="button" className="fb-btn">
        doC
      </button>
    </>
  );
};

export default Main;
