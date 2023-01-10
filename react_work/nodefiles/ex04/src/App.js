import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';


import './App.css';
import Board from './components/Board';
import Content from './components/Content';
import MyComponents from './components/MyComponents';
import Nav from './components/Nav';
import TodaysPlan from './components/TodaysPlan';

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
      <BrowserRouter>
      <Nav></Nav>
      <Switch>
        <Route exact path="">
          <Content></Content>
        </Route>
      </Switch>
      <h1 className='title'>게시판</h1>
      <Board></Board>
      <TodaysPlan/>
      <MyComponents name="홍길동"/>
      {test}
      { 
        aryPerson.forEach((person)=>{
          return person.name
        })  
      }
      </BrowserRouter>
    </div>
  );
}

export default App;
