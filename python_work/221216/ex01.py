'''
    두개의 정수를 입력받아서 최대 공약수를 구하는 프로그램을 작성해보자.
    12 6
    6
    14 8
    4
    20 5
    5
'''
num1 = input('정수 입력')
num2 = input('정수 입력')

print(num1)
print(num2)

num1 = eval(num1)
num2 = eval(num2)

sma = num2 if num1>num2 else num1
big = num2 if num1<num2 else num1
gcm = 1
# 12 6
# gc = 6
for i in range(1, sma+1):
    if sma % i ==0 and big%i ==0:
        print("공약수 ",i)
        gcm = i

text = f"최대 공약수는 {gcm} 입니다\n"

print(text) 

file1 = open("result.txt","a",encoding="UTF-8")
file1.write(text)
file1.close()

