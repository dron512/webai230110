class A:
    def __init__(self):
        print("생성자")
    def __str__(self):
        return "클래스에 내용요약"

a = A()
print(a)