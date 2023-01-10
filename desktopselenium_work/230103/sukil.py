from bs4 import BeautifulSoup
from selenium import webdriver
import time

url="https://www.weather.go.kr/w/index.do"

brow = webdriver.Chrome()   # 크롬브라우저 시작otepad
brow.get(url)  # www.naver.com 네이버 홈페이지 호출
time.sleep(3)
html = brow.page_source

html = BeautifulSoup(html,"html.parser")
andong = html.find('dl',{'class','po_136'})
print(andong.find('span'))
daegu = html.find('dl',{'class','po_143'})
print(daegu.find('span'))