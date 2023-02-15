import numpy as np
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression
from sklearn.linear_model import Lasso,Ridge
from sklearn.preprocessing import PolynomialFeatures
from sklearn.preprocessing import StandardScaler

df = pd.read_csv('a.csv')
perch_full = df.to_numpy()

perch_weight = np.array(
    [5.9, 32.0, 40.0, 51.5, 70.0, 100.0, 78.0, 80.0, 85.0, 85.0, 
     110.0, 115.0, 125.0, 130.0, 120.0, 120.0, 130.0, 135.0, 110.0, 
     130.0, 150.0, 145.0, 150.0, 170.0, 225.0, 145.0, 188.0, 180.0, 
     197.0, 218.0, 300.0, 260.0, 265.0, 250.0, 250.0, 300.0, 320.0, 
     514.0, 556.0, 840.0, 685.0, 700.0, 700.0, 690.0, 900.0, 650.0, 
     820.0, 850.0, 900.0, 1015.0, 820.0, 1100.0, 1000.0, 1100.0, 
     1000.0, 1000.0]
     )

x1,x2,y1,y2 = train_test_split(perch_full,perch_weight,random_state=42)

poly = PolynomialFeatures(degree=5,include_bias=False)
data = poly.fit_transform([[2,3]])
# print(data)
# print(poly.get_feature_names_out())

x1_poly = poly.fit_transform(x1)
print(x1_poly.shape)
x2_poly = poly.fit_transform(x2)
print(x2_poly.shape)

lr = LinearRegression()
lr.fit(x1_poly,y1)

score = lr.score(x1_poly,y1)
print('x1 을 넣었을때 학습기 점수 = ',score)
score = lr.score(x2_poly,y2)
print('x2 을 넣었을때 학습기 점수 = ',score)

predValues = lr.predict(x2_poly)
print('예측값 5개 = ',predValues[:5])
print('실제값 5개 = ',y2[:5])


x1_scaled = StandardScaler().fit_transform(x1_poly)
x2_scaled = StandardScaler().fit_transform(x2_poly)

lr = LinearRegression()
lr.fit(x1_scaled,y1)

score = lr.score(x1_scaled,y1)
print('x1 을 넣었을때 학습기 점수 = ',score)
score = lr.score(x2_scaled,y2)
print('x2 을 넣었을때 학습기 점수 = ',score)

predValues = lr.predict(x1_scaled)
print('예측값 5개 = ',predValues[:5])
print('실제값 5개 = ',y2[:5])

print(lr.coef_)

lr = Ridge()
lr.fit(x1_scaled,y1)

score = lr.score(x1_scaled,y1)
print('x1 을 넣었을때 학습기 점수 = ',score)
score = lr.score(x2_scaled,y2)
print('x2 을 넣었을때 학습기 점수 = ',score)

predValues = lr.predict(x1_scaled)
print('예측값 5개 = ',predValues[:5])
print('실제값 5개 = ',y2[:5])

print(lr.coef_)

lr = Lasso()
lr.fit(x1_scaled,y1)

score = lr.score(x1_scaled,y1)
print('x1 을 넣었을때 학습기 점수 = ',score)
score = lr.score(x2_scaled,y2)
print('x2 을 넣었을때 학습기 점수 = ',score)

predValues = lr.predict(x1_scaled)
print('예측값 5개 = ',predValues[:5])
print('실제값 5개 = ',y2[:5])

print(lr.coef_)

