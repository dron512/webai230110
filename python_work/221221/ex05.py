
try:
    f = open('a.txt','w')
    print(111)
    f.write('글자쓰자')
    print(222)
    f.close()
    print(333)

    # 4/0
    # print(444)

    a = [1,2,3]
    a[4] = 8

    print(555)
except FileNotFoundError as fnf:
    print(fnf)
except ZeroDivisionError as zde:
    print("0으로 나눌수 없습니다.")
except:
    print("에러처리")
finally:
    f.close()
    print("여기는 무조건 온다..")


print('종료됩니다.')