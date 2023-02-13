import numpy as np

mydata = np.array([1,2,3,4])
print(mydata)
print(mydata.shape)

mydata2 = mydata.reshape(-1,2)
print(mydata2)
print(mydata2.shape)

mydata3 = mydata.reshape(-1,1)
print(mydata3)
print(mydata3.shape)
