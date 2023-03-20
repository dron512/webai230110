import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';

import React from 'react';
import { BrowserRouter as Router, Link, Routes, Route } from 'react-router-dom';
import { Home, Menu1, Menu2, Menu3 } from './components/MyComponents';

function App() {
    return (
        <Router>
            <div className="App">
                <h1>My Page</h1>
                <nav className="navi">
                    <Link className="link" to="/">HOME</Link>
                    <Link className="link" to="/menu1">MENU1</Link>
                    <Link className="link" to="/menu2">MENU1</Link>
                    <Link className="link" to="/menu3">MENU1</Link>
                </nav>
                <Routes>
                    <Route path="/" element={<Home />}></Route>
                    <Route path="/menu1" element={<Menu1 />}></Route>
                    <Route path="/menu2" element={<Menu2 />}></Route>
                    <Route path="/menu3" element={<Menu3 />}></Route>
                </Routes>
            </div>
            <style jsx="true">
                {`
                    .navi {
                        width: 100%;
                        background-color:rgba(200,200,0,0.5);
                    }
                    .link{
                        padding:1.4rem;
                        display:inline-block;
                        text-decoration:none;
                        color:#333;
                    }
                    .link:hover{
                        background-color:rgba(200,200,0,0.6);
                    }
                `}
            </style>
        </Router>
    );
}

export default App;
