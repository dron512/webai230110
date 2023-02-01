from flask import Flask
import pymysql

app = Flask(__name__)

@app.route("/")
def index():
    return "index"

@app.route("/insert")
def insert():
    db = pymysql.connect(host="192.168.0.80",port=3306,
                    user="student",password="student123",db='mhpark',charset='utf8')
    cursor = db.cursor()
    sql = """INSERT INTO
            TB_A
            VALUES
            (10,20,'내용');"""
    cursor.execute(sql)
    db.commit()
    db.close()
    return "insert"    

@app.route("/select")
def select():
    db = pymysql.connect(host="192.168.0.80",port=3306,
                    user="student",password="student123",db='mhpark',charset='utf8')
    cursor = db.cursor()
    sql = """select * from tb_a"""
    cursor.execute(sql)
    res = cursor.fetchall()
    print(res)
    db.close()
    return "select"

app.run(debug=True)