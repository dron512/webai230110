import pyautogui

# file = pyautogui.locateOnScreen('filese.png')
# pyautogui.click(file)

pyautogui.hotkey('alt','tab')
pyautogui.sleep(1)
ch1 = pyautogui.locateAllOnScreen('checkbox.png')
for item in ch1:
    pyautogui.click(item)
    pyautogui.sleep(1)
