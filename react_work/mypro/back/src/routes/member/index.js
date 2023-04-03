'use strict';

const express = require('express');
const router = express.Router();
const mysql = require('mysql2');

router.get('/member', (req, res) => {
  res.send({ student: { idx: 10, name: '홍길동' } });
});

module.exports = router;
