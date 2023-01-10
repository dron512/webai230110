from selenium import webdriver
from bs4 import BeautifulSoup
# from fortune2 import Fortune
from openpyxl import Workbook
import requests


inputvalue = '오늘의 운세'


# brow = webdriver.Chrome()
# brow.get(f'https://fortune.nate.com/contents/freeunse/freeunseframe.nate?freeUnseId=today03')
req = requests.get('https://fortune.nate.com/contents/freeunse/freeunseframe.nate?freeUnseId=today03')
req = requests.get('https://fortune.nate.com/contents/freeunse/dayjiji.nate?jijiPage=0')
req.encoding="EUC-KR"

html = req.text
# html = str(html).strip()
html = BeautifulSoup(html,'html.parser')
fo = html.find_all('div',{'class','wrap f_clear'})
print(fo)
# fortune2 = []
# for idx,tag in enumerate(fo):
#     img = tag.find('img')
#     #let = tag.select_one(".year_boxrhemdgkg")
#     let = tag.find('div',{'class','conFortune'})
#     name = img.get('alt')
#     imgsrc = img.get('src')
#     let = let.text
#     print(name,let,imgsrc)
#     fortune2.append(Fortune(name,imgsrc,let,f'a{idx}'))

# wb = Workbook()
# ws = wb.active

# ws.append(['name','let','이미지'])
# for pro in fortune2:
#     ws.append([pro.name,pro.let,pro.imgsrc])

# wb.save('fortune.xlsx')
# wb.close()