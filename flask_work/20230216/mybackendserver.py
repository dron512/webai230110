from flask import Flask
from flask_cors import CORS, cross_origin
import pymysql

host='192.168.0.80'
port=3306
user='student'
password='student123'
dbname='mhpark'
charset='utf8'

app = Flask(__name__)
CORS(app)

@app.route("/")
# @cross_origin()
def index():
    db = pymysql.connect(
        host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f'select * from freeboard limit 0,1'
    cursor = db.cursor()
    cursor.execute(sql)
    res = cursor.fetchone()
    print(res)
    db.close()
    return str(res)

@app.route("/aa")
def aa():
    return "aa"

@app.route("getimg")
def getimg():
    

app.run(debug=True)