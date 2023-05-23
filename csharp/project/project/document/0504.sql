--------------------------------------------------------
--  ������ ������ - �����-5��-04-2023   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence SEQ_CLASS
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_CLASS"  MINVALUE 1 MAXVALUE 99999999 INCREMENT BY 1 START WITH 104 NOCACHE  NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL
--------------------------------------------------------
--  DDL for Sequence SEQ_RUN_IMAGE
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_RUN_IMAGE"  MINVALUE 1 MAXVALUE 99999999 INCREMENT BY 1 START WITH 107 NOCACHE  NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL
--------------------------------------------------------
--  DDL for Sequence SEQ_TERM
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_TERM"  MINVALUE 1 MAXVALUE 99999999 INCREMENT BY 1 START WITH 160 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL
--------------------------------------------------------
--  DDL for Sequence SEQ_TERM_CODES
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_TERM_CODES"  MINVALUE 1 MAXVALUE 99999999 INCREMENT BY 1 START WITH 101 NOCACHE  NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL
--------------------------------------------------------
--  DDL for Table ABC
--------------------------------------------------------

  CREATE TABLE "ABC" ("COLUMN1" VARCHAR2(20))
--------------------------------------------------------
--  DDL for Table BONUS
--------------------------------------------------------

  CREATE TABLE "BONUS" ("ENAME" VARCHAR2(10), "JOB" VARCHAR2(9), "SAL" NUMBER(*,0), "COMM" NUMBER(*,0))
--------------------------------------------------------
--  DDL for Table DEMP_TEMP
--------------------------------------------------------

  CREATE TABLE "DEMP_TEMP" ("COLUMN1" VARCHAR2(20))
--------------------------------------------------------
--  DDL for Table DEPT
--------------------------------------------------------

  CREATE TABLE "DEPT" ("DEPTNO" NUMBER(2,0), "DNAME" VARCHAR2(14), "LOC" VARCHAR2(13))
--------------------------------------------------------
--  DDL for Table DEPT_RECORD
--------------------------------------------------------

  CREATE TABLE "DEPT_RECORD" ("DEPTNO" NUMBER(2,0), "DNAME" VARCHAR2(14), "LOC" VARCHAR2(13))
--------------------------------------------------------
--  DDL for Table DEPT_TEMP
--------------------------------------------------------

  CREATE TABLE "DEPT_TEMP" ("DEPTNO" NUMBER(2,0), "DNAME" VARCHAR2(14), "LOC" VARCHAR2(13))
--------------------------------------------------------
--  DDL for Table DEPT_TEMP2
--------------------------------------------------------

  CREATE TABLE "DEPT_TEMP2" ("DEPTNO" NUMBER(2,0), "DNAME" VARCHAR2(14), "LOC" VARCHAR2(13))
--------------------------------------------------------
--  DDL for Table EMP
--------------------------------------------------------

  CREATE TABLE "EMP" ("EMPNO" NUMBER(4,0), "ENAME" VARCHAR2(10), "JOB" VARCHAR2(9), "MGR" NUMBER(4,0), "HIREDATE" DATE, "SAL" NUMBER(7,2), "COMM" NUMBER(7,2), "DEPTNO" NUMBER(2,0))
--------------------------------------------------------
--  DDL for Table EMP_TRG
--------------------------------------------------------

  CREATE TABLE "EMP_TRG" ("EMPNO" NUMBER(4,0), "ENAME" VARCHAR2(10), "JOB" VARCHAR2(9), "MGR" NUMBER(4,0), "HIREDATE" DATE, "SAL" NUMBER(7,2), "COMM" NUMBER(7,2), "DEPTNO" NUMBER(2,0))
--------------------------------------------------------
--  DDL for Table EMP_TRG_LOG
--------------------------------------------------------

  CREATE TABLE "EMP_TRG_LOG" ("TABLENAME" VARCHAR2(10), "DML_TYPE" VARCHAR2(10), "EMPNO" NUMBER(4,0), "USER_NAME" VARCHAR2(30), "CHANGE_DATE" DATE)
--------------------------------------------------------
--  DDL for Table KB_BOOK
--------------------------------------------------------

  CREATE TABLE "KB_BOOK" ("BK_UCODE" NUMBER(*,0), "BK_NAME" VARCHAR2(255), "BK_WRITER" VARCHAR2(20), "BK_COMPANY" VARCHAR2(20), "BK_PICTURE" CLOB, "BK_PRICE" NUMBER, "CTG_UCODE" NUMBER(*,0))
