import { useEffect, useState } from 'react';
import axios from 'axios';
import { Button, Spinner, Table } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';

const Member = () => {
  const navigate = useNavigate();
  const [datas, setDatas] = useState();
  useEffect(() => {
    axios
      .get(`http://localhost:5000/users`)
      .then((result) => {
        // result.data.map((data) => {
        //   console.log(data);
        // });
        setDatas(result.data);
      })
      .catch((e) => {
        console.log(e);
      });
  }, []);

  if (!datas) {
    return (
      <div className="d-flex justify-content-center">
        <Spinner className="m-5" animation="border" role="status">
          <span className="visually-hidden">Loading...</span>
        </Spinner>
      </div>
    );
  }

  const handleClick = () => {
    navigate('/member/insert');
  };

  return (
    <>
      <h1>Member</h1>
      <Table striped bordered hover>
        <thead className="text-center">
          <tr>
            <th>id</th>
            <th>firstName</th>
            <th>lastName</th>
            <th>email</th>
            <th>createdAt</th>
          </tr>
        </thead>
        <tbody>
          {datas.map((obj) => {
            return (
              <tr key={obj.id}>
                <td>{obj.id}</td>
                <td>{obj.firstName}</td>
                <td>{obj.lastName}</td>
                <td>{obj.createdAt}</td>
                <td>{obj.email}</td>
              </tr>
            );
          })}
        </tbody>
      </Table>
      <Button onClick={handleClick}>회원추가</Button>
    </>
  );
};

export default Member;
