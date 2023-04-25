'use strict';

const express = require('express');
const router = express.Router();

router.get('/member', (req, res) => {
  res.send({ student: { idx: 10, name: '홍길동' } });
});

module.exports = router;
