class Calculater:
    result = 0

    def __init__(self,name):
        print(self.result)
        self.name = name


    def add(self,num):
        self.result +=num
        return self.result