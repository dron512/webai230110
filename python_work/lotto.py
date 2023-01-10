import requests
from bs4 import BeautifulSoup
from openpyxl import Workbook

url = "https://dhlottery.co.kr/gameResult.do?method=byWin"

req = requests.get(url)
req.encoding = "utf-8"

html = BeautifulSoup(req.content,"html.parser")
num1 = html.find('span', {'class','ball_645 lrg ball1'} ).text
num2 = html.find('span', {'class','ball_645 lrg ball2'} ).text
num3 = html.find_all('span', {'class','ball_645 lrg ball4'} )[0].text
num4 = html.find_all('span', {'class','ball_645 lrg ball4'} )[1].text
num5 = html.find_all('span', {'class','ball_645 lrg ball5'} )[0].text
num6 = html.find_all('span', {'class','ball_645 lrg ball5'} )[1].text

wb = Workbook()
ws = wb.active

ws.append(["로또번호"])
ws.append(["번호1","번호2","번호3","번호4","번호5","번호6"])
ws.append([num1,num2,num3,num4,num5,num6])

wb.save('lotto.xlsx')
wb.close()
