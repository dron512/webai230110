// node index.js index.js 실행해라
const express = require('express');
const cors = require('cors');

const app = express();
app.use(cors());

app.get('/', (req, res) => {
    res.send('root page');
});

app.get('/book', (req, res) => {
    res.send([
        {
            bk_name: '파이썬',
            bk_company: '대구출판사',
            bk_price: 50000,
        },
        {
            bk_name: 'JAVA',
            bk_company: '서울출판사',
            bk_price: 40000,
        },
    ]);
});

app.listen('5000', () => {
    console.log('서버 시작 했음');
});
