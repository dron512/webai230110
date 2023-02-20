import numpy as np
import matplotlib.pyplot as plt

li = np.array([1,2,3,4,5,7])

test = li.reshape(-1,2)
print(test)

plt.imshow(test)
plt.show()

# test = test.astype(np.uint8)

# import cv2

# cv2.imshow('test',test)
# cv2.waitKey(-1)