import * as React from 'react';

export interface myobj{
  name:string,
  age:number,
  comment?:string
}

const Person:React.FC<{myobj:myobj}> = ( {myobj} ) => {
  return (
    <div>
      <h1> 나이 {myobj.age} </h1>
      <h1> 이름 {myobj.name} </h1>
    </div>
  );
};

export default Person;
