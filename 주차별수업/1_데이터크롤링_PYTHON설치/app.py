from flask import Flask, render_template, request
import os
import dusrma as ds


app = Flask(__name__,template_folder="templates")


@app.route("/", methods=['POST','GET'])
def dusrma():
    insu = 90000
    if request.method == 'POST':
        insu = request.form['won']
    result = ds.dusrma(insu)
    return render_template("hello.html",result=result)


if __name__ == '__main__':
    app.run(debug=True)