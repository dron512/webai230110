import pyautogui
import pyperclip

def macro():
    pyautogui.hotkey('win','r')
    pyautogui.write('mspaint')
    pyautogui.hotkey('enter')

    pyautogui.sleep(2)

    window = pyautogui.getActiveWindow()
    window.maximize()

    # pyautogui.click(x=334, y=76, duration=2)

    img = pyautogui.locateOnScreen('text.png', confidence=0.8)
    pyautogui.click(img, duration=1)

    pyautogui.move(0, 150)
    pyautogui.click(duration=0.5)

    pyperclip.copy('참 잘했어요')
    pyautogui.hotkey('ctrl','v')

    window.close()
    pyautogui.sleep(2)
    pyautogui.keyDown('n')