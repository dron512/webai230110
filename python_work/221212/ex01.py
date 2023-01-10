import sys
from PyQt5.QtWidgets \
    import QApplication, QWidget , QVBoxLayout, QPushButton, QTextEdit, QLineEdit, QMessageBox

class MyApp(QWidget):

    def __init__(self):
        super().__init__()
        self.initUI()

    def initUI(self):
        self.lineedit = QLineEdit()
        self.textedit = QTextEdit()
        btn1 = QPushButton("구구단역순")
        btn1.clicked.connect(self.guguEvent)

        vboxlayout = QVBoxLayout()
        vboxlayout.addWidget(self.lineedit)
        vboxlayout.addWidget(self.textedit)
        vboxlayout.addWidget(btn1)

        self.setLayout(vboxlayout)
        self.setWindowTitle('My First Application')
        self.move(300, 300)
        self.resize(400, 200)
        self.show()

    def guguEvent(self):
        gugudan = self.lineedit.text()
        print(gugudan.isdigit())
        if gugudan.isdigit() == False:
            QMessageBox.warning(self,"경고","숫자 입력하세요.")
        
        '''
            gugudan ==2 
            2*1 = 2
            2*2 = 4
            msg = 
        '''
        
        msg = ""
        for i in range(9,0,-1):
            msg = msg + f"{gugudan} * {i} = {int(gugudan)*i}\n"

        self.textedit.setText(msg)
        # print(self.textedit.toPlainText())

if __name__ == '__main__':
   app = QApplication(sys.argv)
   ex = MyApp()
   sys.exit(app.exec_())