import { useEffect, useState } from 'react';
import { Button, Spinner } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';

const FreeBoardView = () => {
  const { idx } = useParams();
  const [article, setArticle] = useState(null);
  useEffect(() => {
    fetch(`http://localhost:5000/freeboard/view`, {
      method: 'post',
      body: JSON.stringify({
        idx,
      }),
      headers: {
        'Content-Type': 'application/json',
        'authorization':localStorage.getItem('mytoken')
      },
    })
      .then((result) => result.json())
      .then((result) => {
        setArticle(result[0]);
      });
  }, []);

  const navigate = useNavigate();
  const deletefn = () => {
    fetch(`http://localhost:5000/freeboard/delete`, {
      method: 'post',
      body: JSON.stringify({
        idx,
      }),
      headers: {
        'Content-Type': 'application/json',
        'authorization':localStorage.getItem('mytoken')
      },
    })
      .then((result) => result.json())
      .then((data) => {
        console.log(data);
        if(data.status==='ok')
            navigate('/freeboard');
      });
  };

  const updatefn =()=>{
    console.log("test");
    navigate(`/freeboard/update/${idx}`);
  }

  if (article === null)
    return (
      <div className="d-flex justify-content-center">
        <Spinner className="m-5" animation="border" role="status">
          <span className="visually-hidden">Loading...</span>
        </Spinner>
      </div>
    );

  return (
    <div>
      <h1>FreeBoardView</h1>
      <h2>title</h2>
      <p>{article.title}</p>
      <h2>writer</h2>
      <p>{article.writer}</p>
      <h2>Content</h2>
      <p>{article.content}</p>
      <Button onClick={updatefn} className="mt-3 me-3">수정</Button>
      <Button onClick={deletefn} className="mt-3">
        삭제
      </Button>
    </div>
  );
};

export default FreeBoardView;
