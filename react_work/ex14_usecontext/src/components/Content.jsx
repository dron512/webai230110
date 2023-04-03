import React, { useContext } from 'react';
import { MyName } from '../context/MyNameContext';

const Content = () => {
  const {name,setName} = useContext(MyName);
  return (
    <div>
      <h1>Content</h1>
      <h2>이름은 {name}</h2>
      <button onClick={() => {setName('김길동');}}>
        이름바꾸기
      </button>
    </div>
  );
};

export default Content;
