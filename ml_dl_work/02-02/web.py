from flask import Flask,render_template, send_file, request, jsonify
import numpy as np
import matplotlib
matplotlib.use('Agg')
import matplotlib.pyplot as plt
from io import BytesIO, StringIO
import dusrma
from sklearn.neighbors import KNeighborsClassifier

fish_length = [25.4, 26.3, 26.5, 29.0, 29.0, 29.7, 29.7, 30.0, 30.0, 30.7, 31.0, 31.0, 
                31.5, 32.0, 32.0, 32.0, 33.0, 33.0, 33.5, 33.5, 34.0, 34.0, 34.5, 35.0, 
                35.0, 35.0, 35.0, 36.0, 36.0, 37.0, 38.5, 38.5, 39.5, 41.0, 41.0, 9.8, 
                10.5, 10.6, 11.0, 11.2, 11.3, 11.8, 11.8, 12.0, 12.2, 12.4, 13.0, 14.3, 15.0]
fish_weight = [242.0, 290.0, 340.0, 363.0, 430.0, 450.0, 500.0, 390.0, 450.0, 500.0, 475.0, 500.0, 
                500.0, 340.0, 600.0, 600.0, 700.0, 700.0, 610.0, 650.0, 575.0, 685.0, 620.0, 680.0, 
                700.0, 725.0, 720.0, 714.0, 850.0, 1000.0, 920.0, 955.0, 925.0, 975.0, 950.0, 6.7, 
                7.5, 7.0, 9.7, 9.8, 8.7, 10.0, 9.9, 9.8, 12.2, 13.4, 12.2, 19.7, 19.9]

fish_data = np.column_stack((fish_length,fish_weight))
knr = KNeighborsClassifier()
knr.fit(fish_data,['bream']*35+['smelt']*14)

app = Flask(__name__)

@app.route("/")
def index():
    return render_template('index.html')

@app.route("/predict")
def predict():
    length = request.args.get('length')
    weight = request.args.get('weight')
    result = knr.predict([[int(length),int(weight)]])
    return jsonify({"race":result[0]})

@app.route("/dusrma")
def fndusrma():
    insu = request.args.get("insu")
    if insu is None or insu == "":
        insu = 10000 
    else:
        insu = int(insu)
    result = dusrma.dusrma(insu)
    return render_template('dusrma.html',result=result)

@app.route("/fig/int<length>_int<weight>")
def fig(length,weight):
    plt.scatter(fish_length,fish_weight)
    plt.scatter(int(length),int(weight))
    plt.xlabel('length')
    plt.ylabel('weight')
    
    img = BytesIO()
    # plt.savefig('a.png')
    plt.savefig(img,format='png')
    img.seek(0)
    plt.close()
    return send_file(img,mimetype='image/png')

app.run(debug=True)