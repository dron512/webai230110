import numpy as np

# np.random.seed(42)
test = np.random.randint(1,10,4).reshape(-1,2)
print(test)

test = test*10
print(test)

a = np.arange(4).reshape(-1,2)
b = np.arange(2)

print(a+b)