'''
    길이가 10인 배열을 선언하고
    총 10개의 정수를 입력 받아서
    홀수와 짝수를 구분하는 프로그램을 작성해보자

    2 4 1 3 9 10
    짝수 2,4 10
    홀수 1 3 9
'''

list = []
holsu = []
jjaksu = []

for i in range(10):
    st = input(f"{i+1} 번째 입력 ")
    intst = int(st)
    list.append(intst)
    if intst%2 ==0:
        jjaksu.append(intst)
    else:
        holsu.append(intst)
print(f"홀수 {holsu}")
print(f"짝수 {jjaksu}")

holsu = [ int(item) for item in list if int(item)%2==1]
print(f"홀수 {holsu}")
jjaksu = [ int(item) for item in list if int(item)%2==0]
print(f"짝수 {jjaksu}")