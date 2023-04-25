'use strict';

const express = require('express');
const jwt = require('jsonwebtoken');
const router = express.Router();

const userSequlize = require('../../models/users');

const SECRET_KEY = 'pmh';

router.post('/login', async (req, res) => {
  const user = await userSequlize.findByEmail(req.body.email);
  if (!user) {
    return res
      .status(200)
      .json({ code: 200, message: 'email사용자가 없습니다.', error:"noemail" });
  }
  if (user.password !== req.body.password) {
    return res
      .status(200)
      .json({ code: 200, message: 'password가 다릅니다.', error: "nopassword" });
  }
  const token = jwt.sign(
    {
      type: 'JWT',
      email: req.body.email,
      firstName: user.firstName,
    },
    SECRET_KEY,
    {
      expiresIn: '1m', // 만료시간 1분
      issuer: '토큰발급자',
    }
  );
  return res.status(200).json({
    code: 200,
    message: '토큰이 발급되었습니다.',
    error: "success",
    token: token,
  });
});

module.exports = router;
