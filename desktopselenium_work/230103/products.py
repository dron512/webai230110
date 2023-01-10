import urllib.request

class Product:
    def __init__(self,name,imgsrc,price,filename):
        self.name = name
        self.imgsrc = imgsrc
        self.price = price
        self.filename = filename

        # print('imgsrc',self.imgsrc)
        # print(f"{self.filename}.jpg")

        urllib.request.urlretrieve(f"https:{self.imgsrc}",f"{self.filename}.jpg")
        
    
