import cv2

cat = cv2.imread('20230227/cat.jpg')

logo = cat[100:200,100:200]
cv2.imshow('logo',logo)
cv2.waitKey(0)

cat[200:300,200:300] = logo
cv2.putText(cat,'37.5',(200,200),cv2.FONT_HERSHEY_SIMPLEX,5,(0,0,0),10)
cv2.imshow('cat',cat)
cv2.waitKey(0)

cv2.destroyAllWindows()