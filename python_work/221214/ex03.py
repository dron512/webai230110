'''
    계속 반복이 되도록..
        입력받은 숫자에 대한...
        while 구문으로 구구단을 출력하자
'''
info = '''
    구구단 몇단 출력할래?
    종료하실려면 음수를 입력하세요.
'''
while True:
    print(info)
    gugudan = input()
    gugudan = float(gugudan)+0.1
    if gugudan < 0:
        print("종료됩니다.")
        break
    elif gugudan ==0:
        print("0단은 보여줄수 없습니다.")
    else:
        a = 1
        while(a < 10):
            print("%.2f * %d = %d"%(gugudan,a,gugudan*a))
            print(f"{gugudan} * {a} = {gugudan*a}")
            a += 1