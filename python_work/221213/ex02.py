a = [1,2,3,4,4,4]
print(a)

a = set(a)
print(a)

# a = int(list(a)[0])
# print(a)
a = str(a)
print(a)
a = list(a)
print(a)
a = tuple(a)
print(a)
# a = dict(a)
# print(a)

a = ("11","bb")
b = ("22","cc")

c = dict([a,b])
print(c)

'''
    int() 숫자형태로 변환
    str() 문자열형태로 변환
    list() 리스트형태로 변환
    tuple() 튜플형태로 변환
    dict() 딕셔너리 형태로 변환
    set() 집항형태로 변환
    bool() True False 변환
'''