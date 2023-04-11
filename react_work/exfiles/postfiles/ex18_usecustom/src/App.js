import { useState } from 'react';
import './App.css';
import { LoginDiv, LoginInput, Menu, SubAutoMenu, SubMenu } from './styledcomponents/Styledusecom';
import { useInput } from './cumhocks/useInput';
import { useFetch } from './cumhocks/useFetch';

function App() {
  const [id,doCheck] = useInput();
  const [password,doCheck1] = useInput();

  const {users,loading,fn} = useFetch('users');

  return (
    <div>
      <Menu>메뉴</Menu>
      <SubMenu>
        <SubAutoMenu>하위</SubAutoMenu>
      </SubMenu>
      <LoginDiv>
        <h1>아이디</h1>
        <LoginInput type='text' onChange={doCheck} data-type="id" data-aa="asdf"></LoginInput>
        <h2>{id}</h2>
        <h1>패스워드</h1>
        <LoginInput type='password' onChange={doCheck1} data-type="password" data-aa="qwer"></LoginInput>
        <h2>{password}</h2>
      </LoginDiv>
      <button onClick={ ()=>{fn('users')} }>users 가져오기</button>
      <button onClick={ ()=>{fn('posts')} }>posts 가져오기</button>
      <button onClick={ ()=>{fn('todos')} }>todos 가져오기</button>
      { loading && <div>loding</div>}
      { users && users.map( (data)=> <div><pre>{JSON.stringify(data,null,2)}</pre></div> ) }
      
    </div>
  );
}

export default App;
