const mysql = require('mysql2');
const config = require('./db_config.json');

let pool = mysql.createPool(config);

const getConnection = (callback)=>{
    pool.getConnection((err,conn)=>{
        if(!err){
            callback(conn);
        }
    });
}


module.exports = getConnection