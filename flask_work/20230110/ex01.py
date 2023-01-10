import os
import sys
import urllib.request
from gtts import gTTS
import json

client_id = "Q8IVqDA6ohay9KFVdCJq" # 개발자센터에서 발급받은 Client ID 값
client_secret = "mpTaigpW6I" # 개발자센터에서 발급받은 Client Secret 값
encText = urllib.parse.quote("안녕하세요 사람입니다.")
data = "source=ko&target=en&text=" + encText
url = "https://openapi.naver.com/v1/papago/n2mt"
request = urllib.request.Request(url)
request.add_header("X-Naver-Client-Id",client_id)
request.add_header("X-Naver-Client-Secret",client_secret)
response = urllib.request.urlopen(request, data=data.encode("utf-8"))
rescode = response.getcode()

if(rescode==200):
    response_body = response.read()
    # print(response_body.decode('utf-8'))
    result = response_body.decode('utf-8')
    result = json.loads(result)
    print(result['message']['result']['translatedText'])
else:
    print("Error Code:" + rescode)

tts = gTTS(
    text=f"{result['message']['result']['translatedText']}",
    lang='ko', slow=False
)
tts.save('ex_ko.mp3')