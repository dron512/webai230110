import matplotlib.pyplot as plt


x = [-5,-4,-3,-2,-1,0,1,2,3,4,5]
y = []
for item in x:
    y.append(item**2+3)


plt.plot(x,y)
plt.show()