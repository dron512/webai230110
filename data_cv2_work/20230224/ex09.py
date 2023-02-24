import cv2

cat = cv2.imread('cat.jpg',cv2.IMREAD_COLOR)
cat1 = cat.copy()
# cat1 = cat1[:,:,0]
cv2.imshow('cat1',cat1)
cv2.imwrite('cat1.jpg',cat1)

cat2 = cat.copy()
cat2 = cat2[:200,:200]
cv2.imshow('cat2',cat2)
cv2.imwrite('cat2.jpg',cat2)

cat1[100:300,100:300] = cat2
cv2.imshow('cat3',cat1)
cv2.imwrite('cat3.jpg',cat1)

dog = cv2.imread('dog.jpg',cv2.IMREAD_COLOR)
dog = cv2.resize(dog,(399,600))
dog[:,:,1] = 0
dog[:,:,2] = 0
cv2.imshow('dog',dog)
cv2.waitKey(0)
dog = cv2.cvtColor(dog,cv2.COLOR_BGR2GRAY)
cv2.imshow('dog',dog)
cv2.waitKey(0)
cv2.imwrite('dog1.jpg',dog)
