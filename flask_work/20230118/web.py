from flask import Flask,render_template
import freeboard
import fileboard

app = Flask(__name__)

app.register_blueprint(freeboard.app)
app.register_blueprint(fileboard.app)

@app.route("/")
def index():
    return render_template('index.html')

app.run(debug=True,port=9999)