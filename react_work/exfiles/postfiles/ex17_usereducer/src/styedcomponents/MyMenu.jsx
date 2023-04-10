import styled from 'styled-components';

export const HeaderMenu = styled.div`
  width: 1120px;
  position: relative;
  height: 120px;
  /* overflow: hidden; */
`;

export const Title = styled.span`
  float: right;
  margin-top: 35px;
  margin-left: 20px;
  line-height: 2rem;
  font-size: 2rem;
`;

export const HeaderNav = styled.div`
  display: flex;
  align-items: center;
  justify-content: end;
  height: 100%;
`;

export const SubMenu = styled.div`
  font-size: 2rem;
  line-height: 2rem;
  padding: 2rem .5rem;
  border-radius: 0.5rem;
  /* background-color: #b95047; */
  &:hover {
    cursor: pointer;
    color: #b95047;
  }
 
`;
