a = [1,5,3,4]
print(sorted(a))

b = ["gg","ddddd","aaaa","bbb","c","kkk"]
print(sorted(b))

print(sorted(b,key=lambda x:len(x)))