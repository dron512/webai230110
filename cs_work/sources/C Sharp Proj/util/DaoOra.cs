using KBbooks.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace KBbooks
{
    internal class DaoOra
    {

        string ORA_ADDR;
        // 오라클 접속, sql명령어 객체 생성
        OracleConnection conn;
        OracleCommand cmd;
        static int logined = 0;
        static DaoOra inst = null;
        public static DaoOra getInst()
        {
            if (inst == null)
            {
                inst = new DaoOra();
                if(logined == 1)
                {
                    return inst;
                }
                else
                {
                    inst = null;
                    return inst;
                }
            }
            else
            {
                return inst;
            }
        }
        private DaoOra()
        {
            ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            $"User Id=team4;Password=1234;";
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }

        ~DaoOra()
        {
            disconnectDB();
        }

        public void connectDB()
        {
            // try ~ catch : 객체지향 프로그래밍에서 예외처리
            try
            {
                conn.Open(); // db 접속
                Console.WriteLine("오라클 접속 성공!");
                logined = 1;
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: " + e.Message);
                logined = 0;
            }
        }

        public void disconnectDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 해제 성공!");
                    logined = 0;
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("종료 에러:" + e.Message);
            }
        }

        public void initView()
        {
            //오라클 뷰 새로고침
            string query = "create or replace view bestseller as select b.book_code, b.book_title, b.book_price, b.book_author, b.book_pub, b.book_date, b.book_genre, nvl(count, 0) as 판매부수 from proj_books b left outer join (select q.book_code, q.book_title, q.book_price, q.book_author, q.book_pub, q.book_date, q.book_genre, count(*) count from proj_books q inner join proj_sale w on q.book_code = w.sale_book group by q.book_code, q.book_title, q.book_price, q.book_author, q.book_pub, q.book_date, q.book_genre) s on b.book_code = s.book_code group by b.book_code, b.book_title, b.book_price, b.book_author, b.book_pub, b.book_date, b.book_genre, nvl(count, 0) order by 판매부수 desc";
            cmd.Transaction = conn.BeginTransaction();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view rank_all as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from bestseller";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view rank_novel as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from bestseller where book_genre = '소설'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view rank_dev as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from bestseller where book_genre = '자기계발'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view rank_finance as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from bestseller where book_genre = '경제'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view rank_inmun as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from bestseller where book_genre = '인문'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view rank_comics as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from bestseller where book_genre = '만화'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();
            Console.WriteLine("뷰 새로고침");
        }

        public void initNew()
        {
            //오라클 뷰 새로고침
            string query = "create or replace view newbook as select b.book_code, b.book_title, b.book_price, b.book_author, b.book_pub, b.book_date, b.book_genre, nvl(count, 0) as 판매부수 from proj_books b left outer join (select q.book_code, q.book_title, q.book_price, q.book_author, q.book_pub, q.book_date, q.book_genre, count(*) count from proj_books q inner join proj_sale w on q.book_code = w.sale_book group by q.book_code, q.book_title, q.book_price, q.book_author, q.book_pub, q.book_date, q.book_genre) s on b.book_code = s.book_code group by b.book_code, b.book_title, b.book_price, b.book_author, b.book_pub, b.book_date, b.book_genre, nvl(count, 0) order by b.book_date desc";
            cmd.Transaction = conn.BeginTransaction();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view new_all as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from newbook order by book_date desc";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view new_novel as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from newbook where book_genre = '소설' order by book_date desc";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view new_dev as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from newbook where book_genre = '자기계발' order by book_date desc";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view new_finance as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from newbook where book_genre = '경제' order by book_date desc";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view new_inmun as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from newbook where book_genre = '인문' order by book_date desc";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = "create or replace view new_comics as select rownum 순위, book_code, book_title, book_price, book_author, book_pub, book_date, book_genre, 판매부수 from newbook where book_genre = '만화' order by book_date desc";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();
            Console.WriteLine("신간뷰 새로고침");
        }

        public OracleDataReader selectData(string table, int page)
        {
            //베스트셀러 6개씩 불러오기
            int num = 1 + (page * 6);
            string query = $"select * from rank_{table} where 순위 between {num} and {num+5}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public OracleDataReader selectNew(string table, int page)
        {
            //베스트셀러 6개씩 불러오기
            int num = 1 + (page * 6);
            string query = $"select * from new_{table} where 순위 between {num} and {num + 5}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public OracleDataReader searchDB(string find)
        {
            string query = $"select * from rank_all where UTL_MATCH.jaro_winkler_similarity(book_title, '{find}') > 80 or book_title like '%{find.Replace(' ', '%')}%' " +
                $"ORDER BY UTL_MATCH.EDIT_DISTANCE_SIMILARITY (book_title, '{find}') desc, book_title";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public void getImg(PictureBox pic, string title, string pub)
        {
            cmd.Connection = conn;
            cmd.CommandText = "select book_image from proj_books " +
                $"where book_title='{title}' and book_pub = '{pub}'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    try
                    {
                        byte[] byteData = (byte[])dr["book_image"];
                        if (byteData.Length > 0)
                        {
                            MemoryStream ms = new MemoryStream(byteData);
                            pic.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            pic.Image = null;
                        }
                    }
                    catch (InvalidCastException)
                    {
                        pic.Image = null;
                    }
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
        }
        public void getImg(PictureBox pic, string code)
        {
            cmd.Connection = conn;
            cmd.CommandText = "select book_image from proj_books " +
                $"where book_code={code}";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    try
                    {
                        byte[] byteData = (byte[])dr["book_image"];
                        if (byteData.Length > 0)
                        {
                            MemoryStream ms = new MemoryStream(byteData);
                            pic.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            pic.Image = null;
                        }
                    }
                    catch (InvalidCastException)
                    {
                        pic.Image = null;
                    }
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
        }
        
        public int getBookCount(string genre)
        {
            int count = 0;
            string query = $"select * from rank_{genre}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    count++;
                }
            }
            dr.Close();
            return count;
        }
        public int getNewCount(string genre)
        {
            int count = 0;
            string query = $"select * from new_{genre}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    count++;
                }
            }
            dr.Close();
            return count;
        }

        public OracleDataReader getReview(string title, string pub)
        {
            string code = getBookCode(title, pub);
            string query = $"select r.rev_score, r.rev_content from proj_sale s inner join proj_books b on s.sale_book = b.book_code inner join proj_rev r on s.sale_code = r.rev_code where b.book_code = {code} order by s.sale_code desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void uploadReview(string orderno, int score, string content)
        {
            try
            {
                string query = $"insert into proj_rev values({orderno}, {score}, '{content}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("리뷰 작성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("리뷰 작성:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public List<Member> getMemberData(string id)
        {
            string query = $"select * from proj_member where mem_id='{id}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            List<Member> memList = new List<Member>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    memList.Add(new Member(dr["mem_id"].ToString(),
                                           dr["mem_pw"].ToString(),
                                           dr["mem_name"].ToString(),
                                           dr["mem_addr"].ToString(),
                                           dr["mem_tel"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음");
            }
            return memList;
        }
        public void updateMember(string query)
        {
            try
            {
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("개인정보 수정됨");
            }
            catch (OracleException e)
            {
                Console.WriteLine("개인정보 수정:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public void revChangeId(string id)
        {
            try
            {
                string query = $"update proj_sale set sale_mem = 'admin' where sale_mem = '{id}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("탈퇴회원 구매내역 전환 완료");
            }
            catch (OracleException e)
            {
                Console.WriteLine("탈퇴회원 구매내역 전환:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        
        public int deleteMember(string id)
        {
            try
            {
                string query = $"delete from proj_member where mem_id = '{id}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("회원삭제 완료");
                return 1;
            }
            catch (OracleException e)
            {
                Console.WriteLine("회원삭제:" + e.Message);
                cmd.Transaction.Rollback();
                return 0;
            }
        }
        public int deleteBook(string code)
        {
            try
            {
                string query = $"delete from proj_books where book_code = {code}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("도서삭제 완료");
                return 1;
            }
            catch (OracleException e)
            {
                Console.WriteLine("도서삭제:" + e.Message);
                cmd.Transaction.Rollback();
                return 0;
            }
        }
        public int deleteSales(string code)
        {
            try
            {
                string query = $"delete from proj_sale where sale_code = {code}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("구매내역삭제 완료");
                return 1;
            }
            catch (OracleException e)
            {
                Console.WriteLine("구매내역삭제:" + e.Message);
                cmd.Transaction.Rollback();
                return 0;
            }
        }
        public void deleteReviewBySales(string code)
        {
            try
            {
                string query = $"delete from proj_rev where rev_code = {code}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("리뷰 삭제 완료");
            }
            catch (OracleException e)
            {
                Console.WriteLine("리뷰 삭제:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public string getBookCode(string title, string pub)
        {
            string query = $"select book_code from proj_books where book_title = '{title}' and book_pub = '{pub}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string code = "";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    code = dr["book_code"].ToString();
                }
            }
            dr.Close();
            return code;
        }
        public string getBookCode(string ordercode)
        {
            string query = $"select sale_book from proj_sale where sale_code = {ordercode}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string code = "";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    code = dr["sale_book"].ToString();
                }
            }
            dr.Close();
            return code;
        }
        public OracleDataReader selectData(string query)
        {
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void uploadImg(string name, string path, string code)
        {
            string sql = $"update proj_books set book_imgname = '{name}', book_image = :image where book_code = {code}";
            try
            {
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = sql;
                FileStream fs =
                    new FileStream(path, FileMode.Open,
                        FileAccess.Read);
                byte[] buffer = new byte[fs.Length - 1];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                OracleParameter op =
                    new OracleParameter();
                op.ParameterName = ":image";
                op.OracleDbType = OracleDbType.Blob;
                op.Direction = ParameterDirection.Input;
                op.Size = buffer.Length;
                op.Value = buffer;
                cmd.Parameters.Add(op);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Transaction.Commit();
                Console.WriteLine("이미지 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("이미지 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public void newMember (Member mem)
        {
            try
            {
                string sql = $"insert into proj_member values('{mem.Id}','{mem.Pw}','{mem.Name}','{mem.Addr}','{mem.Phone}', 'N')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;//생성한 연결정보
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("회원가입 성공!");
                return;
            }
            catch (OracleException e)
            {
                Console.WriteLine("회원가입:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public int Login(Member mem)
        {
            string sql = $"select mem_id, mem_pw from proj_member where mem_id='{mem.Id}' and mem_pw='{mem.Pw}'";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string dbname = dr["mem_id"].ToString();
                    string dbpassword = dr["mem_pw"].ToString();

                    if (mem.Id == dbname && mem.Pw == dbpassword)
                    {
                        Console.WriteLine("로그인 성공");
                        dr.Close();
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("로그인 실패");
                        dr.Close();
                        return 0;
                    }
                }
            }
            return 0;
        }
        public int checkManager(Member mem)
        {
            string sql = $"select mem_manager from proj_member where mem_id='{mem.Id}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["mem_manager"].ToString() == "Y")
                    {
                        dr.Close();
                        return 1;
                    }
                    else
                    {
                        dr.Close();
                        return 0;
                    }
                }
            }
            return 0;
        }

        public int idDupCheck(string id)
        {
            string query = $"select mem_id from proj_member where mem_id = '{id}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Close();
                return 1;
            }
            else
            {
                dr.Close();
                return 0;
            }
        }
        public int telDupCheck(string tel)
        {
            string query = $"select mem_id from proj_member where mem_tel = '{tel}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                return 1;
            }
            else
            {
                dr.Close();
                return 0;
            }
        }
        public List<Member> GetMember(string id)
        {
            string query = $"select * from proj_member where mem_id = '{id}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Member> mem = new List<Member>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    mem.Add(new Member(dr["mem_id"].ToString(), dr["mem_pw"].ToString(), dr["mem_name"].ToString(), dr["mem_addr"].ToString(), dr["mem_tel"].ToString()));
                }
            }
            dr.Close();
            return mem;
        }
        public string getSaleCode()
        {
            string query = "select sale_code from (select sale_code from proj_sale order by sale_code desc) where rownum = 1";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string code = "";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    code = dr["sale_code"].ToString();
                }
            }
            dr.Close();
            return code;
        }

        public void buy(string id, string title, string pub)
        {
            try
            {
                string bookcode = getBookCode(title, pub);
                string nowdate = DateTime.Now.ToLongDateString();
                string salecode = (int.Parse(getSaleCode()) + 1).ToString();//기존의 값을 읽어오고 그기에다 +1씩증가(수정)
                string sql = $"insert into proj_sale values({salecode},{bookcode},'{id}', SYSDATE)";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch(OracleException ex)
            {
                Console.WriteLine("오류: " + ex);
            }
        }

        public List<Book> homeToday()
        {
            string query = "select * from (select * from rank_all order by dbms_random.value) where rownum < 5";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Book> today = new List<Book>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    today.Add(new Book(dr["book_code"].ToString(), dr["book_title"].ToString(), dr["book_author"].ToString(), dr["book_pub"].ToString(), dr["book_date"].ToString(), dr["book_price"].ToString()));
                }
            }
            dr.Close();
            return today;
        }
        public OracleDataReader homeBest()
        {
            string query = "select * from rank_all where rownum < 5";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public List<Book> getBookInfo(string code)
        {
            string query = $"select * from rank_all where book_code = {code}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Book> info = new List<Book>();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    info.Add(new Book(dr["순위"].ToString(), dr["book_code"].ToString(), dr["book_title"].ToString(), dr["book_author"].ToString(), dr["book_pub"].ToString(), dr["book_date"].ToString(), dr["book_price"].ToString(), dr["book_genre"].ToString(), dr["판매부수"].ToString()));
                }
            }
            dr.Close();
            return info;
        }
        public string getLikeGenre(string id)
        {
            string query = $"select book_genre from (select m.mem_id, b.book_genre, count(*) from proj_sale s inner join proj_member m on s.sale_mem = m.mem_id inner join proj_books b on s.sale_book = b.book_code where m.mem_id = '{id}' group by m.mem_id, b.book_genre order by count(*) desc) where rownum = 1";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string genre = "";
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    genre = dr["book_genre"].ToString();
                }
            }
            dr.Close();
            return genre;
        }
        public string lastBuy(string id)
        {
            string query = $"select sale_book from (select sale_book from proj_sale where sale_mem = '{id}' order by sale_code desc) where rownum = 1";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string code = "";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    code = dr["sale_book"].ToString();
                }
            }
            dr.Close();
            return code;
        }
        public List<string> getFirstRecom(string code)
        {
            string query = $"select book_code from (select b.book_code from proj_sale p inner join proj_books b on p.sale_book = b.book_code where p.sale_mem = (select sale_mem from (select sale_mem from (select sale_mem from proj_sale where sale_book = {code} group by sale_mem) order by dbms_random.value) where rownum = 1) group by book_code order by dbms_random.value) where rownum < 6";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<string> codes = new List<string>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    codes.Add(dr["book_code"].ToString());
                }
            }
            dr.Close();
            return codes;
        }
        public List<string> getLikeRecom(string genre)
        {
            string find = "";
            if(genre == "소설")
            {
                find = "novel";
            }
            else if(genre == "인문")
            {
                find = "inmun";
            }
            else if(genre == "자기계발")
            {
                find = "dev";
            }
            else if(genre == "경제")
            {
                find = "finance";
            }
            else if(genre == "만화")
            {
                find = "comics";
            }
            string query = $"select * from rank_{find} where 순위 < 5";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<string> codes = new List<string>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    codes.Add(dr["book_code"].ToString());
                }
            }
            dr.Close();
            return codes;
        }

        public int isThereReview(string code)
        {
            string query = $"select r.rev_code from proj_rev r inner join proj_sale s on r.rev_code = s.sale_code where s.sale_code = {code}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["rev_code"].ToString() != "")
                    {
                        dr.Close();
                        return 1;
                    }
                    else
                    {
                        dr.Close();
                        return 0;
                    }
                }
            }
            dr.Close();
            return 0;
        }

        public List<int> getMonthlySales(int year)
        {
            string query = $"select sum(case when sale_date like '{year}/01%' then book_price end) \"1월\", " +
                           $"sum(case when sale_date like '{year}/02%' then book_price end) \"2월\", " +
                           $"sum(case when sale_date like '{year}/03%' then book_price end) \"3월\", " +
                           $"sum(case when sale_date like '{year}/04%' then book_price end) \"4월\", " +
                           $"sum(case when sale_date like '{year}/05%' then book_price end) \"5월\", " +
                           $"sum(case when sale_date like '{year}/06%' then book_price end) \"6월\", " +
                           $"sum(case when sale_date like '{year}/07%' then book_price end) \"7월\", " +
                           $"sum(case when sale_date like '{year}/08%' then book_price end) \"8월\", " +
                           $"sum(case when sale_date like '{year}/09%' then book_price end) \"9월\", " +
                           $"sum(case when sale_date like '{year}/10%' then book_price end) \"10월\", " +
                           $"sum(case when sale_date like '{year}/11%' then book_price end) \"11월\", " +
                           $"sum(case when sale_date like '{year}/12%' then book_price end) \"12월\", " +
                           $"sum(case when sale_date like '{year}%' then book_price end) \"합계\" " +
                           $"from (select s.sale_book, s.sale_date, b.book_price " +
                                $"from proj_books b " +
                                $"inner join proj_sale s " +
                                $"on s.sale_book = b.book_code " +
                                $"order by sale_date)";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<int> sales = new List<int>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    for(int i = 0; i<12; i++)
                    {
                        if(dr[$"{i + 1}월"].ToString() != "")
                        {
                            sales.Add(int.Parse(dr[$"{i + 1}월"].ToString()));
                        }
                        else
                        {
                            sales.Add(0);
                        }
                    }
                    if(dr["합계"].ToString() != "")
                    {
                        sales.Add(int.Parse(dr["합계"].ToString()));
                    }
                    else
                    {
                        sales.Add(0);
                    }
                }
            }
            dr.Close();
            return sales;
        }

        public List<int> getWeeklySales(int year, int month)
        {
            string query = $"select sum(case when sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 1 then book_price end) \"1주\", " +
                           $"sum(case when sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 2 then book_price end) \"2주\", " +
                           $"sum(case when sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 3 then book_price end) \"3주\", " +
                           $"sum(case when sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 4 then book_price end) \"4주\", " +
                           $"sum(case when sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 5 then book_price end) \"5주\", " +
                           $"sum(case when sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' then book_price end) \"합계\" " +
                           $"from (select s.sale_book, s.sale_date, b.book_price from proj_books b inner join proj_sale s on s.sale_book = b.book_code order by sale_date)";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<int> sales = new List<int>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (dr[$"{i + 1}주"].ToString() != "")
                        {
                            sales.Add(int.Parse(dr[$"{i + 1}주"].ToString()));
                        }
                        else
                        {
                            sales.Add(0);
                        }
                    }
                    if (dr["합계"].ToString() != "")
                    {
                        sales.Add(int.Parse(dr["합계"].ToString()));
                    }
                    else
                    {
                        sales.Add(0);
                    }
                }
            }
            dr.Close();
            return sales;
        }

        public List<int> getWeeklySales(int year, int month, string genre)
        {
            string query = $"select (select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 1 and b.book_genre = '{genre}') \"1주\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 2 and b.book_genre = '{genre}') \"2주\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 3 and b.book_genre = '{genre}') \"3주\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 4 and b.book_genre = '{genre}') \"4주\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and to_char(sale_date, 'W') = 5 and b.book_genre = '{genre}') \"5주\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' and b.book_genre = '{genre}') \"합계\" from dual";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<int> sales = new List<int>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (dr[$"{i + 1}주"].ToString() != "")
                        {
                            sales.Add(int.Parse(dr[$"{i + 1}주"].ToString()));
                        }
                        else
                        {
                            sales.Add(0);
                        }
                    }
                    if (dr["합계"].ToString() != "")
                    {
                        sales.Add(int.Parse(dr["합계"].ToString()));
                    }
                    else
                    {
                        sales.Add(0);
                    }
                }
            }
            dr.Close();
            return sales;
        }

        public List<int> getMonthlyGenre(string genre, int year)
        {
            string query = $"select (select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/01%' and b.book_genre = '{genre}' group by b.book_genre) \"1월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/02%' and b.book_genre = '{genre}' group by b.book_genre) \"2월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/03%' and b.book_genre = '{genre}' group by b.book_genre) \"3월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/04%' and b.book_genre = '{genre}' group by b.book_genre) \"4월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/05%' and b.book_genre = '{genre}' group by b.book_genre) \"5월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/06%' and b.book_genre = '{genre}' group by b.book_genre) \"6월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/07%' and b.book_genre = '{genre}' group by b.book_genre) \"7월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/08%' and b.book_genre = '{genre}' group by b.book_genre) \"8월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/09%' and b.book_genre = '{genre}' group by b.book_genre) \"9월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/10%' and b.book_genre = '{genre}' group by b.book_genre) \"10월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/11%' and b.book_genre = '{genre}' group by b.book_genre) \"11월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/12%' and b.book_genre = '{genre}' group by b.book_genre) \"12월\", " +
                $"(select count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}%' and b.book_genre = '{genre}' group by b.book_genre) \"합계\" " +
                $"from dual";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<int> list = new List<int>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (dr[$"{i + 1}월"].ToString() != "")
                        {
                            list.Add(int.Parse(dr[$"{i + 1}월"].ToString()));
                        }
                        else
                        {
                            list.Add(0);
                        }
                    }
                    if (dr["합계"].ToString() != "")
                    {
                        list.Add(int.Parse(dr["합계"].ToString()));
                    }
                    else
                    {
                        list.Add(0);
                    }
                }
            }
            dr.Close();
            return list;
        }

        public string getBestGenre(int year)
        {
            string query = $"select book_genre from (select b.book_genre, count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/%' group by b.book_genre order by count(*) desc) where rownum = 1";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if(dr["book_genre"].ToString() != "")
                    {
                        return dr["book_genre"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }

        public string getBestGenre(int year, int month)
        {
            string query = $"select book_genre from (select b.book_genre, count(*) from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_date like '{year}/{month.ToString().PadLeft(2, '0')}/%' group by b.book_genre order by count(*) desc) where rownum = 1";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["book_genre"].ToString() != "")
                    {
                        return dr["book_genre"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }

        public void uploadBook(Book book, string path)  // 데이터 추가
        {
            try
            {
                string sql = string.Empty;
                if (book.Imagename != null && path != null)
                {
                    sql = "insert into proj_books values " +
                        $"({book.Code}, '{book.Title}',{book.Price}, '{book.Author}', " +
                        $"'{book.Pub}', to_date('{book.Date}'),'{book.Genre}','{book.Imagename}',:image)";
                }
                else // 이미지 선택안하고 데이터만 추가
                {
                    sql = "insert into proj_books values " +
                        $"({book.Code}, '{book.Title}',{book.Price}, '{book.Author}', " +
                        $"'{book.Pub}', to_date('{book.Date}'),'{book.Genre}', null, null)";
                }

                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                if (book.Imagename != null && path != null)
                {
                    FileStream fs =
                    new FileStream(path, FileMode.Open,
                        FileAccess.Read);
                    byte[] buffer = new byte[fs.Length - 1];
                    fs.Read(buffer, 0, buffer.Length);
                    fs.Close();
                    OracleParameter op =
                        new OracleParameter();
                    op.ParameterName = ":image";
                    op.OracleDbType = OracleDbType.Blob;
                    op.Direction = ParameterDirection.Input;
                    op.Size = buffer.Length;
                    op.Value = buffer;
                    cmd.Parameters.Add(op);
                }
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터+이미지 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public List<Book> dataShow()  //데이터 보기
        {
            string query = "select * from proj_books";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Book> bookList = new List<Book>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    bookList.Add(new Book(
                        dr["BOOK_CODE"].ToString(),
                        dr["BOOK_TITLE"].ToString(),
                        dr["BOOK_AUTHOR"].ToString(),
                        dr["BOOK_PUB"].ToString(),
                        dr["BOOK_DATE"].ToString().Substring(0, 10),
                        dr["BOOK_PRICE"].ToString(),
                        dr["BOOK_GENRE"].ToString(),
                        dr["BOOK_IMGNAME"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return bookList;
        }
        public List<Book> dataShow(string searchquery)  //데이터 보기
        {
            string query = searchquery;
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Book> bookList = new List<Book>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    bookList.Add(new Book(
                        dr["BOOK_CODE"].ToString(),
                        dr["BOOK_TITLE"].ToString(),
                        dr["BOOK_AUTHOR"].ToString(),
                        dr["BOOK_PUB"].ToString(),
                        dr["BOOK_DATE"].ToString().Substring(0, 10),
                        dr["BOOK_PRICE"].ToString(),
                        dr["BOOK_GENRE"].ToString(),
                        dr["BOOK_IMGNAME"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return bookList;
        }
        public List<Book> dataShow(string column, string order)  //데이터 보기
        {
            string query = $"select * from proj_books order by {column} {order}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Book> bookList = new List<Book>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    bookList.Add(new Book(
                        dr["BOOK_CODE"].ToString(),
                        dr["BOOK_TITLE"].ToString(),
                        dr["BOOK_AUTHOR"].ToString(),
                        dr["BOOK_PUB"].ToString(),
                        dr["BOOK_DATE"].ToString().Substring(0, 10),
                        dr["BOOK_PRICE"].ToString(),
                        dr["BOOK_GENRE"].ToString(),
                        dr["BOOK_IMGNAME"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return bookList;
        }
        public List<Member> memberShow()  //데이터 보기
        {
            string query = "select m.mem_id, m.mem_name, m.mem_addr, m.mem_tel, nvl(count, 0) from proj_member m left outer join (select m.mem_id, m.mem_name, m.mem_addr, m.mem_tel, count(*) count from proj_member m inner join proj_sale s on m.mem_id = s.sale_mem group by m.mem_id, m.mem_name, m.mem_addr, m.mem_tel) b on m.mem_id = b.mem_id where m.mem_id != 'admin' group by m.mem_id, m.mem_name, m.mem_addr, m.mem_tel, nvl(count, 0)";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Member> memberList = new List<Member>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    memberList.Add(new Member(dr["mem_id"].ToString(), dr["mem_name"].ToString(), dr["mem_addr"].ToString(), dr["mem_tel"].ToString(), int.Parse(dr["nvl(count,0)"].ToString())));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return memberList;
        }
        public string getImgName(string code)
        {
            cmd.Connection = conn;
            cmd.CommandText = $"select book_imgname from proj_books where book_code='{code}'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string imgname = string.Empty;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    imgname = dr["book_imgname"].ToString();
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return imgname;
        }
        public List<Book> updateData(string code, Book book) //데이터 수정
        {
            try
            {
               string sql = "update proj_books set " +
                    $"BOOK_CODE={book.Code}, " +
                    $"BOOK_TITLE='{book.Title}', " +
                    $"BOOK_AUTHOR='{book.Author}', " +
                    $"BOOK_PUB='{book.Pub}', " +
                    $"BOOK_DATE= to_date('{book.Date}'), " +
                    $"BOOK_PRICE={book.Price}, " +
                    $"BOOK_GENRE='{book.Genre}' " +
                    $"where BOOK_CODE={code}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 수정 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Book> list = dataShow();
            return list;
        }
        public List<Book> upImge(Book book, string path, string code)  // 이미지 업데이트
        {
            try
            {
                string sql = "update proj_books set " +
                    $"BOOK_imgname='{book.Imagename}', " +
                    $"book_image = :image " +
                    $"where BOOK_CODE={code}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                FileStream fs =
                    new FileStream(path, FileMode.Open,
                        FileAccess.Read);
                byte[] buffer = new byte[fs.Length - 1];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                OracleParameter op =
                    new OracleParameter();
                op.ParameterName = ":image";
                op.OracleDbType = OracleDbType.Blob;
                op.Direction = ParameterDirection.Input;
                op.Size = buffer.Length;
                op.Value = buffer;
                cmd.Parameters.Add(op);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Transaction.Commit();
                Console.WriteLine("이미지 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("이미지 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Book> list = dataShow();
            return list;
        }

        public OracleDataReader getOrder(string id)
        {
            string query = $"select s.sale_code, b.book_title, s.sale_date, b.book_price, b.book_code from proj_sale s inner join proj_books b on s.sale_book = b.book_code where s.sale_mem = '{id}' order by s.sale_code desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public List<Notice> getNotice()
        {
            string query = $"select * from proj_notice where rownum = 1 order by notice_code desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Notice> notice = new List<Notice>();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    notice.Add(new Notice(dr["notice_code"].ToString(), dr["notice_title"].ToString(), dr["notice_content"].ToString(), dr["notice_date"].ToString().Substring(0, 10)));
                }
            }
            dr.Close();
            return notice;
        }
        public List<Notice> getNextNotice(string code)
        {
            string query = $"select * from proj_notice where notice_code = {int.Parse(code) - 1}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Notice> notice = new List<Notice>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    notice.Add(new Notice(dr["notice_code"].ToString(), dr["notice_title"].ToString(), dr["notice_content"].ToString(), dr["notice_date"].ToString().Substring(0, 10)));
                }
            }
            dr.Close();
            return notice;
        }
        public List<Notice> getPrevNotice(string code)
        {
            string query = $"select * from proj_notice where notice_code = {int.Parse(code) + 1}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Notice> notice = new List<Notice>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    notice.Add(new Notice(dr["notice_code"].ToString(), dr["notice_title"].ToString(), dr["notice_content"].ToString(), dr["notice_date"].ToString().Substring(0, 10)));
                }
            }
            dr.Close();
            return notice;
        }
        public List<Notice> getAllNotice()
        {
            string query = $"select * from proj_notice order by notice_code desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Notice> notice = new List<Notice>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    notice.Add(new Notice(dr["notice_code"].ToString(), dr["notice_title"].ToString(), dr["notice_content"].ToString(), dr["notice_date"].ToString().Substring(0, 10)));
                }
            }
            dr.Close();
            return notice;
        }
        public List<Notice> getNoticeContent(string code)
        {
            string query = $"select * from proj_notice where notice_code = {code}";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Notice> notice = new List<Notice>();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    notice.Add(new Notice(dr["notice_code"].ToString(), dr["notice_title"].ToString(), dr["notice_content"].ToString(), dr["notice_date"].ToString().Substring(0, 10)));
                }
            }
            dr.Close();
            return notice;
        }
        public void noticeUpdate(string title, string content, string code)
        {
            try
            {
                string sql = $"update proj_notice set notice_title = '{title}', notice_content = '{content}' where notice_code = {code}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("공지 수정 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("공지 수정 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public void noticeDelete(string code)
        {
            try
            {
                string sql = $"delete from proj_notice where notice_code = {code}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("공지 삭제 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("공지 삭제 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public string getNoticeCode()
        {
            string query = "select notice_code from (select notice_code from proj_notice order by notice_code desc) where rownum = 1";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            string code = "50000";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    code = dr["notice_code"].ToString();
                }
            }
            else
            {
                code = "49999";
            }
            dr.Close();
            return code;
        }
        public void uploadNotice(string title, string content)
        {
            try
            {
                int code = int.Parse(getNoticeCode()) + 1;
                string query = $"insert into proj_notice values ({code}, '{title}', '{content}', '{DateTime.Today.ToString("yy-MM-dd")}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("공지 작성 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("공지 작성 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public List<Review> getReviews()
        {
            string query = "select r.rev_code, b.book_title, r.rev_score, r.rev_content, m.mem_id from proj_rev r inner join proj_sale s on r.rev_code = s.sale_code inner join proj_books b on s.sale_book = b.book_code inner join proj_member m on s.sale_mem = m.mem_id order by r.rev_code desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Review> reviews = new List<Review>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    reviews.Add(new Review(dr["rev_code"].ToString(), dr["book_title"].ToString(), dr["rev_score"].ToString(), dr["rev_content"].ToString(), dr["mem_id"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return reviews;
        }
        public List<Review> getReviews(string query)
        {
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Review> reviews = new List<Review>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    reviews.Add(new Review(dr["rev_code"].ToString(), dr["book_title"].ToString(), dr["rev_score"].ToString(), dr["rev_content"].ToString(), dr["mem_id"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return reviews;
        }
        public List<Sales> getSales()
        {
            string query = "select s.sale_code, s.sale_book, b.book_title, s.sale_mem, s.sale_date from proj_sale s inner join proj_books b on s.sale_book = b.book_code order by s.sale_code desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Sales> sales = new List<Sales>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    sales.Add(new Sales(dr["sale_code"].ToString(), dr["sale_book"].ToString(), dr["book_title"].ToString(), dr["sale_mem"].ToString(), dr["sale_date"].ToString().Substring(0, 10)));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return sales;
        }
        public void deleteReview(string code)
        {
            try
            {
                string sql = $"delete from proj_rev where rev_code = {code}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("리뷰 삭제됨");
            }
            catch (OracleException e)
            {
                Console.WriteLine("리뷰 삭제 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public void commit()
        {
            try
            {
                string sql = $"commit";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("커밋됨");
            }
            catch (OracleException e)
            {
                Console.WriteLine("커밋: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }
    }
}
