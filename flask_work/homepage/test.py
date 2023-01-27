from sklearn.linear_model import LinearRegression
import matplotlib.pyplot as plt

xs = [[28],[29],[30],[31],[32]]
ys = [200,220,240,260,280]
plt.scatter(xs,ys)
plt.savefig('a.png')

knr = LinearRegression()

knr.fit( xs, ys)

result = knr.predict([[30.5]])

print(result)

