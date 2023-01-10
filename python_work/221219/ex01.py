import sys

text = input ("실행종료?")

if text == '종료':
    sys.exit()

for ar in sys.argv:
    print(ar)