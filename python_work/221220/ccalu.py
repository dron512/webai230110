from calcu import Calculator

class CCalculator(Calculator):

    def mod(self):
        return self.first % self.secound

    def div(self):
        if self.secound == 0:
            return "나눌수 없습니다"
        else:
            return self.first / self.secound