'''
    [10,11,12,13,14,15]
    ['A','A','A','A','A','A']
    [100,101,102,103,104,105]
    ['B','B','B','B','B','B']
    16 17
    106,108

    50 A B 
'''

from sklearn.neighbors import KNeighborsClassifier
knr = KNeighborsClassifier(n_neighbors=1)
data = [10,11,12,13,14,15]+[100,101,102,103,104,105]
data = [[item] for item in data]
# print(data)
target =  ['A','A','A','A','A','A']+ ['B','B','B','B','B','B']
knr.fit(data,target)

result = knr.predict([[16],[100],[50]])
print(result)
