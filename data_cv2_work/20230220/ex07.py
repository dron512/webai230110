import numpy as np

li = np.arange(8).reshape(-1,4)

left,right = np.split(li,[2],axis=0)

print(left.shape)
print(right.shape)

print(left)
print(right)

print(right[1][1])