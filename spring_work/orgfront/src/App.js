import { Route, Routes } from 'react-router-dom';
import './App.css';
import SignInSide from './components/SignInSide';
import Main from './components/Main';
import VaForm from './components/VaForm';
import VaList from './components/VaList';
import Member from './components/Member';
import Board from './components/Board';

function App() {
  return (
    <div className="App">
      <h1>테스트11</h1>
      <Routes>
        <Route path='/' element={<SignInSide/>}/>
        <Route path='/main' element={<Main/>}/>
        <Route path='/vaform' element={<VaForm/>}/>
        <Route path='/valist' element={<VaList/>}/>
        <Route path='/board' element={<Board/>}/>
        <Route path='/member' element={<Member/>}/>
      </Routes>
    </div>
  );
}

export default App;
