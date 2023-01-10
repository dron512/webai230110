class Calculator:
    first = 10
    secound = 20
    def __init__(self,fi,se):
        self.first=fi
        self.secound = se

    def setData(self,fi,se):
        self.first=fi
        self.secound = se

    def add(self):
        return self.first + self.secound

    def sub(self):
        return self.first - self.secound

    def mul(self):
        return self.first * self.secound
    
    def div(self):
        return self.first / self.secound