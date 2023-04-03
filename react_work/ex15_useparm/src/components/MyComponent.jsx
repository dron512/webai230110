import { memo, useState } from 'react';

const MyComponent = memo((props) => {
  const child = props.child,
    child2 = props.child2;
  console.log('MyComponent 랜더링' + child.child + ' ' + child2);
  const [mycnt, setMycnt] = useState(0);
  return (
    <>
      <h1>MyComponent</h1>
      <h2>mycnt = {mycnt}</h2>
      <button
        onClick={() => {
          setMycnt(mycnt + 1);
        }}
      >
        버튼
      </button>
    </>
  );
});

export default MyComponent;
