import axios from 'axios';
import { useRef, useState } from 'react';

const SignIn = () => {
  const emailRef = useRef();
  const passwordRef = useRef();
  const [message,setMessage] = useState("");
  const signin = () => {
    axios
      .post(`http://localhost:5000/login`, {
        email: emailRef.current.value,
        password: passwordRef.current.value,
      })
      .then((result) => {
        if(result.data.error ==='success'){
            localStorage.setItem("mytoken",result.data.token);
            console.log(localStorage.getItem('mytoken'));
        }
        setMessage(result.data.message);
      })
      .catch((e) => {
        console.log(e);
      });
  };
  return (
    <div className="m-3">
      <h1>SignIn</h1>
      <label className="display-6 m-3">email</label>
      <input type="text" className="form-control" ref={emailRef}/>
      <label className="display-6 m-3">password</label>
      <input type="text" className="form-control mb-3" ref={passwordRef}/>
      <button className="btn btn-primary" onClick={signin}>
        SignIn
      </button>
      <h3>{message}</h3>
    </div>
  );
};

export default SignIn;
