import { useState } from 'react';
import { MyButton } from '../styedcomponents/MyStylesCom';

const Student = ({ name: n, age: a, bo, dispatch }) => {
  const [name, setName] = useState(n);
  const [age, setAge] = useState(a);
  return (
    <div
      style={{ border: `1px solid ${bo}`, margin: '.5rem', padding: '.5rem' }}
    >
      <h3>학생이름 = {name}</h3>
      <h3>학생나이 = {age}</h3>
      <MyButton
        onClick={() => {
          dispatch({
            type:"del-data",
            name:name
          });
        }}
      >
        삭제
      </MyButton>
    </div>
  );
};

export default Student;
