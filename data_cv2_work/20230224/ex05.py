import numpy as np

arr1 = np.array([1,9,2,3,5])
arr1.sort()
print(arr1)

arr2 = np.array([1,9,2,3,5])
arr2.sort()
print(arr2[::-1])

arr3 = np.array([[5,11,10,2,3],[4,1,10,22,3]])
arr3.sort(axis=0)
print(arr3)

arr4 = np.array([[5,11,10,2,3],[4,1,10,22,3]])
arr4.sort(axis=1)
print(arr4)