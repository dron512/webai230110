import time 

"a:b:c:d:".split(":")

print( time.ctime() )

timelist = time.ctime().split(" ")
print(timelist)

print(time.strftime('%x', time.localtime(time.time())))