import { useEffect, useState } from 'react';
import { Table, Spinner, Button, Nav } from 'react-bootstrap';
import { Link } from 'react-router-dom';

const FreeBoard = () => {
  const [datas, setDatas] = useState([]);

  useEffect(() => {
    fetch(`http://localhost:5000/freeboard`)
      .then((result) => result.json())
      .then((data) => {
        setDatas(data);
      });
    console.log('use Effect 호출됨..');
  }, []);

  if (datas.length === 0)
    return (
      <div className="d-flex justify-content-center">
        <Spinner className="m-5" animation="border" role="status">
          <span className="visually-hidden">Loading...</span>
        </Spinner>
      </div>
    );

  return (
    <>
      <h1>FreeBoard</h1>
      <p>게시판</p>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>idx</th>
            <th>title</th>
            <th>writer</th>
            <th>regdate</th>
          </tr>
        </thead>
        <tbody>
          {datas.map((obj) => {
            return (
              <tr key={obj.idx}>
                <td>{obj.idx}</td>
                <td>{obj.content}</td>
                <td>{obj.writer}</td>
                <td>{obj.regdate}</td>
              </tr>
            );
          })}
        </tbody>
      </Table>
      <Nav.Link as={Link} 
        to="/freeboard/insert" 
        className='btn btn-primary text-white' 
        style={{width:"6rem",padding:"0.5rem"}}>
          글쓰기
      </Nav.Link>
    </>
  );
};

export default FreeBoard;
