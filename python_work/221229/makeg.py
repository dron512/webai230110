from faker import Faker
import matplotlib.pyplot as plt
import matplotlib
import matplotlib.font_manager as fm
import numpy as np

fak = Faker()

name_age =[]
for x in range(10):
    name_age.append([fak.name(),fak.pyint(min_value=10,max_value=60)])

print(name_age)
name_age = np.array(name_age)

plt.figure(figsize=(15,4))
plt.bar(name_age[:,0],name_age[:,1])

plt.savefig('aa.png')
