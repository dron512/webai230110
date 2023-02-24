import cv2

cat = cv2.imread('cat.jpg')
print(cat.shape)
cv2.imshow('ani',cat)
key = cv2.waitKey(1000)
print(key)

dog = cv2.imread('dog.jpg')
dog = cv2.resize(dog,(600,399))
print(dog.shape)
cv2.imshow('ani',dog)
key = cv2.waitKey(1000)
print(key)

shark = cv2.imread('shark.jpg')
shark = cv2.resize(shark,(600,399))
print(shark.shape)
cv2.imshow('ani',shark)
key = cv2.waitKey(1000)
print(key)