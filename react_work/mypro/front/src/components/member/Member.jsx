import { useEffect, useState } from 'react';
import axios from 'axios';
import { Button, Pagination, Spinner, Table } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';

const Member = () => {
  const navigate = useNavigate();
  const [datas, setDatas] = useState();

  const [active,setActive] = useState(1);
  let items = [];
  for (let number = 1; number <= 5; number++) {
    items.push(
      <Pagination.Item key={number} active={number === active} 
        onClick={()=>{setActive(number)}} data-pagenum={number}>
        {number}
      </Pagination.Item>
    );
  }
  useEffect(() => {
    axios
      .get(`http://localhost:5000/users/${active}`)
      .then((result) => {
        setDatas(result.data);
      })
      .catch((e) => {
        console.log(e);
      });
  }, [active]);

  if (!datas) {
    return (
      <div className="d-flex justify-content-center">
        <Spinner className="m-5" animation="border" role="status">
          <span className="visually-hidden">Loading...</span>
        </Spinner>
      </div>
    );
  }

  const moveinsert = () => {
    navigate('/member/insert');
  };

  const moveupdate = (e) => {
    // console.log(e.target.parentNode.dataset.key);
    const key = e.target.parentNode.dataset.key;
    navigate(`/member/update/${key}`);
  };

  const movepage = (e)=>{
    console.log(e.target.dataset.pagenum);
  }

  

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
            <th>password</th>
            <th>createdAt</th>
          </tr>
        </thead>
        <tbody>
          {datas.map((obj) => {
            return (
              <tr
                key={obj.id}
                onClick={moveupdate}
                data-key={obj.id}
                style={{ cursor: 'pointer' }}
              >
                <td>{obj.id}</td>
                <td>{obj.firstName}</td>
                <td>{obj.lastName}</td>
                <td>{obj.email}</td>
                <td>{obj.password}</td>
                <td>{obj.createdAt}</td>
              </tr>
            );
          })}
        </tbody>
      </Table>
      <div className='d-flex justify-content-center'>
        <Pagination>{items}</Pagination>
      </div>
      <Button onClick={moveinsert}>회원추가</Button>
    </>
  );
};

export default Member;
