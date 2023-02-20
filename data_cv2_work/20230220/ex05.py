import numpy as np

a = np.arange(4).reshape(-1,4)
b = np.arange(8).reshape(-1,4)

print(a)
print(b)
print()
c = np.concatenate([a,b],axis=0)
print(c)
print()
a = np.arange(4).reshape(-1,4)
b = np.arange(8).reshape(-1,4)

d = np.concatenate([a,b],axis=1)
print(d)