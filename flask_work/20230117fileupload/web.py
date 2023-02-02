from flask import Flask,render_template,request
import pymysql
app = Flask(__name__)

@app.route("/")
def index():
    return render_template("index.html")

@app.route("/insertform")
def insertform():
    return render_template("insertform.html")

@app.route("/insertproc",methods=['GET','POST'])
def insertproc():
    title = request.form['title']
    desc = request.form['desc']
    f = request.files['bookimg']
    f.save(f'./static/img/{f.filename}')
    db = pymysql.connect(
        host='192.168.0.80',port=3306,
        user='student',password='student123',
        db='mhpark',charset='utf8'
    )
    cursor = db.cursor()
    sql = f"""INSERT into book (`title`,`desc`,`cata`) values (%s,%s,%s)"""
    param = (title, desc, f.filename)
    cursor.execute(sql,param)
    db.commit()
    db.close()
    return render_template("insertproc.html")

@app.route("/select")
def select():
    db = pymysql.connect(
        host='192.168.0.80',port=3306,
        user='student',password='student123',
        db='mhpark',charset='utf8'
    )
    cursor = db.cursor()
    sql = 'select * from book order by idx desc'
    cursor.execute(sql)
    res = cursor.fetchall()
    db.close()
    return render_template("select.html",res=res)

app.run(debug=True)