import { useEffect, useState } from 'react';
import { Table, Spinner, Button, Nav } from 'react-bootstrap';
import { Link, useNavigate } from 'react-router-dom';
import axios from 'axios';

const FreeBoard = () => {
  const [datas, setDatas] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    const token = localStorage.getItem('mytoken');

    if (!token) {
      navigate('/signin');
    }

    axios
      .get(`http://localhost:5000/freeboard`, {
        headers: { Authorization: token },
      })
      .then((result) => {
        setDatas(result.data);
      })
      .catch((e) => {
        navigate('/signin');
      });
  }, []);

  if (datas === null)
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
      <p>👏😜게시판</p>
      <Table striped bordered hover>
        <thead className="text-center">
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
              <tr key={obj.idx} className="text-center">
                <td>{obj.idx}</td>
                <td>
                  <Link to={`/freeboard/view/${obj.idx}`}>{obj.title}</Link>
                </td>
                <td>{obj.writer}</td>
                <td>{obj.regdate}</td>
              </tr>
            );
          })}
        </tbody>
      </Table>
      <Nav.Link
        as={Link}
        to="/freeboard/insert"
        className="btn btn-primary text-white"
        style={{ width: '6rem', padding: '0.5rem' }}
      >
        글쓰기
      </Nav.Link>
      <div className="m-5"></div>
    </>
  );
};

export default FreeBoard;
