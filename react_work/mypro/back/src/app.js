'use strict';

// node index.js index.js 실행해라
const express = require('express');
const cors = require('cors');
const app = express();

app.use(express.json());
app.use(express.urlencoded({ extended: true }));
app.use(cors());

const freeBoardRouter = require('./routes/freeboard');
const userRouter = require('./routes/user');
const bookRouter = require('./routes/book');
const memberRouter = require('./routes/member');

const loginRouter = require('./routes/login');

app.use('/', loginRouter);

const { auth } = require('./routes/login/authMiddleWare.js');

app.use(auth, (req, res, next) => {
  console.log('모든 요청은 처음ㅇ ㅔ 여기를 지나간다');
  next();
});

app.use('/', freeBoardRouter);
app.use('/', userRouter);
app.use('/', bookRouter);
app.use('/', memberRouter);

app.listen('5000', () => {
  console.log('서버 시작 했음');
});
