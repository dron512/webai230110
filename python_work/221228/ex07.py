import time
import threading

def long_task():
    for i in range(5):
        time.sleep(1)
        print(f"working {i}")

mythread = []

for i in range(5):
    t = threading.Thread(target=long_task)
    mythread.append(t)

print("Start")

for t in mythread:
    t.start()

for t in mythread:
    t.join()

print("End")