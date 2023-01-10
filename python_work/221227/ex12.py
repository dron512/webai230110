import shutil

try:
    for i in range(5):
        shutil.move(f"a{i}.png",f"221227/a{i}.png")
except:
    pass

shutil.move(f"a.png",f"221227/a.png")