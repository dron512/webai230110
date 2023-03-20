import requests

result = requests.get('http://localhost:5000')
print(result)
print(result.text)

result = requests.get('http://localhost:5000/book')
print(result)
print(result.text)