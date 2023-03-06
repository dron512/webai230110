import cv2

img1 = cv2.imread('20230303/cat.jpg')
img2 = cv2.imread('20230303/dog.jpg')

print(img1.shape)
img2= cv2.resize(img2,(600,399))
print(img2.shape)

print(img1[100,100])
print(img2[100,100])

cv2.imshow('img',img1)
cv2.waitKey(0)

cv2.imshow('img',img2)
cv2.waitKey(0)

result = cv2.add(img1,img2)
cv2.imshow('result',result)
cv2.waitKey(0)

print(result[100,100])

result = img1+img2
cv2.imshow('result',result)
cv2.waitKey(0)

cv2.destroyAllWindows()