import cv2

cat = cv2.imread('20230227/cat.jpg')

print(cat[100,100])
print(cat[100,100,2])
cat[90:100,90:100,2] = 255

cv2.imshow('cat',cat)
cv2.waitKey(0)

cv2.destroyAllWindows()