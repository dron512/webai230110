using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lib.Manager
{
    class DBManager
    {
        private OracleManager m_OracleManager;

        public void SetConnectInfo(string aAddr, int aPort, string aId, string aPwd, string aDataBase)
        {
            m_OracleManager = new OracleManager(aAddr, aPort, aId, aPwd, aDataBase);
        }

        //4000자 이상 문자열 ToClob으로 처리하기
        public string MakeToClobQuery(string aSrc) {
            return MakeToClobQuery(aSrc, 4000);
        }
        public string MakeToClobQuery(string aSrc, int aBlock) {
            string _result = "";
            if (aSrc == null) {
                _result = "''";
            } else { 
                int _len = aSrc.Length;
                int _count = (_len + 1) / aBlock;
                for(int _idx = 0; _idx< _count; _idx++)
                {
                    if(_result.Length > 0) { _result += "||"; }
                    int _start = _idx * aBlock;
                    int _size = _len - _start;
                    if(_size> aBlock) {  _size = aBlock;}
                    _result += string.Format(" TO_CLOB('{0}') "
                        , aSrc.Substring(_start, _size));

                }
            }
            return _result;                             
        }

        


        //@검색어-조회>>> 2
        public DataTable ReadClass(int _kind, string _seed)
        {
            DataTable _dt = null;//초기화
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                return null;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery = "SELECT cls_num, cls_name, cls_descript, cls_memo1, cls_memo2, cls_src_path, cls_src_code,cls_date,sub_num ";
                _strQuery += "FROM pgh_class ";

                if(_seed.Length > 0)
                {
                    if (_kind == 0) {
                        //전체
                        _strQuery += string.Format("WHERE cls_name like '%{0}%' or cls_descript like '%{1}%' or cls_src_path like '%{2}%' ", _seed, _seed, _seed);
                    } else if (_kind == 1) {
                        //제목
                        _strQuery += string.Format("WHERE cls_name like '%{0}%' ", _seed);
                    } else if (_kind == 2) {
                        //내용
                        _strQuery += string.Format("WHERE cls_descript like '%{0}%' ", _seed);
                    } else if (_kind == 3) {
                        //폴더명
                        _strQuery += string.Format("WHERE cls_src_path like '%{0}%' ", _seed);
                    }
                }

                _dt = m_OracleManager.SelectQuery(_Connection,_strQuery,"class");
            }

            return _dt;
        }
        public DataTable ReadRunImage(int _cls_num)
        {
            DataTable _dt = null;//초기화
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                return null;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery = "SELECT img_num,img_picture,cls_num  ";
                _strQuery += "FROM pgh_run_image ";
                _strQuery += string.Format("WHERE cls_num = {0} ", _cls_num);

                _dt = m_OracleManager.SelectQuery(_Connection, _strQuery, "term");
            }

            return _dt;
        }
        ///@용어 조회//
        public DataTable ReadTerm(int _kind, string _seed)
        {
            DataTable _dt = null;//초기화
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                return null;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery = "SELECT    term_num,    term_name,    term_title,    term_descript,    sub_num ";
                _strQuery += "FROM pgh_term ";

                if (_seed.Length > 0)
                {
                    if (_kind == 0)
                    {
                        //전체
                        _strQuery += string.Format("WHERE term_name like '%{0}%' or term_title like '%{1}%' ", _seed, _seed);
                    }
                    else if (_kind == 1)
                    {
                        //제목
                        _strQuery += string.Format("WHERE term_descript like '%{0}%' ", _seed);
                    }
                }

                _dt = m_OracleManager.SelectQuery(_Connection, _strQuery, "term");
            }

            return _dt;
        }
        public DataTable ReadTermCodes(int _term_num)
        {
            DataTable _dt = null;//초기화
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                return null;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery = "SELECT tcd_num,tcd_src_path,tcd_use_code,term_num  ";
                _strQuery += "FROM pgh_term_codes ";
                _strQuery += string.Format("WHERE term_num = {0} ", _term_num);

                _dt = m_OracleManager.SelectQuery(_Connection, _strQuery, "term");
            }

            return _dt;
        }

        ////////////////추가>수업>'*'버튼//////
        public int ReadSeq(string aSeqName)
        {
            int _code = -1;
            

            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기

                string _strQuery =  string.Format("select {0}.nextval from dual ", aSeqName);

                DataTable _dt = m_OracleManager.SelectQuery(_Connection,_strQuery, "seq");
                if(_dt == null) { _code = -1; }
                else
                {
                    _code = Convert.ToInt32(_dt.Rows[0][0]);
                }
            }
            return _code;
        }
        public int ModifyClass(int _cls_num, string _name, string _memo1, int _run_num, string _src_path)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery = "UPDATE pgh_class SET ";
                _strQuery += string.Format("cls_name = '{0}', ", _name);
                _strQuery += string.Format("cls_memo1 = '{0}', ", _memo1);
                _strQuery += string.Format("cls_src_path = '{0}' ", _src_path);
                _strQuery += string.Format("WHERE cls_num = {0} ", _cls_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }

        ////////////////추가>수업>'+'버튼//////
        public int AddClass(int _cls_num, string _name,string _memo1,int _run_num,string _src_path)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery = "INSERT INTO pgh_class(cls_num,cls_name,cls_memo1,cls_src_path,run_num,cls_date)  ";
                _strQuery += string.Format("VALUES({0},'{1}','{2}','{3}',{4},'{5}') ", _cls_num, _name, _memo1, _src_path, _run_num, System.DateTime.Now.ToString("yyyy-MM-dd"));              
                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }

        ////////////////추가>수업>'-'버튼//////
        public int DeleteRunImage(int _cls_num)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery =  string.Format("DELETE FROM pgh_run_image WHERE cls_num = {0} ", _cls_num);
                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }
        ////////////////추가>수업>grid 테이블 화면 출력//////
        public int AddRunImage(int _cls_num,string _img_picture)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //쿼리문 만들기
                string _strQuery = "INSERT INTO pgh_run_image(img_num, img_picture, cls_num) ";
                _strQuery += string.Format("VALUES(SEQ_RUN_IMAGE.nextval, '{0}', {1}) ", _img_picture, _cls_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }

        ///         ㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅ
        ///         ㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅ
        ///         ㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅ    
        public int AddTerm(int _term_num, string _name, string _title)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery = "INSERT INTO pgh_term(term_num,term_name,term_title,term_date)  ";
                _strQuery += string.Format("VALUES({0},'{1}','{2}','{3}') ", _term_num, _name, _title, System.DateTime.Now.ToString("yyyy-MM-dd"));
                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }
        public int DeleteTermCodes(int _term_num)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //쿼리문 만들기

                string _strQuery = string.Format("DELETE FROM pgh_term_codes WHERE term_num = {0} ", _term_num);
                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }
        public int AddTermCodes(int _term_num, string _src_path, string _use_code)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //쿼리문 만들기
                string _strQuery = "INSERT INTO pgh_term_codes(tcd_num, tcd_src_path,tcd_use_code,term_num) ";
                _strQuery += string.Format("VALUES(SEQ_TERM_CODES.nextval,'{0}','{1}',{2}) ", _src_path, _use_code, _term_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }
        ///         -ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-
        ///         -ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-
        ///         -ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-
        public int ModifyTerm(int _term_num,string _name, string _title)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE pgh_term SET ";
                _strQuery += string.Format("term_name  = '{0}', ", _name);
                _strQuery += string.Format("term_title  = '{0}' ", _title);

                _strQuery += string.Format("WHERE term_num = {0}", _term_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }
        //term 수정 함수 생성
        public int ModifyTerm(int _term_num,string _term_name, string _term_title, string _term_descript)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE pgh_term SET ";
                _strQuery += string.Format("term_name = '{0}', ", _term_name);
                _strQuery += string.Format("term_title  = '{0}', ", _term_title);
                _strQuery += string.Format("term_descript  = '{0}' ", _term_descript);

                _strQuery += string.Format("WHERE term_num = {0}", _term_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);           }

            return _code;
        }

        //termPop 수정 함수 생성
        public int ModifyTermPop(int _term_num, string _term_descript)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE pgh_term SET ";
                /*
                _strQuery += string.Format("term_name = '{0}', ", _term_name);
                _strQuery += string.Format("term_title  = '{0}', ", _term_title);
                */
                _strQuery += string.Format("term_descript  = '{0}' ", _term_descript);

                _strQuery += string.Format("WHERE term_num = {0}", _term_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }


        ///         ㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅ
        ///         ㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅ
        ///         ㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅ 
        //class 수정 함수 생성 ??? 안쓰이는거 같음??
        public int ModifyClass(int _cls_num, string _cls_name, string _cls_descript)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE pgh_class SET ";
                _strQuery += string.Format("cls_name = '{0}', ", _cls_name);

                _strQuery += string.Format("cls_descript  = '{0}' ", _cls_descript);
                _strQuery += string.Format("WHERE cls_num = {0}", _cls_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }

        //classPop 수정 함수 생성
        public int ModifyClassPop(int _cls_num, string _cls_descript)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE pgh_class SET ";
                _strQuery += string.Format("cls_descript  = '{0}' ", _cls_descript);
                _strQuery += string.Format("WHERE cls_num = {0}", _cls_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }

        public int ModifyMemo2Class(int _cls_num, string _cls_memo2)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE pgh_class SET ";
                _strQuery += string.Format("cls_memo2  = '{0}' ", _cls_memo2);
                _strQuery += string.Format("WHERE cls_num = {0}", _cls_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }
        
        ///         -ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-
        ///         -ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-
        ///         -ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-ㅅ-ㅅㅅ-ㅅ-ㅅ-

        //testtesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttest
        public int ModifyMain(int _cls_num, string _cls_src_code)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE pgh_class SET ";
                _strQuery += string.Format("cls_src_code  = '{0}' ", _cls_src_code);
                _strQuery += string.Format("WHERE cls_num = {0}", _cls_num);

                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }

        
        
        //testtesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttest

        //아래는 참조할 뿐 사용안함 ----------------------
        public int ModifyMember(int _mbr_ucode, string _mbr_name, string _mbr_sex
                                , string _mbr_tel, string _mbr_birthday
                                , string _mbr_regdate, string _mbr_picture)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if(_Connection == null) {
                _code = -999;
            } else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE kb_member SET ";
                _strQuery += string.Format("mbr_name = '{0}', ",_mbr_name);
                _strQuery += string.Format("mbr_sex  = '{0}', ",_mbr_sex);
                _strQuery += string.Format("mbr_tel  = '{0}', ",_mbr_tel);
                _strQuery += string.Format("mbr_birthday = '{0}', ",_mbr_birthday);
                _strQuery += string.Format("mbr_regdate  = '{0}', ",_mbr_regdate);
                _strQuery += string.Format("mbr_picture  = {0}  ",_mbr_picture);

                _strQuery += string.Format("WHERE mbr_ucode = {0}", _mbr_ucode);

                _code = m_OracleManager.ExcuteQuery(_strQuery);   
            }

            return _code;
        }




    }
}
