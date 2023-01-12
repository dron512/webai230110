from flask \
import Flask, render_template, request, redirect, url_for
import mhpapago
import dbmanager

app = Flask(__name__)

@app.route("/")
def index():
    filename = request.args.get('filename')
    print(f'filename ={filename}')
    if not filename :
        filename='ex_ko'
    print(f'filename ={filename}')
    return render_template("index.html",filename=f"static/{filename}.mp3")

@app.route("/make",methods=['GET','POST'])
def make():
    ko = "안녕"
    if request.method =='POST':
        ko = request.form['text']
    print(f'text ={ko}')
    en,filename = mhpapago.makePapago(ko)
    dbmanager.saveFiles(ko,en,filename)
    return redirect(url_for(f'index',filename=filename))


app.run(debug=True)