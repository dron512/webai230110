import {
  HeaderMenu,
  HeaderNav,
  SubMenu,
  Title,
} from './styedcomponents/MyMenu';
import { LeftDiv, RightDiv } from './styedcomponents/MyStylesCom';

const doA = () => {
  console.log('test');
};

const Menu = () => {
  return (
    <div style={{ width: '1120px', margin: '0 auto' }}>
      <HeaderMenu>
        <LeftDiv>
          <div onClick={doA}>
            <img src="logo192.png" alt="" srcset="" height="100" />
            <Title>MYHOME</Title>
          </div>
        </LeftDiv>
        <HeaderNav>
          <SubMenu className="menu">회원관리</SubMenu>
          <SubMenu className="menu">테스트</SubMenu>
          <SubMenu className="menu">테스트</SubMenu>
          <SubMenu className="menu">게시판</SubMenu>
          <div className="child-div">
            <hr></hr>
            <h2>alskdjfnalskdfjnalskdjfn</h2>
            <hr></hr>
          </div>
        </HeaderNav>
      </HeaderMenu>
    </div>
  );
};

export default Menu;
