from datetime import datetime
from flask import Flask,render_template,request, make_response, send_file
from functools import wraps, update_wrapper
from bs4 import BeautifulSoup
import requests
import time
from gtts import gTTS
import playsound
import multiprocessing
import os
from io import BytesIO, StringIO
import random
from itertools import count
import pandas as pd
import matplotlib.pyplot as plt
from matplotlib.animation import FuncAnimation
import matplotlib
import numpy as np
from datetime import datetime

matplotlib.use('Agg')

def nocache(view):
    @wraps(view)
    def no_cache(*args, **kwargs):
        response = make_response(view(*args, **kwargs))
        response.headers['Last-Modified'] = datetime.now()
        response.headers['Cache-Control'] = 'no-store, no-cache, must-revalidate, post-check=0, pre-check=0, max-age=0'
        response.headers['Pragma'] = 'no-cache'
        response.headers['Expires'] = '-1'
        return response
    return update_wrapper(no_cache, view)

app = Flask(__name__ )

@app.route("/")
def index():
    return render_template('index.html')

@app.route("/coin")
@nocache
def coin():
    global coinN 
    coinN = request.args.get('coinN')
    ascend = request.args.get('ascend')
    descend = request.args.get('descend')
    print(f'asc= {ascend}')
    print(f'desc= {descend}')
    print(f'coinN = {coinN}')
    ascend = float(ascend)
    descend = float(descend)
    floatAscend = ascend
    floatDescend = descend
    if (9999 > ascend > 10) :
        ascend = format(ascend, ',.2f')
    elif(ascend > 10000) :
        ascend = format(ascend, ',.0f')

    if (9999 > descend > 10) :
        descend = format(descend, ',.2f')
    elif(descend > 10000) :
        descend = format(descend, ',.0f')
    # 상하방선 소수점 자리수 끊기

    # ascend = format(ascend, ',f')
    # descend = format(descend, ',f')
    base_url = 'https://coinmarketcap.com/ko/currencies/'
    url = str(base_url) + str(coinN)
    print(url)
    req=requests.get(url)
    soup = BeautifulSoup(req.content,'html.parser')
    div = soup.find('div',{'class','sc-aef7b723-0 jfPVkR container'})
    coinName = div.select_one('.sc-1d5226ca-1.fLa-dNu')
    nowVal = div.select_one('.priceValue.smallerPrice')
    if nowVal == None : 
        nowVal=div.select_one('.priceValue')
    floatnowval = nowVal.text.replace(",","")
    floatnowval = floatnowval.replace("₩","")
    floatnowval = float(floatnowval)
    print(f'/coin floatnowval={floatnowval}')
    print(f'/coin coinN = {coinN}')
    return render_template('coin.html',floatnowval=floatnowval,coinName=coinName.text,nowVal=nowVal.text,ascend=ascend,descend=descend,floatAscend=floatAscend,floatDescend=floatDescend)

@app.route('/figbar/<floatnowval>')
@nocache
def figbar(floatnowval):
    print(f'/figbar floatnowval = {floatnowval}')
    # print(f'/figbar coinN = {coinN}')

    # base_url = 'https://coinmarketcap.com/ko/currencies/'
    # url = str(base_url) + str(coinN)
    # print(url)
    # req=requests.get(url)
    # soup = BeautifulSoup(req.content,'html.parser')
    # div = soup.find('div',{'class','sc-aef7b723-0 jfPVkR container'})
    # # coinName = div.select_one('.sc-1d5226ca-1.fLa-dNu')
    # nowVal = div.select_one('.priceValue.smallerPrice')
    # if nowVal == None : 
    #     nowVal=div.select_one('.priceValue')
    # strnowval = nowVal.text.replace(",","")
    # strnowval = floatnowval.replace("₩","")
    # floatnowval = float(strnowval)
    # print(f'figbar floatnowval = {floatnowval}')
    arrnowval = list(floatnowval.split(","))
    arrnowval = list(map(int,arrnowval))
    print(f'/figbar arrnowval = {arrnowval}')

    plt.figure(figsize=(8,3))
    xs = np.array([100,200,300,400,500,600,700,800])
    ys = np.array(arrnowval)
    y2 = np.array([90,90,90,90,90,90,90,90])
    y3 = np.array([10,10,10,10,10,10,10,10])
    plt.plot(xs,ys,marker='o')
    plt.plot(xs,y2)
    plt.plot(xs,y3)
    img=BytesIO()
    plt.savefig(img,format='png',dpi=300)
    img.seek(0)
    return send_file(img, mimetype='image/png')
 



