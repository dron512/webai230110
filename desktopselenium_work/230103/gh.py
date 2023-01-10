from selenium import webdriver
from bs4 import BeautifulSoup
from products import Product
from openpyxl import Workbook

inputvalue = '퓨마 운동화'

brow = webdriver.Chrome()   # 크롬브라우저 시작otepad
brow.get(f'https://www.coupang.com/np/search?q={inputvalue}&channel=user&component=&eventCategory=SRP&trcid=&traid=&sorter=scoreDesc&minPrice=&maxPrice=&priceRange=&filterType=&listSize=36&filter=&isPriceRange=false&brand=&offerCondition=&rating=0&page=2&rocketAll=false&searchIndexingToken=1=6&backgroundColor=')

html = brow.page_source # html 소스 가져오기
html = str(html).strip() # 공백제거
html = BeautifulSoup(html,'html.parser') #객체 변환

dl = html.find_all('dl',{'class','search-product-wrap'})
products = []
for idx,tag in enumerate(dl):
    img = tag.find('img')
    price = tag.find('strong',{'class','price-value'})
    name = img.get('alt')
    imgsrc = img.get('src')
    price = price.text
    products.append(Product(name,imgsrc,price,f'a{idx}'))

# print(products)

wb = Workbook()
ws = wb.active

ws.append(['name','price','상품이미지'])
for pro in products:
    ws.append([pro.name,pro.price,pro.imgsrc])

wb.save('coupang.xlsx')
wb.close()





