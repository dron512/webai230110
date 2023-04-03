// node index.js index.js 실행해라
const express = require('express');
const cors = require('cors');
const mysql = require('mysql2');

const app = express();
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cors());

app.get('/', (req, res) => {
  res.send('root page');
});

app.get('/freeboard', (req, res) => {
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

app.post('/freeboard/insert', (req, res) => {
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

app.get('/book', (req, res) => {
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

app.listen('5000', () => {
  console.log('서버 시작 했음');
});
