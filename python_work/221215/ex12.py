doA = lambda a : a*a

test = doA(10)
print(test)

test = lambda a,b : a*b
print(test(10,20))

print((lambda a,b,c: a+b+c)(3,4,5))

test = filter(lambda x : x%2==0,[1,2,3,4,5,6,7,8,9,10])
print(list(test))

test = map(lambda x : x*2,[1,2,3,4,5,6,7,8,9,10])
print(list(test))