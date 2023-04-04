import { useRef } from 'react';
import { Button, FloatingLabel, Form, InputGroup } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';

const FreeBoardInsert = () => {
  const titleRef = useRef();
  const writerRef = useRef();
  const contentRef = useRef();

  const navigate = useNavigate();
  const insert = () => {
    fetch(`http://localhost:5000/freeboard/insert`, {
      method: 'post',
      body: JSON.stringify({
        title: titleRef.current.value,
        writer: writerRef.current.value,
        content: contentRef.current.value,
      }),
      headers: {
        'Content-Type': 'application/json',
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
      <h1>FreeBoardInsert</h1>
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
      <Button onClick={insert} className="mt-3">
        저장
      </Button>
    </div>
  );
};

export default FreeBoardInsert;