if __name__ == '__main__':
    app.run(debug=True)

    # print(f"코인명 {coinName.text}")
    # print(f"현재가 {nowVal.text}")
    # print("-------------------------------------------------------")
    # # ascendingalert = float(input("상방알람 기준액 설정 : "))
    # # descendingalert = float(input("하방알람 기준액 설정 : "))

    # while 1:
    #     req=requests.get(url)
    #     soup = BeautifulSoup(req.content,'html.parser')
    #     div = soup.find('div',{'class','sc-aef7b723-0 jfPVkR container'})
    #     nowVal = div.select_one('.priceValue.smallerPrice')
    #     if nowVal == None : 
    #         nowVal=div.select_one('.priceValue')
    #     floatnowval=nowVal.text.replace(",","")
    #     floatnowval=floatnowval.replace("₩","")
    #     floatnowval=float(floatnowval)

    #     if floatnowval>=floatAscend :  
    #         ascper = (floatnowval - floatAscend)/floatAscend*100
    #         ascper = round(ascper,3)
    #         print(f"{coinName.text} 상방기준선 돌파 {ascper} % ↑ \n현재가 {nowVal.text}") 
    #         tts = gTTS(text=f"{coinName.text}\n상방선 대비 {ascper}퍼센트 상승",lang='ko')
    #         tts.save('ascending.mp3')
    #         time.sleep(0.2)
    #         playascbeep = multiprocessing.Process(target=playsound.playsound('ascendingbeep.mp3'))
    #         playasc = multiprocessing.Process(target=playsound.playsound('ascending.mp3'))
    #         os.remove('ascending.mp3')

    #     elif floatnowval<=floatDescend : 
    #         descper = (floatDescend - floatnowval)/floatDescend*100
    #         descper = round(descper,3)
    #         print(f"{coinName.text} 하방기준선 돌파 {descper} % ↓ \n현재가 {nowVal.text}")
    #         tts = gTTS(text=f"{coinName.text}\n하방선 대비 {descper}퍼센트 하락 ",lang='ko')
    #         tts.save('descending.mp3')
    #         time.sleep(0.2)
    #         playdescalert = multiprocessing.Process(target=playsound.playsound('descendingalert.mp3'))
    #         playdescalert = multiprocessing.Process(target=playsound.playsound('descendingalert.mp3'))
    #         playdesc = multiprocessing.Process(target=playsound.playsound('descending.mp3'))
    #         os.remove('descending.mp3')

    #     else : 
    #         print(f"{coinName.text} \n상방기준선 : ₩{floatAscend:,} (GAP : +{floatAscend-floatnowval:,})\n현재가 :     {nowVal.text}")
    #         print(f"하방기준선 : ₩{floatDescend:,} (GAP : -{floatnowval-floatDescend:,})")
    #         time.sleep(5)

    #     print()
    #     for i in range (1,5) :
    #         print(" "*(24-i) + "*"*(1+2*i-2))
    #         time.sleep(0.03)
    #     for i in range (1,4) :
    #         print(" "*(20+i) + "*"*((4-i)*2-1))
    #         time.sleep(0.03)
    #     print()


# def get_gamelist(self):
#     myquery = {"text":{"$redex":"^2"}}
#     gamelist = []
#     gamelist0 = self.collection.find(myquery).sort("text",pymongo.DESCENDING)
#     for list in gamelist0:
#         gamelist.append(list["text"])
#     return gamelist

# return render_template(
#     'index.html',
#     title='Admin Page'
#     year = datetime.now().year.
#     gamelist=repository.get_gamelist()
#     islogon=session.get('logged_in')
# )