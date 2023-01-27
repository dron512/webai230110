from flask import Blueprint,render_template
from components.db import freeboardmanage

app = Blueprint('freeboard',__name__, url_prefix='/freeboard')

@app.route("/select")
def select():
    res = freeboardmanage.select()
    print("select 됨",res)
    return render_template('freeboard/select.html',res=res)

@app.route("/insertform")
def insertform():
    return render_template('freeboard/insertform.html')