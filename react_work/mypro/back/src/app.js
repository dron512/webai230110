
"use strict";

// node index.js index.js 실행해라
const express = require('express');
const cors = require('cors');

const app = express();

const freeBoardRouter = require("./routes/freeboard");
const userRouter = require("./routes/user");
const bookRouter = require("./routes/book");
const memberRouter = require("./routes/member");

// UserSequlize 객체 생성을 하는데...
// Constructor 의 내용을 실행합니다.
// const userSequlize = require("./models/users");

// userSequlize.createUser('김','길동',"aaa@naver.com");
// userSequlize.createUser('이','길동',"bbb@naver.com");
// userSequlize.createUser('박','길동',"ccc@naver.com");



app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cors());

app.use("/", freeBoardRouter);
app.use("/", userRouter);
app.use("/", bookRouter);
app.use("/", memberRouter);

app.listen('5000', () => {
  console.log('서버 시작 했음');
});
