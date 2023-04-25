import './App.css';
import React, { useState } from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import MyNav from './components/nav/MyNav';
import { Link, Route, Routes } from 'react-router-dom';
import Main from './components/Main';
import FreeBoard from './components/freeboard/FreeBoard';
import Book from './components/book/Book';
import FreeBoardInsert from './components/freeboard/FreeBoardInsert';
import FreeBoardView from './components/freeboard/FreeBoardView';
import FreeBoardUpdate from './components/freeboard/FreeBoardUpdate';
import Member from './components/member/Member';
import MemberInsert from './components/member/MemberInsert';
import MemberUpdate from './components/member/MemberUpdate';
import SignIn from './components/login/SignIn';
import SignUp from './components/login/SignUp';


function App() {
    const [data, setData] = useState([{ bk_name: 'aaa' }, { bk_name: 'aaaa' }]);

    const rootfn = () => {
        fetch(`http://localhost:5000/`)
            .then((result) => result.text())
            .then((data) => {
                console.log(data);
            });
    };
    const rootfn1 = () => {
        fetch(`http://localhost:5000/book`)
            .then((result) => result.json())
            .then((getdata) => {
                console.log(...data);
                console.log(...getdata);
                const myresult = [...data, ...getdata];
                setData(myresult);
            });
    };
    return (
        // npm install styled-jsx
        <>
            <MyNav/>

            <Container>
                <Routes>
                    <Route path='/' element={<Main/>}></Route>

                    <Route path='/member' element={<Member/>}></Route>
                    <Route path='/member/insert' element={<MemberInsert/>}></Route>

                    <Route path='/member/update/:id' element={<MemberUpdate/>}></Route>



                    <Route path='/book' element={<Book/>}></Route>
                    <Route path='/freeBoard' element={<FreeBoard/>}></Route>
                    <Route path='/freeBoard/insert' element={<FreeBoardInsert/>}></Route>
                    <Route path='/freeBoard/update/:idx' element={<FreeBoardUpdate/>}></Route>
                    <Route path='/freeBoard/view/:idx' element={<FreeBoardView/>}></Route>

                    <Route path='/signin' element={<SignIn/>}></Route>
                    <Route path='/signup' element={<SignUp/>}></Route>
                </Routes>
            </Container>
        </>
    );
}

export default App;
