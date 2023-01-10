"""
1. 14를 3으로 나누었을때 몫과 나머지를 확인해보자
2.'you need python' 문장을 문자열로 만들고 길이를 확인해보자
3. 홍길동씨의 과목별 점수는 다음과 같다.
홍길동씨의 평균 점수를 구해보자
국어 80 영어 75 수학 55
4. 홍길동 씨의 주민등록번호는 881120-1068234이다. 
홍길동 씨의 주민등록번호를 연월일(YYYYMMDD) 
부분과 그 뒤의 숫자 부분으로 나누어 출력해보자.
(문자열 슬라이싱 기법 사용)
hongCode="881120-1068234"
5. 주민등록번호 뒷자리의 맨 첫 번째 숫자는 성별을 나타낸다. 
주민등록번호에서 성별을 나타내는 숫자를 출력해보자(문자열 인덱싱 사용)
pin = "881120-1068234"
"""
print('몫',14//3)
print('나머지',14%3)

st = "you need python"
print(len(st))

kor=50
eng=75
math=55
result = '(%d + %d + %d)/3 = %d'%(kor,eng,math,(kor+eng+math) / 3)
result1 = f'({kor} + {eng} + {math})/3 = {(kor+eng+math) / 3}'
print( '평균점수 = ',(kor+eng+math) / 3)
print(result)
print(result1)

# 정보처리기사 빅데이터분석기사 정보보안기사
hongCode="881120-1068234"

# 뒤로가기 ctrl + z 
# 앞으로 가기 ctrl + y
# 한줄삭제 shift + delete
print('19'+hongCode[:6])
print(hongCode[7:])

print(hongCode[7])