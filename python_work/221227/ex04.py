import time

# 계속 반복적인 행하긴 해야 하는데
# 1초마다 해라고 하면 cpu 성능 저하를 피할수 있다.
for i in range(1000):
    time.sleep(i)
    print("test")

import cv2
num = cv2.imread("small_transformer.png")
