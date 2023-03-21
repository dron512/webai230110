import React, { useState } from 'react';
import { Col, Container, Row } from 'react-bootstrap';
import Button from 'react-bootstrap/Button';
import Offcanvas from 'react-bootstrap/Offcanvas';
import { Link } from 'react-router-dom';

const MyOff = () => {
  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  return (
    <>
      <Container>
        <Row>
          <Col className="d-flex justify-content-end m-3">
            <Button variant="primary" onClick={handleShow}>
              MENU
            </Button>
          </Col>
        </Row>
      </Container>

      <Offcanvas show={show} onHide={handleClose}>
        <Offcanvas.Header closeButton>
          <Offcanvas.Title>Offcanvas</Offcanvas.Title>
        </Offcanvas.Header>
        <Offcanvas.Body>
          Some text as placeholder. In real life you can have the elements you
          have chosen. Like, text, images, lists, etc.
          <h1><Link to="/home">Home</Link></h1>
          <h1><Link to="/ex04">Ex04</Link></h1>
        </Offcanvas.Body>
      </Offcanvas>
    </>
  );
};

export default MyOff;
