a = [(1,2),(3,4),(5,6)]

for item in a:
    print(item)
print()

for item1,item2 in a:
    print(item1+item2)
print()

for num1,num2 in zip([1,2,3,4],[5,6,7,8]):
    print(num1,num2)
print()

for num1,num2 in zip(range(1,4),range(3,6)):
    print(num1,num2)
print()

for inx,item in enumerate(range(3,5)):
    print(inx,item)