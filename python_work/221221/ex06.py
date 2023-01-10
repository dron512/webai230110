class AA:
    def notImple(self):
        raise NotImplementedError

try:
    a = AA()
    a.notImple()
except:
    pass

print("종료됩니다.")