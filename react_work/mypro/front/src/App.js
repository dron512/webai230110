import './App.css';
import React, { useState } from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import MyNav from './components/MyNav';
import { Link, Route, Routes } from 'react-router-dom';
import Main from './components/Main';
import FreeBoard from './components/FreeBoard';
import Book from './components/Book';
import FreeBoardInsert from './components/FreeBoardInsert';


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
            <Container>
                <Row className='p-1'>
                    <Col className="" xs={4}>
                        <Link to="/" className='p-2'><h1>MY HOME PAGE</h1></Link>
                    </Col>
                    <Col className="" xs={3}></Col>
                    <Col className="d-flex justify-content-end" xs={5}>
                        <Link to="/signin" className='p-3'><h2>로그인</h2></Link>
                        <Link to="/signup" className='p-3'><h2>회원가입</h2></Link>
                    </Col>
                </Row>
            </Container>
            <Container fluid className='p-3' style={{backgroundColor:"rgba(220,20,0,0.5)"}}>
                <Container>
                    <Row className='justify-content-center'>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>
                            <Link to="/member">
                                회원
                            </Link>
                        </Col>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>
                            <Link to="/book_rent">
                                대여
                            </Link>
                        </Col>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>
                            <Link to="/book">
                                도서
                            </Link>
                        </Col>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>
                            <Link to="/freeboard">
                                게시판
                            </Link>
                        </Col>
                    </Row>
                </Container>
            </Container>
            <Container>
                <Routes>
                    <Route path='/' element={<Main/>}></Route>
                    <Route path='/book' element={<Book/>}></Route>
                    <Route path='/freeBoard' element={<FreeBoard/>}></Route>
                    <Route path='/freeBoard/insert' element={<FreeBoardInsert/>}></Route>
                </Routes>
            </Container>
        </>
    );
}

export default App;
