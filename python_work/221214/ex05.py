'''
    구구단 
    2*2 2*4 2*6 2*8
    4*2 4*4 4*6 4*8
    6*2 6*4 6*6 6*8
    for 구문
    i y
    i가 2일때 y는 2,4,6,8
    i가 4일때 y는 2,4,6,8
    i가 6일때 y는 2,4,6,8
'''

for i in range(2,7,2):
    for j in range(2,9,2):
        print(f"{i}*{j}={i*j}",end=" ")
    print(end="\n")
