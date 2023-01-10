from flask \
import Flask, render_template, request, redirect, url_for
import mhpapago
from cache import Cache


cache = Cache(config={'CACHE_TYPE': 'redis'})
app = Flask(__name__)

@app.route("/")
def index():
    filename=""
    if not filename:
        filename = 'ex_ko'
    filename = request.args.get('filename')
    return render_template("index.html",filename=f"static/{filename}.mp3")

@app.route("/make",methods=['GET','POST'])
def make():
    text = "안녕"
    if request.method =='POST':
        print(request.form['text'])
        text = request.form['text']
    filename = mhpapago.makePapago(text)
    print(filename,filename)
    return redirect(url_for(f'index',filename=filename))


app.run(debug=True)