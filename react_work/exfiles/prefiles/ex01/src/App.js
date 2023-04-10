import './App.css';
import About from './components/About.js';
import Counter from './components/Counter.js';
import Home from './components/Home.js';
import Sum from './components/Sum.js';

import { Link, Route, Routes } from 'react-router-dom';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>MYPAGE</h1>
        <nav>
          <Link className='App-link' to="/">home</Link>
          <Link className='App-link' to="/about">About</Link>
          <Link className='App-link' to="/counter">Counter</Link>
          <Link className='App-link' to="/sum">Sum</Link>
        </nav>
        <Routes>
          <Route path="/" element={<Home/>}/>
          <Route path="/about" element={<About/>}/>
          <Route path="/counter" element={<Counter/>}/>
          <Route path="/sum" element={<Sum/>}/>
        </Routes>
        <Counter/>
      </header>
    </div>
  );
}

export default App;
