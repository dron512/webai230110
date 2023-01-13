import pymysql

def saveFiles(ko,en,filename):
    db = pymysql.connect(
        host='192.168.0.80', port=3306,  
        user='student', passwd='student123', 
        db='mhpark', charset='utf8')
    cursor = db.cursor()
    sql = f'''
            INSERT INTO files 
            (ko, en, filename, regdate) 
            VALUES
            ("{ko}","{en}","{filename}",NOW())
        '''
    cursor.execute(sql)
    db.commit()
    db.close()

def selectFiles():
    db = pymysql.connect(
        host='192.168.0.80', port=3306,  
        user='student', passwd='student123', 
        db='mhpark', charset='utf8')
    cursor = db.cursor()
    sql = f'''
            SELECT * FROM files
        '''
    cursor.execute(sql)
    res = cursor.fetchall()
    db.close()
    return res
    