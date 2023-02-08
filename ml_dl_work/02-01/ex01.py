fish_length = [25.4, 26.3, 26.5, 29.0, 29.0, 29.7, 29.7, 30.0, 30.0, 30.7, 31.0, 31.0, 
                31.5, 32.0, 32.0, 32.0, 33.0, 33.0, 33.5, 33.5, 34.0, 34.0, 34.5, 35.0, 
                35.0, 35.0, 35.0, 36.0, 36.0, 37.0, 38.5, 38.5, 39.5, 41.0, 41.0, 9.8, 
                10.5, 10.6, 11.0, 11.2, 11.3, 11.8, 11.8, 12.0, 12.2, 12.4, 13.0, 14.3, 15.0]
fish_weight = [242.0, 290.0, 340.0, 363.0, 430.0, 450.0, 500.0, 390.0, 450.0, 500.0, 475.0, 500.0, 
                500.0, 340.0, 600.0, 600.0, 700.0, 700.0, 610.0, 650.0, 575.0, 685.0, 620.0, 680.0, 
                700.0, 725.0, 720.0, 714.0, 850.0, 1000.0, 920.0, 955.0, 925.0, 975.0, 950.0, 6.7, 
                7.5, 7.0, 9.7, 9.8, 8.7, 10.0, 9.9, 9.8, 12.2, 13.4, 12.2, 19.7, 19.9]

from sklearn.neighbors import KNeighborsClassifier

# 35개의 데이터로 학습을 진행하고 14개의 데이터 이 모델을 평가해보겠따..
# 49개의 데이터로 최근접이웃 학습기를 학습을 진행하고 그 학습한 학습기 대한 평가를 해보세요..
knr = KNeighborsClassifier()
# knr.fit()

fish_data = [[l,w] for l,w in zip(fish_length,fish_weight)]
print(fish_data)
fish_target = ['bream']*35+['smelt']*14
print(fish_target)

train_input = fish_data[:35]
train_target = fish_target[:35]
print(train_target)
test_input = fish_data[35:]
test_target = fish_target[35:]
print(test_target)

knr.fit(train_input,train_target)
test = knr.score(test_input,test_target)
print(test)

import numpy as np

np.random.seed(42)
index = np.arange(49)
np.random.shuffle(index)

in035 = index[:35]
in3549 = index[35:]

np_fish_data = np.array(fish_data)
np_fish_target = np.array(fish_target)

train_input = np_fish_data[in035]
train_target = np_fish_target[in035]

test_input = np_fish_data[in3549]
test_target = np_fish_target[in3549]

print(train_input.shape)
print(test_input.shape)

knr = KNeighborsClassifier()
knr.fit(train_input,train_target)

result = knr.predict(test_input)
print(result)
print(test_target)

score = knr.score(test_input,test_target)
print(score)
