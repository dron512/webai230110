import React from 'react';
import { memo } from 'react';

const Child3 = () => {
  console.log('Child3 랜더링');
  return (
    <>
      <h1>Child3</h1>
    </>
  );
};

export default memo(Child3);
