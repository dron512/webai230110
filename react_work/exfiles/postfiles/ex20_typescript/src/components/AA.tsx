import * as React from 'react';

const AA = () => {
  const [a, setA] = React.useState<string|number>("");
  return (
    <>
      <h1>{a}</h1>
      <button onClick={()=>{setA("문자")}}>버튼</button>
      <button onClick={()=>{setA(10)}}>버튼</button>
    </>
  );
};

export default AA;
