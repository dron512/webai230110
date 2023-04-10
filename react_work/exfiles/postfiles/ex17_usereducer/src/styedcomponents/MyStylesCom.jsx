import styled from 'styled-components';

export const MyStudentDiv = styled.div`
// max-width 750이상
  @media screen and (max-width: 750px) {
    border: 1px solid #333;
    margin: 1rem;
    padding: 0.5rem;
    width: 500px;
  }
// max-width 750이하
  @media screen and (min-width: 750px) {
    position: absolute;
    right: 0;
    top: 0;
    border: 1px solid #333;
    margin: 1rem;
    padding: 0.5rem;
  }
`;

export const MyInput = styled.input`
  margin: 0 auto;
  display: block;
  font-size: 2rem;
  padding: 0.5rem;
  padding-left: 50px;
  /* opacity: 0.5; */
  box-shadow: 1px 1px #333;
  margin-bottom: 0.5rem;
  background: url('logo192.png') no-repeat;
  background-size: 50px;
`;

export const CenterDiv = styled.div`
  width: 130px;
  margin: 1rem auto;
`

export const LeftDiv = styled.div`
  position: absolute;
  left: 10px;
  top: 10px;
  width: 100px;
  height: 70px;
  background-color: white;
  color: #333;
`;

export const RightDiv = styled.div`
  position: absolute;
  right: 10px;
  top: 10px;
  width: 150px;
  height: 70px;
  background-color: white;
  color: #333;
`;

export const Header = styled.div`
  position: relative;
  width: 600px;
  background-color: blue;
  font-size: 3rem;
  padding: 1rem;
  color: #eee;
  margin: 0 auto;
`;

export const MyButton = styled.button`
  font-size: 2rem;
  padding: 1rem;
`;
