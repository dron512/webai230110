import numpy as np

arr1 = np.array([1,2,3,4,5,6,7])
arr2 = np.array([10,11,12,13,14,15])

np.savez('b.npz',arr1=arr1,arr2=arr2)