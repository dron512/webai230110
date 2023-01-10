import requests
from bs4 import BeautifulSoup

url = "https://dhlottery.co.kr/gameResult.do?method=byWin"

req = requests.get(url)
req.encoding = "utf-8"

html = BeautifulSoup(req.content,"html.parser")
print(html.find('span', {'class','ball_645 lrg ball1'} ).text)
print(html.find('span', {'class','ball_645 lrg ball2'} ).text)
print(html.find_all('span', {'class','ball_645 lrg ball4'} )[0].text)
print(html.find_all('span', {'class','ball_645 lrg ball4'} )[1].text)
print(html.find_all('span', {'class','ball_645 lrg ball5'} )[0].text)
print(html.find_all('span', {'class','ball_645 lrg ball5'} )[1].text)