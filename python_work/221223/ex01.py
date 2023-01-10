from mywork import MyWorkBook

mwb = MyWorkBook()

print(mwb.cnt)

cnt = input("몇행으로 출력하래?")
cnt = int(cnt)+1

mwb.setCnt(cnt)
print(cnt)
print(mwb.cnt)
mwb.doSave()
mwb.doLoad()






