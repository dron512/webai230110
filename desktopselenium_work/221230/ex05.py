import pyautogui

# shift + f10 은 현재 설정된 파일 실행
# ctrl + shift + f10은 현재 열린 파일 실행한글카피

pyautogui.sleep(1)
print('win + r 키 누릅니다...')
pyautogui.hotkey('win','r')
pyautogui.keyDown('c')
pyautogui.keyDown('m')
pyautogui.keyDown('d')
pyautogui.hotkey('enter')

fw = pyautogui.getActiveWindow()
fw.maximize()

pyautogui.sleep(2)
fw.restore()

pyautogui.keyDown('e')
pyautogui.keyDown('x')
pyautogui.keyDown('i')
pyautogui.keyDown('t')
pyautogui.sleep(2)
pyautogui.hotkey('enter')

import pyperclip

pyperclip.copy('한글카피')
pyautogui.hotkey('ctrl','v')


