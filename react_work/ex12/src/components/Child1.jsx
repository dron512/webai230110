import React from 'react';
import { memo } from 'react';
import Child2 from './Child2';
import Child3 from './Child3';

const Child1 = ({ cnt,name,cntReset }) => {
  console.log('Child1 랜더링');
  return (
    <>
      <h1>Child1 cnt = {cnt}</h1>
      <h1>Child1 name = {name}</h1>
      <button onClick={cntReset}>
        리셋
      </button>
      <Child2/>
      <Child3/>
    </>
  );
};

export default memo(Child1);
