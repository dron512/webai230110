from flask import Blueprint

app = Blueprint('v2',__name__, url_prefix='/v2')

@app.route("insertform")
def insertform():
    return 'v2/insertform'

@app.route("insertproc")
def insertproc():
    return 'v2/insertproc'

@app.route("select")
def select():
    return 'v2/select'