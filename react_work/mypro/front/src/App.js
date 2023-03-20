import './App.css';
import React, { useState } from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import MyNav from './components/MyNav';
import { Route, Routes } from 'react-router-dom';


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
                        <a href="/" className='p-2'><h1>MY HOME PAGE</h1></a>
                    </Col>
                    <Col className="" xs={3}></Col>
                    <Col className="d-flex justify-content-end" xs={5}>
                        <a href="" className='p-3'><h2>홈</h2></a>
                        <a href="" className='p-3'><h2>사이트맵</h2></a>
                    </Col>
                </Row>
            </Container>
            <Container fluid className='p-3' style={{backgroundColor:"rgba(220,20,0,0.5)"}}>
                <Container>
                    <Row className='justify-content-center'>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>대회 안내</Col>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>코스 소개</Col>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>참가신청/확인</Col>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>대회기록</Col>
                        <Col className='text-white' style={{fontSize:"1.2rem",padding:"0 3rem"}}>알림마당</Col>
                    </Row>
                </Container>
            </Container>
            <Container>
                <MyNav/>
            </Container>
            <Routes>
                <Route path='/home' element={<MyNav></MyNav>}></Route>
            </Routes>
        </>
    );
}

export default App;
