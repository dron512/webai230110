import React from 'react';
import './App.css';
import AA from './components/AA';

const doA = ():void =>{
  console.log("doA");
}

const doB = ():string =>{
  console.log("doB");
  return "doB";
}
// 복합..
type TypeA = {
  num : number,
  str : string,
}

// 복합..
type TypeB = {
  str : string,
  bool : boolean,
}

function App() {
  const a:TypeA & TypeB = {
    num: 20,
    str: "aa",
    bool: false
  }
  console.log(a);

  let str:string = "A";
  str = "10";
  // str = 10;

  const arr1:number[] =[10,20,30];
  // arr1.push("aaa");
  const arr2:Array<string> = ["홍길동","김길동","이길동"];
  // arr2.push(10);
  return (
    <div className="App">
      <h1>str = {str}</h1>
      {/* 102030 */}
      { arr1.map((num)=>num) }
      { arr2.map((name)=>name) }
      <AA/>
    </div>
  );
}

export default App;

