class AA:
    def __init__(self):
        print("생성자")

    def doA(self,a):
        print(__name__)
        print("테스트")
        print('self',self)
        print('a',a)