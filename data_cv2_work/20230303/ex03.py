import glob
import cv2
import numpy as np

x=[]
path = "./images/a/*"
file_list = glob.glob(path)
print ("file_list_py: {}".format(file_list))
for file in file_list:
    a = cv2.imread(file)
    a = a.reshape(-1,300*300*3)
    x.append(a)

path = "./images/b/*"
file_list = glob.glob(path)
print ("file_list_py: {}".format(file_list))
for file in file_list:
    b = cv2.imread(file)
    b = b.reshape(-1,300*300*3)
    x.append(b)

path = "./images/c/*"
file_list = glob.glob(path)
print ("file_list_py: {}".format(file_list))
for file in file_list:
    c = cv2.imread(file)
    c = c.reshape(-1,300*300*3)
    x.append(c)

x = np.array(x)
x = x.reshape(-1,300*300*3)
print(x.shape)

np.save('x.npy',x)