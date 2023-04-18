import axios from 'axios';
import { useEffect, useRef } from 'react';
import { useParams } from 'react-router-dom';
import { Button, FloatingLabel, Form } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';

const MemberUpdate = () => {
  const param = useParams();

  const navigate = useNavigate();
  const firstNameRef = useRef();
  const lastNameRef = useRef();
  const emailRef = useRef();
  const update = ()=>{
    axios.put('http://localhost:5000/users/update',{
        firstName:firstNameRef.current.value,
        lastName:lastNameRef.current.value,
        email:emailRef.current.value,
        id:param.id
    })
    .then((result)=>{
        navigate('/member');
    })
  };

  const deletec = ()=>{
    axios.put('http://localhost:5000/users/update',{
        firstName:firstNameRef.current.value,
        lastName:lastNameRef.current.value,
        email:emailRef.current.value,
        id:param.id
    })
    .then((result)=>{
        // navigate('/member');
    })
  }

  useEffect(()=>{
    axios.get(`http://localhost:5000/user/${param.id}`)
    .then((result)=>{
        firstNameRef.current.value = result.data[0].firstName;
        lastNameRef.current.value = result.data[0].lastName;
        emailRef.current.value = result.data[0].email;
    });
  },[]);
  return (
    <>
      <h1>memberUpdate</h1>
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
      <Button onClick={update} className="mt-3">
        수정
      </Button>
      <Button onClick={deletec} className="mt-3 ms-3">
        삭제
      </Button>
    </>
  );
};

export default MemberUpdate;
