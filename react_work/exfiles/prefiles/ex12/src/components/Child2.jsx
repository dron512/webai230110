import React from 'react';
import { memo } from 'react';

const Child2 = () => {
  console.log('Child2 랜더링');
  return (
    <>
      <h1>Child2</h1>
    </>
  );
};

export default memo(Child2);
