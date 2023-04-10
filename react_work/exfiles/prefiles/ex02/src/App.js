import logo from './logo.svg';
import './App.css';
import Person from './components/Person';

function App() {
  const req1 = ()=>{
    fetch(`http://localhost:5000/`)
    .then( result => result.text())
    .then( data => { console.log(data); })
  };
  const req2 = ()=>{
    fetch(`http://localhost:5000/aa`)
    .then( result => result.text())
    .then( data => { console.log(data); })
  };
  return (
    <div className="App">
      <Person name="홍길동" age={20}/>
      <Person name="김길동" age={30}/>
      <Person name="박길동" age={40}/>
      <button onClick={req1}>버튼</button>
      <button onClick={req2}>버튼</button>
    </div>
  );
}

export default App;
