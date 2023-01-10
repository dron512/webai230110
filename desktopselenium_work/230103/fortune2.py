import urllib.request

class Fortune:
    def __init__(self,name,imgsrc,let,filename):
        self.name = name
        self.imgsrc = imgsrc
        self.let = let
        self.filename = filename

        urllib.request.urlretrieve(f"https://fortune.nate.com{self.imgsrc}",f"{filename}.jpg")