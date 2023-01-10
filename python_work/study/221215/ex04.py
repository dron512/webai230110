temp = {"aaaaa":10,"b":20,"ddd":30,"cc":40}
test = sorted(temp)

print(temp)
print(test)

test = sorted(temp.items())
print(test)

test = dict(test)
print(test)

test = sorted(temp.items(),key=lambda x :x[1])
print(test)

test = dict(test)
print(test)

test = sorted(temp.items(),key=lambda x :len(x[0]))
print(test)

test = dict(test)
print(test)