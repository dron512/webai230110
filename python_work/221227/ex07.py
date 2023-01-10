import itertools

a = ["홍길동","이길동","박길동","김길동","짜장면"]
b = ["사탕","고구마","타임"]

for item in itertools.zip_longest(a,b,fillvalue="새우깡"):
    print(item)

c = list(itertools.zip_longest(a,b,fillvalue="공부"))
print(c)