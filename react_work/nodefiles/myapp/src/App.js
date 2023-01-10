import React from 'react';

import './App.css';

class Person{
  constructor(name,age){
    this.name = name;
    this.age = age;
  }
}

let aryPerson = Array([])
aryPerson.push(new Person("aa",20))
aryPerson.push(new Person("bb",30))
aryPerson.push(new Person("cc",25))
aryPerson.push(new Person("dd",22))
aryPerson.push(new Person("ee",24))

function App() {
  let test ="테스트";
  return (
    <div className="App">
      {test}
      { 
        aryPerson.forEach((person)=>{
          return person.name
        })  
      }
    </div>
  );
}

export default App;
