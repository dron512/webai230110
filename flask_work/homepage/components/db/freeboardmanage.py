import pymysql

host='192.168.0.80'
port=3306
user='student'
password='student123'
dbname='mhpark'
charset='utf8'

def select():
    db = pymysql.connect(
        host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = 'select * from freeboard'
    cursor = db.cursor()
    cursor.execute(sql)
    res = cursor.fetchall()
    db.close()
    return res


def insert():
    print("insert해야함")

def delete():
    print("delete해야함")

def update():
    print("update 수정해야함")