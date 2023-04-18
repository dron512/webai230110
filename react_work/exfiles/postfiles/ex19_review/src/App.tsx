import './App.css';
import Person from './components/Person';
import * as React from 'react';

// 객체 분할 대입 배열분할 대입
// map filter
// typesciprt

function App() {
  const age = 10;
  const name = '홍길동';
  const obj = {
    age,
    name,
    comment: '잘생김',
  };

  const list1 = [obj, obj, obj];
  list1[0].age = 20;
  // console.log("=============");
  // console.log(list1);

  const list2 = [{ ...obj, name: '김길동' }, { ...obj, age: 40 }, { ...obj }];
  list2[0].age = 30;

  const list3 = list2.filter((obj)=> { return obj.name!=='김길동' });
  console.log(list3);

  return (
    <div className="App">
      {list2.map((obj, idx:number) => {
        return <Person key={idx} myobj={obj} />;
      })}
    </div>
  );
}

export default App;
