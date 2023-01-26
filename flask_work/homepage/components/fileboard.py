from flask import Blueprint,render_template

app = Blueprint('fileboard',__name__, url_prefix='/fileboard')

@app.route("/select")
def select():
    return  render_template('fileboard/select.html')