from student import Student

s1 = Student("홍길동",11,3)
s2 = Student("이길동",13,5)
s3 = Student("박길동",12,4)

list1 =[s1,s2,s3]

from operator import attrgetter

alist = sorted(list1,key=attrgetter('age'))
for item in alist:
    print(item)
