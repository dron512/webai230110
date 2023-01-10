from ccalu import CCalculator

cal1 = CCalculator(10,0)
# cal1.setData(10,20)

print(cal1.first)
print(cal1.secound)

print(cal1.add())
print(cal1.sub())
print(cal1.mul())
print(cal1.div())
print()
cal1.setData(30,16)
print(cal1.mul())

mod = cal1.mod()

print(f"\n mod = {mod} ")