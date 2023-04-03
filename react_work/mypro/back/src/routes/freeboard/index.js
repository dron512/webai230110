'use strict';

const express = require('express');
const router = express.Router();
const mysql = require('mysql2');

router.get('/freeboard', (req, res) => {
  const connection = mysql.createConnection({
    host: 'localhost',
    user: 'student',
    password: 'student123',
    database: 'mhpark',
  });
  connection.connect();
  connection.query(
    `SELECT idx,title,content,writer,hits,
        (CASE
            WHEN INSTR(DATE_FORMAT(regdate, '%Y-%m-%d %p %h:%i'), 'PM') > 0
            THEN REPLACE(DATE_FORMAT(regdate, '%Y-%m-%d %p %h:%i'), 'PM', '오후')
            ELSE REPLACE(DATE_FORMAT(regdate, '%Y-%m-%d %p %h:%i'), 'AM', '오전')    
            END) AS regdate
        FROM freeboard;
        `,
    (e, rows, fields) => {
      if (e) console.log(e);
      // console.log(rows);
      res.send(rows);
    }
  );
  connection.end();
});

router.post('/freeboard/insert', (req, res) => {
  console.log(req.body);
  const connection = mysql.createConnection({
    host: 'localhost',
    user: 'student',
    password: 'student123',
    database: 'mhpark',
  });
  connection.connect();
  connection.query(
    `insert into freeboard 
                        (title,content,writer,regdate)
                        values ( ?,?,?,now() )`,
    [req.body.title, req.body.content, req.body.writer],
    (e, rows, fields) => {
      if (e) console.log(e);
      res.send({ status: 'ok' });
    }
  );
  connection.end();
});

router.post('/freeboard/view', (req, res) => {
  console.log(req.body);
  const connection = mysql.createConnection({
    host: 'localhost',
    user: 'student',
    password: 'student123',
    database: 'mhpark',
  });
  connection.connect();
  connection.query(
    `select * from freeboard where idx = ?`,
    [req.body.idx],
    (e, rows, fields) => {
      if (e) console.log(e);
      res.send(rows);
    }
  );
  connection.end();
});

module.exports = router;
