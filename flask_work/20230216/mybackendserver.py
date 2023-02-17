from flask import Flask
from flask_cors import CORS, cross_origin

app = Flask(__name__)
# CORS(app)

@app.route("/")
@cross_origin()
def index():
    return "index"

@app.route("/aa")
def aa():
    return "aa"

app.run(debug=True)