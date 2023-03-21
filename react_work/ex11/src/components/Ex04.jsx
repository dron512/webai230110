import { useState } from 'react';
import { Container, Form } from 'react-bootstrap';

let startnum, endnum;

const Ex04 = () => {
  const [out, setOut] = useState('1*1=1\n1*2=2');
  const setStart = (e) => {
    startnum = e.target.value;
    console.log(`start stnum = ${startnum} ennum = ${endnum}`);
    if ( startnum ==='undefined' || endnum === 'undefined' ) return;
    let localOut = "";
    for ( let i = startnum; i<=endnum; i++ ){
        for ( let j = 1; j<10; j++ ){
           localOut += `${i} * ${j} = ${i*j}\n`;
        }
    }
    setOut(localOut);
  };
  const setEnd = (e) => {
    endnum = e.target.value;
    console.log(`end stnum = ${startnum} ennum = ${endnum}`);
    if ( startnum ==='undefined' || endnum === 'undefined' ) return;
    let localOut = "";
    for ( let i = startnum; i<=endnum; i++ ){
        for ( let j = 1; j<10; j++ ){
           localOut += `${i} * ${j} = ${i*j}\n`;
        }
    }
    setOut(localOut);
  };
  return (
    <>
      <Container>
        <h1>Ex04</h1>
        {/* <img src="http://placekitten.com/200/300"></img>
        <img src="http://placekitten.com/150/200"></img> */}
        <p>4. 두개의 정수를 입력받아 구구단 출력 3,5 3단5단까지 html 에 출력</p>
        <Form>
          <Form.Group className="mb-3">
            <Form.Label>단 수</Form.Label>
            <Form.Control type="text" placeholder="Enter" onChange={setStart} />
            <Form.Text className="text-muted">몇단 부터 입력하세요</Form.Text>
          </Form.Group>

          <Form.Group className="mb-3">
            <Form.Label>몇단</Form.Label>
            <Form.Control type="text" placeholder="Enter" onChange={setEnd} />
            <Form.Text className="text-muted">몇단 까지 입력하세요</Form.Text>
          </Form.Group>
        </Form>
        <p>{out}</p>
      </Container>
    </>
  );
};

export default Ex04;
