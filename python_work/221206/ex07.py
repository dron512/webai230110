a = "20010331Rainy"

year = a[:4]
month = a[4:6]
date = a[6:8]
weather = a[8:]

print(year)
print(month)
print(date)

print(weather)

today = year+'년'+month+'월'+date+'일'+weather

print(today)