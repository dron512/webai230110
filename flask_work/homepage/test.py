from sklearn.linear_model import LinearRegression

knr = LinearRegression()

knr.fit(
    [[28],[29],[30],[31],[32]],
    [200,220,240,260,280]
)

result = knr.predict([[30.5]])

print(result)

