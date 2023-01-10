from selenium import webdriver
from selenium.webdriver.common.by import By
from bs4 import BeautifulSoup
import requests
import re
import time

driver = webdriver.Chrome()
url = 'http://rt.molit.go.kr/'

driver.get(url)
time.sleep(5)
main = driver.window_handles
for handle in main:
    if handle != main[0]:
        driver.switch_to.window(handle)
        driver.close()

print(driver.window_handles[0])
driver.switch_to.window(driver.window_handles[0])
driver.switch_to.default_content()
print(driver.page_source)
time.sleep(5)        
# driver.find_element(By.CLASS_NAME,'apart_t').click()
# time.sleep(2)
# driver.find_element(By.XPATH,'//*[@id="sidoCode"]/option[4]').click();

# driver.find_element('id','sidoCode').click()
# time.sleep(5)

# html = driver.page_source
# soup = BeautifulSoup(req.content,'html.parser')
# soup = BeautifulSoup(html,'html.parser')
# text = soup.find('div',{'class','css-74g683'})
# print('coinname = ',text.text)
# print(soup.text)
# div = re.findall('<div>.*</div>',soup.text)
# print("".join(div))
# print(coinName)