--------------------------------------------------------
--  DDL for Table KB_CATEGORY
--------------------------------------------------------

  CREATE TABLE "KB_CATEGORY" ("CTG_UCODE" NUMBER(*,0), "CTG_DEPTH" NUMBER(*,0), "CTG_NAME" VARCHAR2(20), "CTG_INDEX" NUMBER(*,0), "CTG_UCODE_SUPER" NUMBER(*,0))
--------------------------------------------------------
--  DDL for Table KB_MEMBER
--------------------------------------------------------

  CREATE TABLE "KB_MEMBER" ("MBR_UCODE" NUMBER(*,0), "MBR_NAME" VARCHAR2(20), "MBR_SEX" CHAR(1), "MBR_BIRTHDAY" DATE, "MBR_EMAIL" VARCHAR2(20), "MBR_TEL" VARCHAR2(13), "MBR_PICTURE" CLOB, "MBR_REGDATE" DATE, "MBR_RETIREDATE" DATE, "MBR_STOP_DATE" DATE)
--------------------------------------------------------
--  DDL for Table KB_MEMBER_2
--------------------------------------------------------

  CREATE TABLE "KB_MEMBER_2" ("MBR_UCODE" NUMBER, "MBR_SEX" CHAR(1) DEFAULT 'M', "MBR_BIRTHDAY" DATE, "MBR_TEL" CHAR(13), "COLUMN1" VARCHAR2(20), "MBR_EMAIL" VARCHAR2(126), "MBR_PICTURE" CLOB) 

   COMMENT ON COLUMN "KB_MEMBER_2"."MBR_UCODE" IS 'ȸ����ȣ'
   COMMENT ON COLUMN "KB_MEMBER_2"."MBR_SEX" IS '����'
   COMMENT ON COLUMN "KB_MEMBER_2"."MBR_BIRTHDAY" IS '����'
   COMMENT ON COLUMN "KB_MEMBER_2"."MBR_TEL" IS '��ȭ��ȣ'
   COMMENT ON COLUMN "KB_MEMBER_2"."COLUMN1" IS 'ȸ���̸�'
   COMMENT ON COLUMN "KB_MEMBER_2"."MBR_EMAIL" IS 'ȸ���̸���'
   COMMENT ON COLUMN "KB_MEMBER_2"."MBR_PICTURE" IS 'ȸ������
'
--------------------------------------------------------
--  DDL for Table KB_RENT
--------------------------------------------------------

  CREATE TABLE "KB_RENT" ("RNT_UCODE" NUMBER(*,0), "RNT_RENT_DATE" DATE, "RNT_RETURN_DATE" DATE, "RNT_STATE" CHAR(3), "BK_UCODE" NUMBER(*,0), "MBR_UCODE" NUMBER(*,0), "RNT_SCHEDULED_RETURN_DATE" DATE)
--------------------------------------------------------
--  DDL for Table KB_UCODE_MAKER
--------------------------------------------------------

  CREATE TABLE "KB_UCODE_MAKER" ("UMK_KEY" VARCHAR2(20), "UMK_VALUE" NUMBER(*,0))
--------------------------------------------------------
--  DDL for Table PGH_CLASS
--------------------------------------------------------

  CREATE TABLE "PGH_CLASS" ("CLS_NUM" NUMBER, "CLS_NAME" VARCHAR2(20), "CLS_DESCRIPT" CLOB, "CLS_MEMO1" CLOB, "CLS_SRC_PATH" VARCHAR2(400), "CLS_SRC_CODE" CLOB, "SUB_NUM" NUMBER, "CLS_DATE" DATE, "CLS_MEMO2" CLOB, "RUN_NUM" NUMBER) 

   COMMENT ON COLUMN "PGH_CLASS"."CLS_NUM" IS '������ȣ'
   COMMENT ON COLUMN "PGH_CLASS"."CLS_NAME" IS '��������'
   COMMENT ON COLUMN "PGH_CLASS"."CLS_DESCRIPT" IS '�������
'
   COMMENT ON COLUMN "PGH_CLASS"."CLS_MEMO1" IS '�޸���'
   COMMENT ON COLUMN "PGH_CLASS"."CLS_SRC_PATH" IS '�ҽ����'
   COMMENT ON COLUMN "PGH_CLASS"."CLS_SRC_CODE" IS '�����ڵ�'
