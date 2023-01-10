import urllib.request

myhome = "https://finance.naver.com/item/sise.naver?code=012450"

with urllib.request.urlopen(myhome) as s:
    data = s.read()
# print(data)

from bs4 import BeautifulSoup

html = BeautifulSoup(urllib.request.urlopen(myhome),"html.parser")
# print(html)

c = html.find('strong',{id,'_nowVal'})
print(c)
print(f"현재가 {c.text}")
c = html.find('span',{'class','tah p11'})
print(f"시가 {c.text}")
c = html.find_all('span',{'class','tah p11'})
print(f"저가 {c[1].text}")
print(f"고가 {c[2].text}")