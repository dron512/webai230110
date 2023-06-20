import { useEffect, useRef, useState } from 'react';
import { Button, FloatingLabel, Form, InputGroup } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';

const FreeBoardUpdate = () => {
  const titleRef = useRef();
  const writerRef = useRef();
  const contentRef = useRef();

  const idxRef = useRef(0);

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
        console.log(result[0]);
        titleRef.current.value = result[0].title;
        writerRef.current.value = result[0].writer;
        contentRef.current.value = result[0].content;
        idxRef.current = result[0].idx;
        console.log(`idxRef.current = ${idxRef.current}`)
      });
  }, []);

  
  const navigate = useNavigate();
  const update = () => {
    fetch(`http://localhost:5000/freeboard/update`, {
      method: 'post',
      body: JSON.stringify({
        title: titleRef.current.value,
        writer: writerRef.current.value,
        content: contentRef.current.value,
        idx : idxRef.current,
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
  return (
    <div>
      <h1>FreeBoardUpdate</h1>
      <h2>title</h2>
      <FloatingLabel controlId="floatingInput" label="title" className="mb-3">
        <Form.Control type="text" placeholder="title" ref={titleRef} />
      </FloatingLabel>
      <h2>writer</h2>
      <FloatingLabel controlId="floatingInput" label="writer" className="mb-3">
        <Form.Control type="text" placeholder="writer" ref={writerRef} />
      </FloatingLabel>
      <h2>Content</h2>
      <Form.Control
        as="textarea"
        aria-label="With content"
        className="mb-3"
        ref={contentRef}
      />
      <Button onClick={update} className="mt-3">
        저장
      </Button>
    </div>
  );
};

export default FreeBoardUpdate;
