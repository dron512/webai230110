import requests
from bs4 import BeautifulSoup

try:
    inputvalue='퓨마 운동화'
    print('00')
    html = requests.get(f'https://www.coupang.com/np/search?q=%ED%93%A8%EB%A7%88%EC%9A%B4%EB%8F%99%ED%99%94&channel=user')
    print('11')
    html.encoding='utf-8'
    print('22')
    html = BeautifulSoup(html.content,'html.parser')
    print(html)
except Exception as e:
    print(e)

