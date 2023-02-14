from sklearn.neighbors import KNeighborsRegressor
import matplotlib.pyplot as plt
import numpy as np

x1 = np.array([22,50,120,180,200])
x1 = x1.reshape(-1,1)
print(x1)
y1 = [44,70,140,200,500]

# x2 = [30,40]
# x2 = [[x] for x in x2]
# print(x2)
x2 = np.array([30,1000])
x2 = x2.reshape(-1,1)
print(x2)

nkr = KNeighborsRegressor(n_neighbors=2)
nkr.fit(x1,y1)

result = nkr.predict(x2)
print(result)

plt.scatter(x1,y1)
plt.scatter(x2,result)
plt.show()