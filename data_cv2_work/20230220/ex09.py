import numpy as np

a1 = np.arange(0,8).reshape(2,4)
a2 = np.arange(0,8).reshape(2,4)

a3 = np.concatenate([a1,a2],axis=0)
a4 = np.arange(0,4).reshape(4,1)

print(a3)
print(a4)

print(a3+a4)