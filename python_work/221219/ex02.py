class AA:
    a = 10
    b = 20
    def doA(self):
        print('self.a = ',self.a)
        print('self.b = ',self.b)

a1=AA()
a1.doA()

a2=AA()
a2.doA()
print()
a1.a = 40
a1.doA()

a2.doA()