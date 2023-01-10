a = [10,20,1,5,8]

total = 0
for item in a:
    total += item
print(f"total={total}")

import functools

result = functools.reduce(lambda total,item:total+item,a)
print(f"result={result}")