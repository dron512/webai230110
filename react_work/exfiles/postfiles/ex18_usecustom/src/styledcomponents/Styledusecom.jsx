import styled from 'styled-components';

export const LoginInput =styled.input`
  font-size: 2rem;
  line-height: 2rem;
`

export const LoginDiv = styled.div`
  background-color: #2faa1a;
  width: 600px;
  height: 250px;
  margin: 0 auto;
  color :#e9e9e9;
  padding: 1rem;
`

export const Menu = styled.div`
  background-color: #458712;
  font-size: 2rem;
  width: 200px;
  margin: 0 auto;
  text-align: center;
  color: #e9e9e9;
  padding: 1rem;
  &:hover {
    cursor: pointer;
  }
  &:hover ~ div {
    display: block;
  }
`;
export const SubMenu = styled.div`
  position: fixed;
  width: 100%;
  background-color: #458712;
  color: #e9e9e9;
  display: none;
  border: 1px solid #333;
  height: 150px;
  &:hover {
    display: block;
  }
`;
export const SubAutoMenu = styled.div`
  width: 800px;
  margin: 0 auto;
  border: 1px solid #333;
  height: 150px;
`;
