import pickle

# f = open("test.txt","wb")
# data = {1:"test",2:"study",3:"python"}
# pickle.dump(data,f)
# f.close()

f = open("test.txt","rb")
data = pickle.load(f)
print(data)
f.close()