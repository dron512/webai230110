from selenium import webdriver
from bs4 import BeautifulSoup
import requests
import re
import time

driver = webdriver.Chrome()
url = 'https://www.binance.com/en/markets'

driver.get(url)
time.sleep(5)
driver.find_element('id','onetrust-accept-btn-handler').click()
time.sleep(5)
# req=requests.get(url)
# req.encoding='utf-8'

html = driver.page_source
# soup = BeautifulSoup(req.content,'html.parser')
soup = BeautifulSoup(html,'html.parser')
text = soup.find('div',{'class','css-74g683'})
print('coinname = ',text.text)
# print(soup.text)
# div = re.findall('<div>.*</div>',soup.text)
# print("".join(div))
# print(coinName)