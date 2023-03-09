const express = require('express');
const getConnection = require('./config/db_config.js');
const cors = require('cors');

const app = express();
app.use( cors( { origin:"*"} ) );

app.get("/",(req,res)=>{   res.send("/ 왔음"); })

app.get("/days",function(req,res){
    getConnection((conn)=>{
        const sql = "select * from days";
        conn.query(sql,function(err,rows,fields){
            if(err)
                console.error('error ',err);
            res.send(rows);
        });
        console.log("연결성공");
        conn.release();
    });
})

app.get("/words/:day",function(req,res){
    getConnection((conn)=>{
        const sql = "select * from words where day = ?";
        conn.query(sql,[req.params.day],function(err,rows,fields){
            if(err)
                console.error('error ',err);
            res.send(rows);
        });
        console.log("연결성공");
        conn.release();
    });
})

app.listen(5000,()=>{ console.log('5000 서버 시작'); })
