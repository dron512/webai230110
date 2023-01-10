from bs4 import BeautifulSoup
from selenium import webdriver
from selenium.webdriver.common.by import By
import time
import pyautogui

# inputvalue = pyautogui.prompt('월납입료를 입력하세요.')
# print(inputvalue)

url="https://www.nps.or.kr/jsppage/app/etc/simpleExpect.jsp?yyyy=2022&status=cal&max=471600&min=29700&insu=300000&inquiry=%BF%B9%BB%F3%BF%AC%B1%DD%BE%D7+%C1%B6%C8%B8%C7%CF%B1%E2"

brow = webdriver.Chrome()   # 크롬브라우저 시작otepad
brow.get(url)  # www.naver.com 네이버 홈페이지 호출
brow.save_screenshot('yun.jpg')
time.sleep(3)
# html = brow.page_source

# html = BeautifulSoup(html,"html.parser")
# andong = html.find('dl',{'class','po_136'})
# print(andong.find('span'))
# daegu = html.find('dl',{'class','po_143'})
# print(daegu.find('span'))