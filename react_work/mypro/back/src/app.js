
"use strict";

// node index.js index.js 실행해라
const express = require('express');
const cors = require('cors');

const app = express();

const freeBoardRouter = require("./routes/freeboard");
const bookRouter = require("./routes/book");
const memberRouter = require("./routes/member");

app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cors());

app.use("/", freeBoardRouter);
app.use("/", bookRouter);
app.use("/", memberRouter);

app.listen('5000', () => {
  console.log('서버 시작 했음');
});
