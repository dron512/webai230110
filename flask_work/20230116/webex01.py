from flask import Flask,render_template

# import aa
# from aa import AA
app = Flask(__name__)
# aaa = AA()
class MyData:
    aa = 10
    root = 5
    a = 10
    b = 20
    c = 30
    
mydata = MyData()

@app.route("/")
def index():
    return render_template('index.html',mydata=mydata)

@app.route("/aa")
def aa():
    return render_template('index.html',mydata=mydata)

app.run(debug=True)