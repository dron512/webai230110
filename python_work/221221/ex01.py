print(ord('L'))
print(ord('O'))
print(ord('V'))
print(ord('E'))
# print(" %d %c"%('L','L'))
a = "LOVE"
max = "L"
for item in a:
    if ord(max)<ord(item):
        max = item

print(f"max = {max}")