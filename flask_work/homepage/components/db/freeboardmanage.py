import pymysql

host='192.168.0.80'
port=3306
user='student'
password='student123'
dbname='mhpark'
charset='utf8'

def selectRow(idx):
    db = pymysql.connect(
        host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f'select * from freeboard where idx = {idx}'
    cursor = db.cursor()
    cursor.execute(sql)
    res = cursor.fetchone()
    db.close()
    return res

def select(page):
    db = pymysql.connect(
        host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    startrow = (page-1)*3
    # 1페이지이면 startrow 가 0 
    # 2페이지이면 startrow 가 3
    # 3페이지이면 startrow 가 6
    sql = f'select * from freeboard order by idx desc limit {startrow},3'
    cursor = db.cursor()
    cursor.execute(sql)
    res = cursor.fetchall()
    db.close()
    return res


def insert(title,content,writer):
    db = pymysql.connect(
        host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f"""INSERT INTO freeboard
            (title,content,writer,regdate)
            VALUES
            ('{title}','{content}','{writer}',NOW())"""
    cursor = db.cursor()
    cursor.execute(sql)
    db.commit()
    db.close()
    print("insert해야함")

def delete(idx):
    db = pymysql.connect(
        host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f"""DELETE
             FROM freeboard 
            WHERE idx= {idx}"""
    cursor = db.cursor()
    cursor.execute(sql)
    db.commit()
    db.close()
    print("delete해야함",idx)

def update(title,content,writer,idx):
    db = pymysql.connect(
        host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f"""UPDATE freeboard
                SET title = '{title}',
                    content = '{content}',
                    writer = '{writer}'
                WHERE idx ={idx};"""
    cursor = db.cursor()
    cursor.execute(sql)
    db.commit()
    db.close()
    print("update 수정해야함")