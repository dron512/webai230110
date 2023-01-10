def add_mul(ccc,*aaa):
    if ccc=="add":
        result = 0
        for item in aaa:
            result +=item
    elif ccc=="mul":
        result = 1
        for item in aaa:
            result *=item
    return result

print(add_mul("add",1,2,3,4,5))
print(add_mul("mul",1,2,3,4,5))
