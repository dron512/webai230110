import numpy as np

a = np.arange(16).reshape(-1,4)
b = a<10

print(a)
print(b)

print(a[b])

a[b] = 100
print(a)