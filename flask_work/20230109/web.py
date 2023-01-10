from flask import Flask,render_template
import dbmanager

app = Flask(__name__)

@app.route("/")
def index():
    res = dbmanager.selectTest1()
    print(res)
    return render_template("index.html",res=res)


app.run(debug=True)