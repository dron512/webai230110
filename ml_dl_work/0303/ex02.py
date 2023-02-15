import numpy as np
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression
from sklearn.preprocessing import PolynomialFeatures

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
print(x1.shape)
print(y1.shape)
print(x2.shape)
print(y2.shape)

lr = LinearRegression()
lr.fit(x1,y1)

predValues = lr.predict(x2)
print(x2[:5])
print(predValues[:5])

score = lr.score(x1,y1)
print('x1 을 넣었을때 학습기 점수 = ',score)
score = lr.score(x2,y2)
print('x2 을 넣었을때 학습기 점수 = ',score)