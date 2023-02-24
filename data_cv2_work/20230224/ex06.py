import numpy as np

arr1 = np.linspace(0,10,5)
print(arr1)

# np.random.seed(42)
print(np.random.randint(0,10,(2,3)))

arr1 = np.arange(0,10)
arr2 = arr1.reshape(-1,2)
arr1 = np.array([1,2,3])
print(arr1)
print(arr2)

arr1 = np.arange(0,10)
arr2 = arr1.copy()
arr1 = np.array([1,2,3])
print(arr1)
print(arr2)

# np.array([1,1,2])