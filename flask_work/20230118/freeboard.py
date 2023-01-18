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
    print(pageNum)
    '''
        pageNum None
        pageNum 1
        pageNum 2
    '''
    if pageNum == None:
        pageNum = 1
    else:
        pageNum = int(pageNum)

    '''
    모르고 메시지 안남기고 커밋
        1 => 0   => (1-1)*3 =0
        2 => 3   => (2-1)*3 = 3
        3 => 6   => (3-1)*3 = 6
        4 => 9   => (4-1)*3 = 9
    '''
    connection = config.connect()
    cursor = connection.cursor()
    sql = f'select * from freeboard ORDER BY idx DESC LIMIT {((pageNum -1)*3)},3'
    cursor.execute(sql)
    res = cursor.fetchall()
    config.close(connection)
    return render_template(f'{prefix}/select.html',res=res)