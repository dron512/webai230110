a = [1,2,3,['a','b','c']]

print(a[-1])
print(a[-1][0])
print(a[-1][-1])

a[-1] = ['d','e','f']
print(a)
print(a[-1])

b ="abcdef"
b[0]="k"