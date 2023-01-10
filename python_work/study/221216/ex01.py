from flask import Flask,render_template

app = Flask(__name__)

@app.route("/")
def index():
    mylist = ['aa','bb']
    return render_template("index.html")

app.run(debug=True)