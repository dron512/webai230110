import numpy as np
import cv2
import os

if not os.path.isdir('images'):
    os.mkdir('images')
if not os.path.isdir('images/a'):
    os.mkdir('images/a')
if not os.path.isdir('images/b'):
    os.mkdir('images/b')
if not os.path.isdir('images/c'):
    os.mkdir('images/c')

for i in range(0,50,5):
    img = np.zeros((300,300,3),dtype=np.uint8)
    cv2.putText(img,'A',(150+i,150+i),cv2.FONT_HERSHEY_SIMPLEX,3,(255,255,255),5)
    cv2.imwrite(f'images/a/a{i}.png',img)

for i in range(0,50,5):
    img = np.zeros((300,300,3),dtype=np.uint8)
    cv2.putText(img,'B',(150+i,150+i),cv2.FONT_HERSHEY_SIMPLEX,3,(255,255,255),5)
    cv2.imwrite(f'images/b/b{i}.png',img)

for i in range(0,50,5):
    img = np.zeros((300,300,3),dtype=np.uint8)
    cv2.putText(img,'C',(150+i,150+i),cv2.FONT_HERSHEY_SIMPLEX,3,(255,255,255),5)
    cv2.imwrite(f'images/c/c{i}.png',img)

# cv2.imshow('img',img)
# cv2.waitKey(0)

# cv2.destroyAllWindows()


