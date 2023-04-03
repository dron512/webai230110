'use strict';

const express = require('express');
const router = express.Router();
const mysql = require('mysql2');

router.get('/book', (req, res) => {
  const connection = mysql.createConnection({
    host: 'localhost',
    user: 'student',
    password: 'student123',
    database: 'mhpark',
  });
  connection.connect();
  connection.query('select * from kb_book', (e, rows, fields) => {
    if (e) console.log(e);
    // console.log(rows);
    res.send(rows);
  });
  connection.end();
});

module.exports = router;
