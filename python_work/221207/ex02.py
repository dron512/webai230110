a = "hobby"

cnt = a.count("b")
print(cnt)

b = "python is best choice"

try:
    n1 = b.index('b')
    print(n1)
    n1 = b.index('k')
    print(n1)
except Exception as e:
    pass

n1 = b.find('b')
print(n1)
n1 = b.find('k')
print(n1)


