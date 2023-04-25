import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import { Link, useNavigate } from 'react-router-dom';

const MyNav = () => {

  const navigate = useNavigate();

  const moveSignIn = ()=>{
    navigate('/signin');
  }
  const moveSingUp = ()=>{
    navigate('/signup');
  }
  return (
    <div>
      <Navbar style={{ backgroundColor: 'rgba(220,20,0,0.5)' }} expand="lg">
        <Container>
          <Navbar.Brand as={Link} to="/">
            <h1>MYHOMEPAGE</h1>
          </Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <div className='me-auto'></div>
            <Nav className="me-auto">
              <Nav.Link className="text-white" as={Link} to="/member">
                <h4>회원</h4>
              </Nav.Link>
              <Nav.Link className="text-white" as={Link} to="/book_rent">
                <h4>대여</h4>
              </Nav.Link>
              <Nav.Link className="text-white" as={Link} to="/book">
                <h4>도서</h4>
              </Nav.Link>
              <Nav.Link className="text-white" as={Link} to="/freeboard">
                <h4>게시판</h4>
              </Nav.Link>
              <NavDropdown
                title="MEMBER"
                id="basic-nav-dropdown"
              >
                <NavDropdown.Item onClick={moveSignIn}>
                  <h4>SIGNIN</h4>
                </NavDropdown.Item>
                <NavDropdown.Item onClick={moveSingUp}>
                  <h4>SIGNUP</h4>
                </NavDropdown.Item>
                <NavDropdown.Divider />
                <NavDropdown.Item href="#action/3.4">
                  <h4>Separated link</h4>
                </NavDropdown.Item>
              </NavDropdown>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
    </div>
  );
};

export default MyNav;
