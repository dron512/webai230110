import { useEffect, useState } from "react";
import { Table } from "react-bootstrap";

const Book = () => {
  const [datas, setDatas] = useState([]);

  useEffect(()=>{
    fetch(`http://localhost:5000/book`)
    .then( result => result.json())
    .then( data =>{
      console.log(data);
      setDatas(data);
    })
    console.log("use Effect 호출됨..");
  },[]);
  return (
    <>
      <h1>Book</h1>
      <p>도서</p>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>idx</th>
            <th>책제목</th>
            <th>저자</th>
            <th>출판사</th>
            <th>가격</th>
          </tr>
        </thead>
        <tbody>
          {datas.map((obj) => {
            return (
              <tr key={obj.idx}>
                <td>{obj.idx}</td>
                <td>{obj.bk_name}</td>
                <td>{obj.bk_writer}</td>
                <td>{obj.bk_compnay}</td>
                <td>{obj.bk_price}</td>
              </tr>
            );
          })}
        </tbody>
      </Table>
    </>
  );
};

export default Book;
