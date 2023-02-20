import numpy as np

li = [1,2,3]+[4,5,6]
print(li)

nli = np.array([1,2,3])+np.array([4,5,6])
print(nli)

a = np.array([1,2,3])
b = np.array([4,5,6])

c = np.concatenate([a,b])
print(c)
print(c.shape)

print(type(li))
print(type(c))