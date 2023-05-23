using KB.Windows.Pop;
using KB.Windows.Pop.Class;
using project.Windows.Pop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lib.Manager;
using KB.Windows.Pop.Terms;
using Lib.Windows.Frame;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project.Windows.Main
{
    public partial class MainForm : Form//필요해서 마스터팝 상속
    {
        private DocManager m_DocManager;
        private DBManager m_DBManager;

        private int m_subject_num = 1;

        private int m_cls_num = -1; // 글 저장 버튼위해서 만듬
        public MainForm()
        {
            InitializeComponent();
            CreateObject();
        }

        private void CreateObject()
        {
            m_DocManager = new DocManager();
            DBInfo _db = m_DocManager.ReadDBInfo();
            m_DBManager = new DBManager();
            m_DBManager.SetConnectInfo(_db._Addr, _db._Port, _db._Id, _db._Pwd, _db._DataBase);


            App.Instance().DocManager = m_DocManager;
            App.Instance().DBManager = m_DBManager;

            //킬때 마다 파란색 자동 선택 되는거 해결(원인:젤 마지막에 건들인거라서 뜨는것)
            //tbox_seed.Select();

        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("삭제 되었습니다.", "삭제 성공");
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectSettingPop _pop = new ConnectSettingPop();
            _pop.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SampleTerms _sptrm = new SampleTerms();

            _sptrm.Show();
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClass _class = new AddClass();
            _class.ShowDialog();
            AddTerm _term = new AddTerm();
            _term.ShowDialog();
        }

        private void grid_class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//클랙스 그리드 클릭시

        }

        ///////////////
        ///////ㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇㅅㅇ
        private void grid_class_MouseClick(object sender, MouseEventArgs e)
        {
            //클래스결과그리드            
            //DataRow _row = GridManager.SelectedRow(grid_class);
            //if (_row != null)
            //{
            //    //ClassPop _pop = new ClassPop();
            //    //_pop.ShowDialog(ePopMode.modify, _row);

            //}
        }
        ///-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-ㅅ-
        ///testtesttesttesttesttesttesttesttesttesttesttesttest
        private void grid_class_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DataRow _row = GridManager.SelectedRow(grid_class);
                Memo2Class _pop = new Memo2Class();
                // _pop.ShowDialog(ePopMode.modify, _row); ; //말고 여러창 열게 하기위해서 아래 2개 줄 사용
                _pop.ShowMulti(ePopMode.modify, _row);
                _pop.Show();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {

                DataRow _row = GridManager.SelectedRow(grid_class);
                ClassPop _pop = new ClassPop();
                _pop.ShowDialog(ePopMode.modify, _row);  //말고 여러창 열게 하기위해서 아래 2개 줄 사용
                /*//창 여러개 켜둘거면 이거 사용하세요
                _pop.ShowMulti(ePopMode.modify, _row);
                _pop.Show();
                */
            }

        }
        int m_changing_num = 0;
        //선택이 변경될때 발생------------------
        private void grid_class_SelectionChanged(object sender, EventArgs e)
        {
            DataRow row = GridManager.SelectedRow(grid_class);
            if (row != null)
            {
                rtbot_public_descript.Text = row["cls_src_code"].ToString();
                tbox_src_path.Text = row["cls_src_path"].ToString();
                tbox_date.Text = row["cls_date"].ToString();

                m_cls_num = Convert.ToInt32(row["cls_num"]);
            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //검색어-조회>>> 1
        private void btn_search_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
        private void DoSearch()
        {
            int _kind = cbox_kind.SelectedIndex;//검색 분류
            string _seed = tbox_seed.Text;//검색어


            DataTable _db_table = App.Instance().DBManager.ReadClass(_kind, _seed);//오라클 db 테이블
            //검색어-조회>>> 1
            DataTable _dp_table = DisplaySet.Tables["dp_class"];//grid에 있는 테이블
            _dp_table.Rows.Clear();//테이블 클리어(기존 검색결과 지우기)

            foreach (DataRow _db_row in _db_table.Rows)
            { //grid 화면에 테이블 생성(검색결과 생성)
                DataRow _dp_row = _dp_table.NewRow();
                _dp_row["cls_num"] = _db_row["cls_num"];//오라클에 있는 데이터를 grid에 옮김
                _dp_row["cls_name"] = _db_row["cls_name"];
                _dp_row["cls_descript"] = _db_row["cls_descript"];
                _dp_row["cls_memo1"] = _db_row["cls_memo1"];
                _dp_row["cls_src_path"] = _db_row["cls_src_path"];
                _dp_row["cls_src_code"] = _db_row["cls_src_code"];
                _dp_row["cls_memo2"] = _db_row["cls_memo2"];
                _dp_row["cls_date"] = _db_row["cls_date"];

                //_dp_row["sub_num"] = _db_row["sub_num"];
                _dp_table.Rows.Add(_dp_row);//테이블에 dp에 옮긴 데이터 최종 옮김
            }

        }

        private void btn_search_term_Click(object sender, EventArgs e)
        {
            DoSearchTerm();
        }
        private void DoSearchTerm()
        {
            int _kind = cbox_kind_term.SelectedIndex;
            string _seed = tbox_seed_term.Text;


            DataTable _db_table = App.Instance().DBManager.ReadTerm(_kind, _seed);

            DataTable _dp_table = DisplaySet.Tables["dp_term"];
            _dp_table.Rows.Clear();

            foreach (DataRow _db_row in _db_table.Rows)
            {
                DataRow _dp_row = _dp_table.NewRow();
                _dp_row["term_num"] = _db_row["term_num"];
                _dp_row["term_name"] = _db_row["term_name"];
                _dp_row["term_title"] = _db_row["term_title"];
                _dp_row["term_descript"] = _db_row["term_descript"];
                _dp_row["sub_num"] = _db_row["sub_num"];
                _dp_table.Rows.Add(_dp_row);
            }

        }

        //??????
        private void grid_term_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //?????
        }
        //term griddata 에 한 행을 더블클릭 했을 때 
        //디자인에서 //grid_term 부분 아래에 아래 복붙
        //this.grid_term.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_term_MouseClick);


        private void grid_term_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {//this.grid_class.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_class_CellMouseClick);
            if (e.RowIndex >= 0 && e.ColumnIndex == 99)
            {
                /*
                DataRow _row = GridManager.SelectedRow(grid_class);
                Memo2Class _pop = new Memo2Class();
                _pop.ShowDialog(ePopMode.modify, _row);
                */
            }
            else if (e.RowIndex >= 0 && (e.ColumnIndex == 1))
            {

                DataRow _row = GridManager.SelectedRow(grid_term);
                TermPop _pop = new TermPop();
                //_pop.ShowDialog(ePopMode.modify, _row); ; //말고 여러창 열게 하기위해서 아래 2개 줄 사용
                _pop.ShowMulti(ePopMode.modify, _row);
                _pop.Show();
            }

        }




        private void btn_save_Click(object sender, EventArgs e)
        {

            string _cls_src_code = rtbot_public_descript.Text;

            //이름 제목 설정 할거면 "ModifyTerm" 주석 없애기
            int _result = App.Instance().DBManager.ModifyMain(m_cls_num, _cls_src_code);
            if (_result > 0)
            {
                MessageBox.Show("수정성공");
            }
            else if (_result == -999)
            {
                MessageBox.Show("접속실패");
            }
            else
            {
                MessageBox.Show("수정실패");
            }

            //DialogResult = DialogResult.OK;

        }

        private void mbtn_modify_class_Click(object sender, EventArgs e)
        {
            DataRow _row = GridManager.SelectedRow(grid_class);
            int _cls_num = Convert.ToInt32(_row["cls_num"]);
            AddClass _pop = new AddClass();
            _pop.ShowDialog(ePopMode.modify, _row);

        }
        private void mbtn_modify_term_Click(object sender, EventArgs e)
        {
            DataRow _row = GridManager.SelectedRow(grid_term);
            int _term_num = Convert.ToInt32(_row["term_num"]);
            AddTerm _pop = new AddTerm();
            _pop.ShowDialog(ePopMode.modify, _row);
        }


        private void 실행이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow _row = GridManager.SelectedRow(grid_class);

            DataTable _img_table = App.Instance().DBManager.ReadRunImage(m_cls_num);
            if (_img_table != null & _img_table.Rows.Count > 0)
            {
                ImagePop _pop = new ImagePop();
                //_pop.ShowDialog(ePopMode.none, m_cls_num ); //말고 여러창 열게 하기위해서 아래 2개 줄 사용
                _pop.ShowMulti(ePopMode.none, _row, m_cls_num);
                _pop.Show();

            } else { 
                //이미지 없음
            }



        }



        ///testtesttesttesttesttesttesttesttesttesttest
        

        private void btn_research_class_Click(object sender, EventArgs e)
        {
            ReSearch();
        }
        private void ReSearch()
        {
            string src_path = "";
            DataRow row = GridManager.SelectedRow(grid_class);
            if (row != null)
            {
                src_path = row["cls_src_path"].ToString();
                m_cls_num = Convert.ToInt32(row["cls_num"]);
            }

            DataTable _db_table = App.Instance().DBManager.ReadClass(0, src_path);//오라클 db 테이블
            //검색어-조회>>> 1
            DataTable _dp_table = DisplaySet.Tables["dp_class"];//grid에 있는 테이블
            _dp_table.Rows.Clear();//테이블 클리어(기존 검색결과 지우기)

            foreach (DataRow _db_row in _db_table.Rows)
            { //grid 화면에 테이블 생성(검색결과 생성)
                DataRow _dp_row = _dp_table.NewRow();
                _dp_row["cls_num"] = _db_row["cls_num"];//오라클에 있는 데이터를 grid에 옮김
                _dp_row["cls_name"] = _db_row["cls_name"];
                _dp_row["cls_descript"] = _db_row["cls_descript"];
                _dp_row["cls_memo1"] = _db_row["cls_memo1"];
                _dp_row["cls_src_path"] = _db_row["cls_src_path"];
                _dp_row["cls_src_code"] = _db_row["cls_src_code"];
                _dp_row["sub_num"] = _db_row["sub_num"];
                _dp_table.Rows.Add(_dp_row);//테이블에 dp에 옮긴 데이터 최종 옮김
            }

        }

        private void btn_open_code_Click(object sender, EventArgs e)
        {

            // Visual Studio 실행 파일 경로
            string vsPath = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";

            // 솔루션 파일 경로
            string src_path = "";
            DataRow row = GridManager.SelectedRow(grid_class);
            if (row != null)
            {
                src_path = row["cls_src_path"].ToString();
                //m_cls_num = Convert.ToInt32(row["cls_num"]);
            }
            string slnPath = @src_path;

            // Visual Studio 실행 파일 실행
            System.Diagnostics.Process.Start(vsPath, slnPath);


        }

        
       
    }
}
