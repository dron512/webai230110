import matplotlib.pyplot as plt
import random

# for i in range(5):
#     a = random.randint(0,10)
#     b = random.randint(0,100)

x = [10,20,2,30,4,40,50]
y = [item*2 for item in x]

plt.scatter(x,y)
plt.savefig(f'a.png')