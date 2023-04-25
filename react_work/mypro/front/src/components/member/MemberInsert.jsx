import axios from 'axios';
import { useRef } from 'react';
import { Button, FloatingLabel, Form } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';

const MemberInsert = () => {
  const firstNameRef = useRef();
  const lastNameRef = useRef();
  const emailRef = useRef();
  const passwordRef = useRef();

  const navigate = useNavigate();
  const insert = ()=>{
    axios.post('http://localhost:5000/users/insert',{
        firstName:firstNameRef.current.value,
        lastName:lastNameRef.current.value,
        email:emailRef.current.value,
        password:passwordRef.current.value
    })
    .then((result)=>{
        navigate('/member');
    })
  }
  return (
    <>
      <h1>MemberInsert</h1>
      <h2>firstName</h2>
      <FloatingLabel controlId="floatingInput" label="firstName" className="mb-3">
        <Form.Control type="text" placeholder="firstName" ref={firstNameRef} />
      </FloatingLabel>
      <h2>LastName</h2>
      <FloatingLabel controlId="floatingInput" label="lastName" className="mb-3">
        <Form.Control type="text" placeholder="lastName" ref={lastNameRef} />
      </FloatingLabel>
      <h2>Email</h2>
      <FloatingLabel controlId="floatingInput" label="email" className="mb-3">
        <Form.Control type="text" placeholder="email" ref={emailRef} />
      </FloatingLabel>
      <h2>Password</h2>
      <FloatingLabel controlId="floatingInput" label="password" className="mb-3">
        <Form.Control type="text" placeholder="password" ref={passwordRef} />
      </FloatingLabel>
      <Button onClick={insert} className="mt-3">
        저장
      </Button>
    </>
  );
};

export default MemberInsert;
