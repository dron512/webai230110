txt = input("파일의 내용을 쓰세요.")

f = open("txt.txt","a",encoding="UTF-8")
f.write(txt)
f.close()
