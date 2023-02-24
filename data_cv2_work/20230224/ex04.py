import numpy as np

arr1 = np.load('b.npz')['arr1']
arr2 = np.load('b.npz')['arr2']

print(arr1)
print(arr2)

result = np.load('b.npz')
print(result['arr1'])
print(result['arr2'])