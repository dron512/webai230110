from bs4 import BeautifulSoup
import urllib.request
myhome = "https://finance.naver.com/item/sise.naver?code=012450"

html = BeautifulSoup(urllib.request.urlopen(myhome),"html.parser")
nowval = html.find('strong',{id,'_nowVal'})
c = html.find_all('span',{'class','tah p11'})
print(f"현재가 {nowval.text}")
print(f"시가 {c[0].text}")
print(f"저가 {c[1].text}")
print(f"고가 {c[2].text}")