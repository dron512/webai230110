import pyautogui

img = pyautogui.screenshot()
img.save('a.png')

pi = pyautogui.pixel(10,10)
print(pi)

print(pyautogui.pixelMatchesColor(10,10,(221,221,221)))

if pyautogui.pixelMatchesColor(10,10,(221,221,221)):
    pyautogui.click()