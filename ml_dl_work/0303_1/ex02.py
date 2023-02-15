import numpy as np
import pandas as pd
from sklearn.linear_model import LinearRegression
from sklearn.linear_model import Ridge
from sklearn.linear_model import Lasso
from sklearn.preprocessing import PolynomialFeatures
from sklearn.preprocessing import StandardScaler
from sklearn.model_selection import train_test_split
import matplotlib.pyplot as plt

data = pd.read_csv('a.csv')
perch_full = data.to_numpy()
perch_weight = np.array(
    [5.9, 32.0, 40.0, 51.5, 70.0, 100.0, 78.0, 80.0, 85.0, 85.0, 
     110.0, 115.0, 125.0, 130.0, 120.0, 120.0, 130.0, 135.0, 110.0, 
     130.0, 150.0, 145.0, 150.0, 170.0, 225.0, 145.0, 188.0, 180.0, 
     197.0, 218.0, 300.0, 260.0, 265.0, 250.0, 250.0, 300.0, 320.0, 
     514.0, 556.0, 840.0, 685.0, 700.0, 700.0, 690.0, 900.0, 650.0, 
     820.0, 850.0, 900.0, 1015.0, 820.0, 1100.0, 1000.0, 1100.0, 
     1000.0, 1000.0]
     )
print(perch_full[:5])
print(perch_weight[:5])

train_input,test_input,train_target,test_target = train_test_split(perch_full,perch_weight,random_state=42)

print(train_input.shape)
print(train_target.shape)

poly = PolynomialFeatures(degree=5,include_bias=False)

train_poly = poly.fit_transform(train_input)
test_poly = poly.fit_transform(test_input)

lr = LinearRegression()
lr.fit(train_poly,train_target)

print('훈련 점수 = ',lr.score(train_poly,train_target))
print('테스트 점수 = ',lr.score(test_poly,test_target))

ss = StandardScaler()
train_scaled = ss.fit_transform(train_poly)
test_scaled = ss.fit_transform(test_poly)

alpha_list = [0.001, 0.01, 0.1, 1, 10, 100]
train_score = []
test_score = []

for alpha in alpha_list:
    ridge = Ridge(alpha=alpha)
    ridge.fit(train_scaled,train_target)
    train_score.append(ridge.score(train_scaled,train_target))
    test_score.append(ridge.score(test_scaled,test_target))

    # print('훈련 점수 = ',ridge.score(train_scaled,train_target))
    # print('테스트 점수 = ',ridge.score(test_scaled,test_target))
print(train_score)
print(test_score)


train_score = []
test_score = []
for alpha in alpha_list:
    lasso = Lasso(alpha=alpha)
    lasso.fit(train_scaled,train_target)
    train_score.append(lasso.score(train_scaled,train_target))
    test_score.append(lasso.score(test_scaled,test_target))

    # print('훈련 점수 = ',lasso.score(train_scaled,train_target))
    # print('테스트 점수 = ',lasso.score(test_scaled,test_target))

# print(lr.coef_,end="\n\n\n")
# print(ridge.coef_,end="\n\n\n")
# print(lasso.coef_,end="\n\n\n")

plt.plot(np.log10(alpha_list),train_score)
plt.plot(np.log10(alpha_list),test_score)
# plt.ylim((0,1))
plt.show()