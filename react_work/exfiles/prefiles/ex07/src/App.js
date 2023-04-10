import { useEffect, useState } from 'react';
import './App.css';
import Test from './components/Test';

function App() {

  const [days,setDays] = useState([{id:1,DAY:1},{id:2,DAY:2}]);
  const [words,setWords] = useState([]);

  useEffect( 
    ()=>{
      fetch(`http://localhost:5000/days`)
      .then(result=>result.json())
      .then(datas=>{
        console.log(datas);
        setDays(datas);
        console.log(days);
      })
    } 
  , []);

  const getWord = (e)=>{ 
    console.log(e.target.dataset.day);
    const $day = e.target.dataset.day
    fetch(`http://localhost:5000/words/${$day}`)
    .then( result => result.json() )
    .then( datas=> { setWords(datas) })
  };
  
  return (
    <div className="App">
      {
        days.map( (day)=>{ return <button onClick={getWord} key={day.id} data-day={day.DAY}>{day.DAY}일차</button>; } )
      }
      {
        words.map( (word)=>{ return <h3 key={word.id}>{word.DAY}일차 영어 {word.eng} 한글 {word.kor}</h3>; } )
      }
      <Test/>
      <Test color="#f00" backgroundColor="#eee"/>
      <Test color="#eee" backgroundColor="#333"/>
      <Test color="#0f0" backgroundColor="#eee"/>
    </div>
  );
}

export default App;
