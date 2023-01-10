a = {'A':90,'B':80,'C':70}
result = a.pop('B')
print(a)
print(result)

a = [1,1,1,2,2,3,3,3,4,4,5]
aSet = set(a)
b = list(aSet)
print(b)

a = b = [1,2,3]
a[1] = 4
print(b)

a = [1,2,3]
b = a[:]
a[1] = 4
print(b)

import copy

a = [1,2,3]
b = a.copy()
a[1] = 4
print(b)

'''
    서두르지마라, 그러나 멈추지도 마라
    오늘만 살것처럼 ..? 영원히 살것처럼 공부해라..
'''