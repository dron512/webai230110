from flask import Flask, render_template, request

app = Flask(__name__)

test = 1
@app.route("/")
def index():
    global test
    print(request.args.get('first'))
    print(request.args.get('second'))
    a = request.args.get('first')
    b = request.args.get('second')
    c = 0
    d = 0
    e = 0
    f = 0
    g = 0
    if a is not None and b is not None:
        c = int(a)+int(b) 
        d = int(a)-int(b) if a > b  else int(b)-int(a)
        e = int(a)*int(b)
        f = int(a)//int(b)
        g = int(a)%int(b)
    test +=1
    return render_template('index.html',c=c,d=d,e=e,f=f,g=g,test=test)


@app.route("/random")
def random():
    import random
    a = random.randint(1,100)
    return render_template('random.html',a=a)
app.run(debug=True)
