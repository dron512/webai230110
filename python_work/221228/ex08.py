import json

with open('mydata.json',encoding="utf-8") as f:
    data = json.load(f)

print(data)