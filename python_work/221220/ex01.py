def sfunc(num):
    num = 30
    print("num =",num)
    return "num"

def main():
    age = 20
    age = sfunc(age)
    print("age = ",age)

if __name__ == "__main__":
    main()