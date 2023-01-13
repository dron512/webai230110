from flask import Flask,render_template,request
import random
app = Flask(__name__)

win = 0
lose = 0
draw = 0

@app.route("/")
def index():
    return render_template('index.html')

@app.route("/game")
def game():
    global win,lose,draw
    com = random.randint(0,3) #0 가위 1바위 2보
    if request.args.get('game') is not None:
        if request.args.get('game') == '가위':
            if com == 0:
                draw +=1
            elif com ==1:
                lose +=1
            else:
                win +=1
        elif request.args.get('game') == '리셋':
            win,draw,lose = 0,0,0
    return render_template('index.html',win=win,lose=lose,draw=draw)
app.run(debug=True)