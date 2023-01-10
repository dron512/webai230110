import sys
from PyQt5.QtWidgets import *
from PyQt5 import uic

#UI파일 연결
#단, UI파일은 Python 코드 파일과 같은 디렉토리에 위치해야한다.
form_class = uic.loadUiType("221213/mw1.ui")[0]

#화면을 띄우는데 사용되는 Class 선언
class WindowClass(QMainWindow, form_class) :
    def __init__(self) :
        super().__init__()
        self.setupUi(self)
        self.myConnect()


    def myConnect(self):
        self.btn.clicked.connect(self.doA)

    # 정수 3개를 입력받아 평균값을 출력해라
    def doA(self):
        # self.e_1.setText("11")
        # self.e_2.setText("11")
        # self.e_3.setText("11")
        num1 = self.e_1.text()
        num2 = self.e_2.text()
        num3 = self.e_3.text()
        myresult = (int(num1)+int(num2)+int(num3)) /3
        self.result.setText(f"평균값 = {myresult}")


if __name__ == "__main__" :
    #QApplication : 프로그램을 실행시켜주는 클래스
    app = QApplication(sys.argv) 
    #WindowClass의 인스턴스 생성
    myWindow = WindowClass() 
    #프로그램 화면을 보여주는 코드
    myWindow.show()
    #프로그램을 이벤트루프로 진입시키는(프로그램을 작동시키는) 코드
    app.exec_()