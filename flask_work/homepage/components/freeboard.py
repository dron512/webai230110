from flask import Blueprint, render_template, request, redirect
from components.db import freeboardmanage

app = Blueprint('freeboard',__name__, url_prefix='/freeboard')

@app.route("view")
def view():
    idx = int(request.args.get('idx'))
    res = freeboardmanage.selectRow(idx)
    print("select row 됨",res)
    return render_template('freeboard/view.html',res=res)

@app.route("/select")
def select():
    page = request.args.get('page')
    page = 1 if page is None else page
    res = freeboardmanage.select(int(page))
    return render_template('freeboard/select.html',res=res)

@app.route("/updateform")
def updateform():
    idx = request.args.get('idx')
    res = freeboardmanage.selectRow(idx)
    return render_template('freeboard/updateform.html',res=res)

@app.route("updateproc", methods=['POST'])
def updateproc():
    title = request.form['title']
    content = request.form['content']
    writer = request.form['writer']
    idx = request.form['idx']
    freeboardmanage.update(title,content,writer,idx)
    return redirect('/freeboard/select')



@app.route("/insertform")
def insertform():
    return render_template('freeboard/insertform.html')

@app.route("insertproc", methods=['POST'])
def insertproc():
    title = request.form['title']
    content = request.form['content']
    writer = request.form['writer']
    freeboardmanage.insert(title,content,writer)
    return redirect('/freeboard/select')

@app.route("delete")
def delete():
    idx = int(request.args.get('idx'))
    freeboardmanage.delete(idx)
    return redirect('/freeboard/select')