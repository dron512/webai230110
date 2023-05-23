import { Route, Routes } from 'react-router-dom';
import './App.css';
import SignInSide from './components/SignInSide';
import Main from './components/Main';

function App() {
  return (
    <div className="App">
      <Routes>
        <Route path='/' element={<SignInSide/>}/>
        <Route path='/main' element={<Main/>}/>
      </Routes>
    </div>
  );
}

export default App;
