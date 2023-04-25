const express = require('express');
const path = require('path');
const morgan = require('morgan');   // 사용자로 아직...
const nunjucks = require('nunjucks');   //rendertemplate
const {sequelize} = require('./models');
require('dotenv').config();

const app = express();

app.set("port",process.env.port || 3001);
app.set('view engine','html');

nunjucks.configure('views',{
    express:app,
    watch: true
})

sequelize.sync({force:true})
.then(()=>{
    console.log("데이터베이스 생성");
}).catch((e)=>{
    console.log(e);
});

app.get("/",(req,res)=>{
    res.render("index");
})

app.get("/users",(req,res)=>{
    res.render("users");
})

app.listen(app.get('port'),()=>{
    console.log(app.get('port'),'번 실행됨');
})


// console.log(process.env.PORT);
// console.log(process.env.a);
// console.log(process.env.c);
// console.log("localhost");