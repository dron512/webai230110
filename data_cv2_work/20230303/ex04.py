import numpy as np
from sklearn.ensemble import RandomForestClassifier
import cv2

x = np.load('x.npy')
print(x.shape)
y = ['a']*10+['b']*10+['c']*10

rfc = RandomForestClassifier()
rfc.fit( x, y)

score = rfc.score(x,y)
print('알고리즘 평가',score)

a = cv2.imread('images/a/a0.png')
a = a.reshape(-1,270000)
print(a.shape)

result = rfc.predict(a)
print(result)

a = cv2.imread('images/b/b0.png')
a = a.reshape(-1,270000)
print(a.shape)

result = rfc.predict(a)
print(result)

a = cv2.imread('images/c/c0.png')
a = a.reshape(-1,270000)
print(a.shape)

result = rfc.predict(a)
print(result)