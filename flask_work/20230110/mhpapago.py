import os
import sys
import urllib.request
from gtts import gTTS
from playsound import playsound
import json
from faker  import Faker

def makePapago(text):
    faker = Faker()
    name = faker.name().replace(" ","")
    client_id = "O8au87yavMgyra8zcqJ9" # 개발자센터에서 발급받은 Client ID 값
    client_secret = "IUpn0_gEIg" # 개발자센터에서 발급받은 Client Secret 값
    encText = urllib.parse.quote(text)
    data = "source=ko&target=en&text=" + encText
    url = "https://openapi.naver.com/v1/papago/n2mt"
    request = urllib.request.Request(url)
    request.add_header("X-Naver-Client-Id",client_id)
    request.add_header("X-Naver-Client-Secret",client_secret)
    response = urllib.request.urlopen(request, data=data.encode("utf-8"))
    rescode = response.getcode()
    if(rescode==200):
        response_body = response.read()
        res = response_body.decode('utf-8')
        res = json.loads(res)
        en = res['message']['result']['translatedText']
        print(f"en = {en}")
    else:
        print("Error Code:" + rescode)

    tts = gTTS(text=en,lang='ko',slow=True)
    tts.save(f'20230110/static/{name}.mp3')
    import time
    time.sleep(1)
    return en,name