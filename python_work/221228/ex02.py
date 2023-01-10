# import itertools
# import time
# import datetime
import shutil
# import random

# a = [ x for x in zip(range(0,10),range(20,30))]
# print(a)

# time.sleep(5)
# b = [ random.randint(0,x) for x in range(50,100)]
# print(b)

# time.sleep(5)
# c = [ x for x in itertools.zip_longest(range(10,30),[],fillvalue="55")]
# print(c)

# time.sleep(5)
# print(time.strftime("%x",time.localtime(time.time())))

shutil.move("../memo.txt","./")