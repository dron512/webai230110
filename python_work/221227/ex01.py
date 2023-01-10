import datetime

day1 = datetime.date(2019,12,14)
day2 = datetime.date(2022,12,27)

print(day2 - day1)

# import ex02
# ex02.doA()

from ex02 import doA
doA()

print(day1.isoweekday())
print(day2.isoweekday())
