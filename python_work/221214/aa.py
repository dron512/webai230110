aa = 10

def doA():
    money = True
    if money:
        print("택시타라")
    else:
        print("걸어가라")

def doB():
    a = [1,2,3]
    if 1 in a:
        print("1은 a에 포함된다")
    if 4 not in a:
        print("4는 a에 포함 안된다")

def doC():
    a = False
    if a:
        pass
    else:
        print("테스트")

def doD():
    a = 20
    b = 10
    c = "a가 큼" if a>b else "a가 작음"
    print(c)
    d = [1,2,3] if a>b else [4,5,6]
    print(d)