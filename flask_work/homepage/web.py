from flask import Flask,render_template,request
from components import freeboard
from components import fileboard
from sklearn.linear_model import LinearRegression

app = Flask(__name__)

app.register_blueprint(freeboard.app)
app.register_blueprint(fileboard.app)

@app.route("/")
def index():
    x = request.args.get('x')
    y = '예측되는숫자를 넣으셔야 합니다.'
    xs = [[28],[29],[30],[31],[32]]
    ys = [200,220,240,260,280]
    print('x = ',x)
    if x :
        knr = LinearRegression()
        knr.fit(xs,ys)
        y = knr.predict([[float(x)]])
    return render_template('index.html',y=y,xs=xs,ys=ys)

app.run(debug=True)