import './App.css';
import Counter from './components/Counter';
import RandomNum from './components/RandomNum';

function App() {
  return (
    <div className="App">
      <RandomNum/>
      <Counter name="1번"></Counter>
      <Counter name="2번"></Counter>
      <Counter name="3번"></Counter>
    </div>
  );
}

export default App;
