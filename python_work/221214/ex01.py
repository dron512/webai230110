'''
    c,java,python
    html,css,javascript
'''
def doA():
    for i in range(1,101):
        if i % 7 == 0:
            print(i,end="\t")
            continue
        if i % 9 == 0:
            print(i,end="\t")


if __name__ =='__main__':
    doA()