--------------------------------------------------------
--  DDL for Table PGH_RUN_IMAGE
--------------------------------------------------------

  CREATE TABLE "PGH_RUN_IMAGE" ("IMG_NUM" NUMBER, "IMG_PICTURE" VARCHAR2(400), "CLS_NUM" NUMBER) 

   COMMENT ON COLUMN "PGH_RUN_IMAGE"."IMG_NUM" IS '�����ȣ'
   COMMENT ON COLUMN "PGH_RUN_IMAGE"."IMG_PICTURE" IS '�������(���)'
--------------------------------------------------------
--  DDL for Table PGH_SUBJECT
--------------------------------------------------------

  CREATE TABLE "PGH_SUBJECT" ("SUB_NUM" NUMBER, "SUB_NAME" VARCHAR2(20)) 

   COMMENT ON COLUMN "PGH_SUBJECT"."SUB_NUM" IS '�����ȣ'
   COMMENT ON COLUMN "PGH_SUBJECT"."SUB_NAME" IS '�����̸�'
--------------------------------------------------------
--  DDL for Table PGH_TERM
--------------------------------------------------------

  CREATE TABLE "PGH_TERM" ("TERM_NUM" NUMBER, "TERM_NAME" VARCHAR2(200), "TERM_TITLE" VARCHAR2(200), "TERM_DESCRIPT" CLOB, "SUB_NUM" NUMBER, "TERM_DATE" DATE) 

   COMMENT ON COLUMN "PGH_TERM"."TERM_NUM" IS '����ȣ'
   COMMENT ON COLUMN "PGH_TERM"."TERM_NAME" IS '���(�̸�)'
   COMMENT ON COLUMN "PGH_TERM"."TERM_TITLE" IS '�������'
   COMMENT ON COLUMN "PGH_TERM"."TERM_DESCRIPT" IS '����'
   COMMENT ON COLUMN "PGH_TERM"."TERM_DATE" IS '������¥'
--------------------------------------------------------
--  DDL for Table PGH_TERM_CODES
--------------------------------------------------------

  CREATE TABLE "PGH_TERM_CODES" ("TCD_NUM" NUMBER, "TCD_SRC_PATH" VARCHAR2(400), "TERM_NUM" NUMBER, "TCD_USE_CODE" CLOB) 

   COMMENT ON COLUMN "PGH_TERM_CODES"."TCD_NUM" IS '����ڵ��ȣ'
   COMMENT ON COLUMN "PGH_TERM_CODES"."TCD_SRC_PATH" IS '����ڵ���'
   COMMENT ON COLUMN "PGH_TERM_CODES"."TCD_USE_CODE" IS '���� �ڵ�'
--------------------------------------------------------
--  DDL for Table SALGRADE
--------------------------------------------------------

  CREATE TABLE "SALGRADE" ("GRADE" NUMBER, "LOSAL" NUMBER, "HISAL" NUMBER)
