def doA(a):
    print(a)
    print("doA함수호출")

def doB():
    print("doB함수호출")
    return 10

def doC(a,b):
    print("doC함수호출")
    return a+b

def doD(a):
    print("doD함수호출")
    return len(a)