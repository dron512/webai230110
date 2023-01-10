import re 

check = re.compile("(:)")

te = re.sub(check,"#","a:b:c:d")
print(te)

ma = re.search(check,"a:b:c:d")
print(ma.group())
