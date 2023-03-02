import cv2
cat =cv2.imread('20230227/cat.jpg')
cv2.imshow('cat1',cat[:,:,0])
cv2.waitKey(0) == ord('q')

cat[:,:,1] = 50
cv2.imshow('cat2',cat)
cv2.waitKey(0) == ord('q')

cat[:,:,2] = 0
cv2.imshow('cat3',cat)
cv2.waitKey(0) == ord('q')


cv2.destroyAllWindows()