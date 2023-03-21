import './App.css';
import { BrowserRouter, Link, Route, Routes } from 'react-router-dom';
import {} from 'react-bootstrap';
import MyNav from './components/MyNav';
import MyOff from './components/MyOff';
import Home from './components/Home';
import Ex04 from './components/Ex04';

// 브라우저 라우터 돔 // LINK COMPONENT
// 리액트 부트스트랩 // Container -> ROW COL

function App() {
    return (
        <BrowserRouter>
            <div className="App">
                <MyNav></MyNav>
                {/* <Link to="/home">home</Link>
                <Link to="/ex04">ex04</Link> */}
            </div>
            <MyOff />
            <Routes>
              <Route path='/home' element={<Home/>}></Route>
              <Route path='/ex04' element={<Ex04/>}></Route>
            </Routes>
        </BrowserRouter>
    );
}

export default App;

