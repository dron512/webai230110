a = 10

def doA():
    global a
    a = a+1
    print(a)

doA()
print(a)