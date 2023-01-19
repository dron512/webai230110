from flask import Blueprint, render_template, request, redirect, url_for
import config

prefix = 'freeboard'

app = Blueprint(prefix,__name__, url_prefix=f'/{prefix}')

@app.route("insertform")
def insertform():
    return f'{prefix}/insertform'

@app.route("insertproc")
def insertproc():
    return f'{prefix}/insertproc'

@app.route("select")
def select():
    pageNum = request.args.get('pageNum')
    if pageNum == None:
        pageNum = 1
    else:
        pageNum = int(pageNum)
    connection = config.connect()
    cursor = connection.cursor()
    sql = f'select * from freeboard ORDER BY idx DESC LIMIT {((pageNum -1)*3)},3'
    cursor.execute(sql)
    res = cursor.fetchall()
    config.close(connection)

    connection = config.connect()
    cursor = connection.cursor()
    sql = f'select count(idx) from freeboard'
    cursor.execute(sql)
    res = cursor.fetchall()
    print('cnt = ',res[0])
    config.close(connection)

    return render_template(f'{prefix}/select.html',res=res)