REM INSERTING into ABC
SET DEFINE OFF;
REM INSERTING into BONUS
SET DEFINE OFF;
REM INSERTING into DEMP_TEMP
SET DEFINE OFF;
REM INSERTING into DEPT
SET DEFINE OFF;
Insert into DEPT (DEPTNO,DNAME,LOC) values (10,'ACCOUNTING','NEW YORK');
Insert into DEPT (DEPTNO,DNAME,LOC) values (20,'RESEARCH','DALLAS');
Insert into DEPT (DEPTNO,DNAME,LOC) values (30,'SALES','CHICAGO');
Insert into DEPT (DEPTNO,DNAME,LOC) values (40,'OPERATIONS','BOSTON');
REM INSERTING into DEPT_RECORD
SET DEFINE OFF;
Insert into DEPT_RECORD (DEPTNO,DNAME,LOC) values (10,'ACCOUNTING','NEW YORK');
Insert into DEPT_RECORD (DEPTNO,DNAME,LOC) values (20,'RESEARCH','DALLAS');
Insert into DEPT_RECORD (DEPTNO,DNAME,LOC) values (30,'SALES','CHICAGO');
Insert into DEPT_RECORD (DEPTNO,DNAME,LOC) values (40,'OPERATIONS','BOSTON');
Insert into DEPT_RECORD (DEPTNO,DNAME,LOC) values (50,'DB','seou');
Insert into DEPT_RECORD (DEPTNO,DNAME,LOC) values (98,'seoul2','database2');
REM INSERTING into DEPT_TEMP
SET DEFINE OFF;
Insert into DEPT_TEMP (DEPTNO,DNAME,LOC) values (50,'database','seoul');
Insert into DEPT_TEMP (DEPTNO,DNAME,LOC) values (53,null,null);
Insert into DEPT_TEMP (DEPTNO,DNAME,LOC) values (53,null,null);
REM INSERTING into DEPT_TEMP2
SET DEFINE OFF;
Insert into DEPT_TEMP2 (DEPTNO,DNAME,LOC) values (50,'database','seoul');
Insert into DEPT_TEMP2 (DEPTNO,DNAME,LOC) values (52,'database',null);
REM INSERTING into EMP
SET DEFINE OFF;
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7369,'SMITH','CLERK',7902,to_date('80/12/17','RR/MM/DD'),800,null,20);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7499,'ALLEN','SALESMAN',7698,to_date('81/02/20','RR/MM/DD'),1600,300,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7521,'WARD','SALESMAN',7698,to_date('81/02/22','RR/MM/DD'),1250,500,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7566,'JONES','MANAGER',7839,to_date('81/04/02','RR/MM/DD'),2975,null,20);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7654,'MARTIN','SALESMAN',7698,to_date('81/09/28','RR/MM/DD'),1250,1400,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7698,'BLAKE','MANAGER',7839,to_date('81/05/01','RR/MM/DD'),2850,null,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7782,'CLARK','MANAGER',7839,to_date('81/06/09','RR/MM/DD'),2450,null,10);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7839,'KING','PRESIDENT',null,to_date('81/11/17','RR/MM/DD'),5000,null,10);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7844,'TURNER','SALESMAN',7698,to_date('81/09/08','RR/MM/DD'),1500,0,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7900,'JAMES','CLERK',7698,to_date('81/12/03','RR/MM/DD'),950,null,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7902,'FORD','ANALYST',7566,to_date('81/12/03','RR/MM/DD'),3000,null,20);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7934,'MILLER','CLERK',7782,to_date('82/01/23','RR/MM/DD'),1300,null,10);
REM INSERTING into EMP_TRG
SET DEFINE OFF;
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7369,'SMITH','CLERK',7902,to_date('80/12/17','RR/MM/DD'),800,null,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7499,'ALLEN','SALESMAN',7698,to_date('81/02/20','RR/MM/DD'),1600,300,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7521,'WARD','SALESMAN',7698,to_date('81/02/22','RR/MM/DD'),1250,500,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7566,'JONES','MANAGER',7839,to_date('81/04/02','RR/MM/DD'),2975,null,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7654,'MARTIN','SALESMAN',7698,to_date('81/09/28','RR/MM/DD'),1250,1400,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7698,'BLAKE','MANAGER',7839,to_date('81/05/01','RR/MM/DD'),2850,null,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7782,'CLARK','MANAGER',7839,to_date('81/06/09','RR/MM/DD'),2450,null,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7839,'KING','PRESIDENT',null,to_date('81/11/17','RR/MM/DD'),5000,null,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7844,'TURNER','SALESMAN',7698,to_date('81/09/08','RR/MM/DD'),1500,0,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7902,'FORD','ANALYST',7566,to_date('81/12/03','RR/MM/DD'),3000,null,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7934,'MILLER','CLERK',7782,to_date('82/01/23','RR/MM/DD'),1300,null,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (9999,'ȫ�浿',null,null,null,null,null,20);
Insert into EMP_TRG (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (9999,'ȫ�浿',null,null,null,null,null,20);
REM INSERTING into EMP_TRG_LOG
SET DEFINE OFF;
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','insert',9999,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7369,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7499,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7521,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7566,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7654,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7698,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7782,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7839,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7844,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7902,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',7934,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',9999,'KB',to_date('23/03/24','RR/MM/DD'));
Insert into EMP_TRG_LOG (TABLENAME,DML_TYPE,EMPNO,USER_NAME,CHANGE_DATE) values ('emp_trg','update',9999,'KB',to_date('23/03/24','RR/MM/DD'));
REM INSERTING into KB_BOOK
SET DEFINE OFF;
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (17,'�����������̽�','��������','�������ǻ�',44000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (15,'���༳����','��ڻ�','�λ����ǻ�',30000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (16,'��ǰ���','��ڻ�','�������ǻ�',33000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (18,'���蹰������','����','�������ǻ�',50000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (19,'��ü����','�뺧','�������ǻ�',12000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (20,'ó�������ϴ����̽�','���ѳ�','�������ǻ�',72000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (21,'��������','������','�������ǻ�',72000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (22,'���̽�200��','��Ƽ���⽺','������ǻ�',82000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (23,'����������','��Ƽ���⽺','������ǻ�',33000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (24,'���̽�������','��Ƽ���⽺','�λ����ǻ�',23000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (25,'���̽����α׷���','��������','�������ǻ�',43000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (26,'�����ɻ�','��ư','�������ǻ�',41000,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (27,'����������Ƶ�1','���߱�','û�����ǻ�',33000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (28,'����������Ƶ�2','���߱�','û�����ǻ�',33000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (29,'����������Ƶ�3','���߱�','û�����ǻ�',33000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (30,'����������Ƶ�4','���߱�','û�����ǻ�',33000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (31,'����������Ƶ�5','���߱�','�д����ǻ�',33000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (32,'Ȳ���ǵ�','������','�������ǻ�',54000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (33,'������','�����','�������ǻ�',12000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (34,'������','���','ȫ�����ǻ�',32000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (35,'�ﱹ��','������','�������ǻ�',32000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (36,'�Ҽ�������','����ȸ','û�����ǻ�',31000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (37,'�Ҽ��򰭰���','ȣ������','������ǻ�',31000,1);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (38,'���º���','�����','�θ����ǻ�',36500,2);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (39,'������������','��ü','�θ����ǻ�',36500,2);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (40,'���⼺�渶�º���','���','�θ����ǻ�',56500,2);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (41,'�����������ΰ�','�ٴϿ�','�ĸ����ǻ�',3000,2);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (42,'ȭ����','�ƹ�Ÿ��','�ε����ǻ�',33000,2);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (43,'�ѱ���','�ֽð�','�������ǻ�',23000,3);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (44,'�ι����󿪻翩��','�ֽð�','�������ǻ�',16500,3);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (45,'������','������','�������ǻ�',48500,3);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (47,'���������','���콺','�������ǻ�',18500,4);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (48,'�ȶ����ʵ����','����','�������ǻ�',30000,4);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (49,'�������','Ȳ����','�������ǻ�',20000,4);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (50,'���ڿ��м���','���ּ�','�������ǻ�',50000,4);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (51,'�����ǿ���','Į���̰�','�������ǻ�',50000,4);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (52,'�ڽ���','Į���̰�','�������ǻ�',40000,4);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (53,'�ֻ����ٱ����','Ȳ����','�λ����ǻ�',40000,4);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (54,'������','���¿�','�λ����ǻ�',12500,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (55,'��Ὺ��','�̽¸�','�λ����ǻ�',12500,5);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (14,'��������','ȫ�浿','�뱸���ǻ�',60000,4);
Insert into KB_BOOK (BK_UCODE,BK_NAME,BK_WRITER,BK_COMPANY,BK_PRICE,CTG_UCODE) values (14,'��å','ȫ�浿','����',60000,1);
REM INSERTING into KB_CATEGORY
SET DEFINE OFF;
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (1,0,'����',0,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (2,0,'����',1,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (3,0,'��ȸ����',2,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (4,0,'�ڿ�����',3,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (5,0,'���/����',4,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (1,0,'����',0,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (2,0,'����',1,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (3,0,'��ȸ����',2,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (4,0,'�ڿ�����',3,null);
Insert into KB_CATEGORY (CTG_UCODE,CTG_DEPTH,CTG_NAME,CTG_INDEX,CTG_UCODE_SUPER) values (5,0,'���/����',4,null);
REM INSERTING into KB_MEMBER
SET DEFINE OFF;
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (18,'�豸','M',to_date('99/06/08','RR/MM/DD'),'kg@naver.com','011-1548-4453',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (19,'���¿�','M',to_date('00/08/08','RR/MM/DD'),'ptw@naver.com','010-1548-4898',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (16,'������','M',to_date('23/03/14','RR/MM/DD'),'pjs@naver.com','010-1111-2222',to_date('23/03/14','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (17,'�迬��','W',to_date('09/06/03','RR/MM/DD'),'ass@naver.com','010-1548-4453',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (20,'�������','M',to_date('53/03/01','RR/MM/DD'),'ptw@kingdom.com','016-1548-4891',to_date('23/04/26','RR/MM/DD'),null,to_date('23/04/03','RR/MM/DD'));
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (21,'�տ���','W',to_date('02/06/01','RR/MM/DD'),'syj@nate.com','016-3333-4898',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (22,'�����','M',to_date('02/06/01','RR/MM/DD'),'son@nate.com','018-3333-4898',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (23,'�Ż��Ӵ�','W',to_date('11/12/01','RR/MM/DD'),'sin@nate.com','019-3333-4898',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (24,'�ż���','W',to_date('89/12/01','RR/MM/DD'),'sin@kbs.com','019-3333-4778',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (25,'������','W',to_date('91/12/01','RR/MM/DD'),'yoo@korea.com','019-6531-4778',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (26,'�峪��','W',to_date('99/12/01','RR/MM/DD'),'nara@kbs.com','019-6531-7474',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (27,'����ũ','M',to_date('68/03/01','RR/MM/DD'),'hdk@korea.com','019-6531-7474',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (28,'�̽¿�','M',to_date('91/03/01','RR/MM/DD'),'hdk@korea.com','010-6531-7474',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (29,'�̿�ǥ','M',to_date('78/03/01','RR/MM/DD'),'lyp@korea.com','010-6531-1010',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (30,'�̼���','M',to_date('55/01/01','RR/MM/DD'),'lss@korea.com','010-1010-1010',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (31,'���缮','M',to_date('78/03/16','RR/MM/DD'),'yjs@kbs.com','010-6949-7878',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (32,'���߱�','M',to_date('81/03/01','RR/MM/DD'),'ann@korea.com','010-6949-3131',to_date('23/03/16','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (1,'����','M',to_date('71/10/20','RR/MM/DD'),'iborg1020@naver.com','010-2452-0226',to_date('23/03/14','RR/MM/DD'),to_date('23/03/09','RR/MM/DD'),null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (16,'������','M',to_date('23/03/14','RR/MM/DD'),'pjs@naver.com','010-1111-2222',to_date('23/03/14','RR/MM/DD'),null,null);
Insert into KB_MEMBER (MBR_UCODE,MBR_NAME,MBR_SEX,MBR_BIRTHDAY,MBR_EMAIL,MBR_TEL,MBR_REGDATE,MBR_RETIREDATE,MBR_STOP_DATE) values (1,'����','M',to_date('71/10/20','RR/MM/DD'),'iborg1020@naver.com','010-2452-0226',to_date('23/03/14','RR/MM/DD'),to_date('23/03/09','RR/MM/DD'),null);
REM INSERTING into KB_MEMBER_2
SET DEFINE OFF;
REM INSERTING into KB_RENT
SET DEFINE OFF;
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (12,to_date('23/03/01','RR/MM/DD'),null,null,35,18,to_date('23/03/15','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (13,to_date('23/03/08','RR/MM/DD'),null,null,34,19,to_date('23/03/22','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (14,to_date('23/03/08','RR/MM/DD'),to_date('23/03/16','RR/MM/DD'),null,33,19,to_date('23/03/22','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (10,to_date('23/03/16','RR/MM/DD'),null,null,37,18,to_date('23/03/30','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (11,to_date('23/03/16','RR/MM/DD'),null,null,36,18,to_date('23/03/30','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (15,to_date('23/03/08','RR/MM/DD'),to_date('23/03/16','RR/MM/DD'),null,32,19,to_date('23/03/22','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (16,to_date('23/03/02','RR/MM/DD'),null,null,28,19,to_date('23/03/16','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (17,to_date('23/03/04','RR/MM/DD'),null,null,30,16,to_date('23/03/18','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (18,to_date('23/03/04','RR/MM/DD'),null,null,31,16,to_date('23/03/18','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (19,to_date('23/03/04','RR/MM/DD'),null,null,29,16,to_date('23/03/18','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (20,to_date('23/02/28','RR/MM/DD'),to_date('23/03/02','RR/MM/DD'),null,33,20,to_date('23/03/14','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (21,to_date('23/02/28','RR/MM/DD'),to_date('23/03/02','RR/MM/DD'),null,32,20,to_date('23/03/14','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (22,to_date('23/02/28','RR/MM/DD'),to_date('23/03/02','RR/MM/DD'),null,27,20,to_date('23/03/14','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (23,to_date('23/02/03','RR/MM/DD'),to_date('23/03/04','RR/MM/DD'),null,42,20,to_date('23/02/17','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (24,to_date('23/02/03','RR/MM/DD'),to_date('23/03/04','RR/MM/DD'),null,41,20,to_date('23/02/17','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (25,to_date('23/02/03','RR/MM/DD'),to_date('23/03/04','RR/MM/DD'),null,40,20,to_date('23/02/17','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (26,to_date('23/03/06','RR/MM/DD'),to_date('23/03/07','RR/MM/DD'),null,39,20,to_date('23/03/20','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (27,to_date('23/03/06','RR/MM/DD'),to_date('23/03/07','RR/MM/DD'),null,38,20,to_date('23/03/20','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (28,to_date('23/03/06','RR/MM/DD'),to_date('23/03/09','RR/MM/DD'),null,45,20,to_date('23/03/20','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (29,to_date('23/03/08','RR/MM/DD'),to_date('23/03/09','RR/MM/DD'),null,44,20,to_date('23/03/22','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (30,to_date('23/03/08','RR/MM/DD'),to_date('23/03/09','RR/MM/DD'),null,43,20,to_date('23/03/22','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (31,to_date('23/03/09','RR/MM/DD'),to_date('23/03/10','RR/MM/DD'),null,14,20,to_date('23/03/23','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (32,to_date('23/03/09','RR/MM/DD'),to_date('23/03/10','RR/MM/DD'),null,53,20,to_date('23/03/23','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (33,to_date('23/03/09','RR/MM/DD'),to_date('23/03/10','RR/MM/DD'),null,52,20,to_date('23/03/23','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (34,to_date('23/03/15','RR/MM/DD'),null,null,51,20,to_date('23/03/29','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (35,to_date('23/03/15','RR/MM/DD'),null,null,50,20,to_date('23/03/29','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (36,to_date('23/03/15','RR/MM/DD'),to_date('23/03/10','RR/MM/DD'),null,50,20,to_date('23/03/29','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (37,to_date('23/03/15','RR/MM/DD'),null,null,48,20,to_date('23/03/29','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (38,to_date('23/03/15','RR/MM/DD'),null,null,47,22,to_date('23/03/29','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (39,to_date('23/03/15','RR/MM/DD'),null,null,55,22,to_date('23/03/29','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (40,to_date('23/02/28','RR/MM/DD'),null,null,54,22,to_date('23/03/14','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (41,to_date('23/03/03','RR/MM/DD'),null,null,26,23,to_date('23/03/17','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (42,to_date('23/03/07','RR/MM/DD'),null,null,23,24,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (43,to_date('23/03/07','RR/MM/DD'),null,null,22,24,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (44,to_date('23/03/07','RR/MM/DD'),null,null,20,24,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (45,to_date('23/03/07','RR/MM/DD'),null,null,18,26,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (46,to_date('23/03/07','RR/MM/DD'),to_date('23/03/10','RR/MM/DD'),null,16,26,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (47,to_date('23/03/07','RR/MM/DD'),null,null,17,26,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (48,to_date('23/03/07','RR/MM/DD'),null,null,32,27,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (49,to_date('23/03/07','RR/MM/DD'),null,null,27,28,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (50,to_date('23/03/07','RR/MM/DD'),null,null,41,29,to_date('23/03/21','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (51,to_date('23/03/16','RR/MM/DD'),null,null,41,29,to_date('23/03/30','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (52,to_date('23/03/16','RR/MM/DD'),null,null,45,29,to_date('23/03/30','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (53,to_date('23/03/16','RR/MM/DD'),null,null,52,31,to_date('23/03/30','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (54,to_date('23/03/16','RR/MM/DD'),null,null,53,32,to_date('23/03/30','RR/MM/DD'));
Insert into KB_RENT (RNT_UCODE,RNT_RENT_DATE,RNT_RETURN_DATE,RNT_STATE,BK_UCODE,MBR_UCODE,RNT_SCHEDULED_RETURN_DATE) values (55,to_date('23/03/01','RR/MM/DD'),null,null,43,32,to_date('23/03/15','RR/MM/DD'));
REM INSERTING into KB_UCODE_MAKER
SET DEFINE OFF;
Insert into KB_UCODE_MAKER (UMK_KEY,UMK_VALUE) values ('KB_MEMBER',32);
Insert into KB_UCODE_MAKER (UMK_KEY,UMK_VALUE) values ('KB_BOOK',55);
Insert into KB_UCODE_MAKER (UMK_KEY,UMK_VALUE) values ('KB_RENT',55);
Insert into KB_UCODE_MAKER (UMK_KEY,UMK_VALUE) values ('KB_MEMBER',16);
Insert into KB_UCODE_MAKER (UMK_KEY,UMK_VALUE) values ('KB_BOOK',14);
REM INSERTING into PGH_CLASS
SET DEFINE OFF;
Insert into PGH_CLASS (CLS_NUM,CLS_NAME,CLS_SRC_PATH,SUB_NUM,CLS_DATE,RUN_NUM) values (100,'����','c://���',null,to_date('23/04/28','RR/MM/DD'),0);
Insert into PGH_CLASS (CLS_NUM,CLS_NAME,CLS_SRC_PATH,SUB_NUM,CLS_DATE,RUN_NUM) values (102,'����','1',null,to_date('23/05/03','RR/MM/DD'),1);
Insert into PGH_CLASS (CLS_NUM,CLS_NAME,CLS_SRC_PATH,SUB_NUM,CLS_DATE,RUN_NUM) values (103,'T5/4','C:\Users\User\Downloads\05T-20230503T061159Z-001\05T\project\project',null,to_date('23/05/04','RR/MM/DD'),1);
Insert into PGH_CLASS (CLS_NUM,CLS_NAME,CLS_SRC_PATH,SUB_NUM,CLS_DATE,RUN_NUM) values (101,'����','c://2347923�� ���ÿ�',null,to_date('23/04/28','RR/MM/DD'),0);
REM INSERTING into PGH_RUN_IMAGE
SET DEFINE OFF;
Insert into PGH_RUN_IMAGE (IMG_NUM,IMG_PICTURE,CLS_NUM) values (100,'D:\work\csharp\project\03T\project\project\project\bin\Debug\Image\drink1_cola.png',100);
Insert into PGH_RUN_IMAGE (IMG_NUM,IMG_PICTURE,CLS_NUM) values (101,'D:\work\csharp\project\03T\project\project\project\bin\Debug\Image\drink2_zerocola.png',100);
Insert into PGH_RUN_IMAGE (IMG_NUM,IMG_PICTURE,CLS_NUM) values (105,'D:\work\csharp\project\04 - Test\project\project\project\bin\Debug\Image\drink1_cola.png',102);
Insert into PGH_RUN_IMAGE (IMG_NUM,IMG_PICTURE,CLS_NUM) values (106,'D:\work\csharp\project\06\project\project\project\bin\Debug\Image\drink1_cola.png',103);
Insert into PGH_RUN_IMAGE (IMG_NUM,IMG_PICTURE,CLS_NUM) values (102,'D:\work\csharp\project\03T\project\project\project\bin\Debug\Image\drink1_cola.png',101);
Insert into PGH_RUN_IMAGE (IMG_NUM,IMG_PICTURE,CLS_NUM) values (103,'D:\work\csharp\project\03T\project\project\project\bin\Debug\Image\hamburger6.png',101);
Insert into PGH_RUN_IMAGE (IMG_NUM,IMG_PICTURE,CLS_NUM) values (104,'D:\work\csharp\project\03T\project\project\project\bin\Debug\Image\hamburger4.png',101);
REM INSERTING into PGH_SUBJECT
SET DEFINE OFF;
REM INSERTING into PGH_TERM
SET DEFINE OFF;
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (125,'1','2',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (101,'�����','����',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (122,null,null,null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (123,'Test','����',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (124,'1','2',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (126,'1','2',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (127,'1','2',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (140,'InitializeComponent()','.cs�� ������ �ҷ���',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (141,'2','2',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (142,'2','1',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (143,'3','3',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (144,'3','3',null,to_date('23/05/03','RR/MM/DD'));
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (1,'1','��',1,null);
Insert into PGH_TERM (TERM_NUM,TERM_NAME,TERM_TITLE,SUB_NUM,TERM_DATE) values (2,'1','��',1,null);
REM INSERTING into PGH_TERM_CODES
SET DEFINE OFF;
Insert into PGH_TERM_CODES (TCD_NUM,TCD_SRC_PATH,TERM_NUM) values (100,'D:\work\csharp\project\04\project\project\project\bin\Debug\Image\drink1_cola.png',101);
REM INSERTING into SALGRADE
SET DEFINE OFF;
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (1,700,1200);
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (2,1201,1400);
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (3,1401,2000);
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (4,2001,3000);
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (5,3001,9999);
