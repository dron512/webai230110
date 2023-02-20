import numpy as np

array1 = np.arange(4)
array2 = np.zeros((4,4),dtype=float)
array3 = np.ones((3,3),dtype=str)

array4 = np.random.randint(0,10,(3,3))
array5 = np.random.normal(0,1,(3,3))

print(array1)
print(array2)
print(array3)
print(array4)
print(array5)