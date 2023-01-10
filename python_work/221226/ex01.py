class A:
    pass
class B:
    pass

a = A()
b = B()

print( 'a.isinstance(A)',isinstance(a,A))
print( 'a.isinstance(B)',isinstance(a,B))

print( 'b.isinstance(A)',isinstance(b,A))
print( 'b.isinstance(B)',isinstance(b,B))

if isinstance(a,A):
    print("a는 A 입니다")

if isinstance(b,B):
    print("b는 B 입니다.")