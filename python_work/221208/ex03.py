import sys

option = sys.argv[1]
memo = sys.argv[2]

if option =='-a':
    print("option is a")
    # a 추가하기 w 쓰기 r 읽기
    f = open("memo.txt",'a')
    f.write(memo)
    f.write("\n")
    f.close()
else:
    f = open("memo.txt",'r')
    memo = f.read()
    f.close()
    print(memo)

