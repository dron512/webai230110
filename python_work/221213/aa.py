class PA:
    def __init__(self):
        print("부모")

class AA(PA):
    def __init__(self):
        super.__init__()
        a = 10
        print("클래스 생성시 호출")
        self.doA()

    def doA(self):
        a = 10
        print("DoA")


a = AA()
