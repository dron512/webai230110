def doA(x):
    return x*3

doB = lambda x:x*3

a = list (map( doA ,[1,2,3,4]))
print(a)
print()
a = list (map( doB ,[1,2,3,4]))
print(a)