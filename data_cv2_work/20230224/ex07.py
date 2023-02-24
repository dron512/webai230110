import qrcode

img = qrcode.make('42 19 20 33 2 6')
img.save('a.png')

img = qrcode.make('http://www.naver.com')
img.save('b.png')