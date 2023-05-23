using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lib.Windows.Frame;
using Lib.Manager;

namespace KB.Windows.Pop.Terms
{
    public partial class TermPop : MasterPop
    {
        private int m_term_num = -1;//유효성 false 를 위해
        public TermPop()
        {
            InitializeComponent();
        }

        public override DialogResult ShowDialog(ePopMode aMode, object aParam)
        {
            Initialize(aMode, aParam);
            return base.ShowDialog(aMode, aParam);
        }
        public void ShowMulti(ePopMode aPopMode, object aParam)
        {
            m_popMode = aPopMode;
            if (aPopMode == ePopMode.add)
            {

            }
            else
            {
                if (aParam != null && aParam is DataRow)//전달값이 존재하며 전달값은 데이터행
                {
                    DataRow row = (DataRow)aParam;//데이터행 "row" 는 데이터행의 전달값
                    m_term_num = Convert.ToInt32(row["term_num"]);//이걸 기준으로 다른 값을 오라클에서 불러온다
                    string _term_name = Convert.ToString(row["term_name"]);
                    string _term_title = Convert.ToString(row["term_title"]);
                    string _term_descript = Convert.ToString(row["term_descript"]);

                    this.Text = _term_title + " / / " + _term_name; //창 이름 변경

                    tbox_descript.Text = _term_descript;
                }
            }
         }
        private void Initialize(ePopMode aPopMode, object aParam)
        {
            if (aPopMode == ePopMode.add)
            {

            }
            else
            {
                if (aParam != null && aParam is DataRow)//전달값이 존재하며 전달값은 데이터행
                {
                    DataRow row = (DataRow)aParam;//데이터행 "row" 는 데이터행의 전달값
                    m_term_num = Convert.ToInt32(row["term_num"]);//이걸 기준으로 다른 값을 오라클에서 불러온다
                    string _term_name = Convert.ToString(row["term_name"]);
                    string _term_title = Convert.ToString(row["term_title"]);
                    string _term_descript = Convert.ToString(row["term_descript"]);

                    this.Text = _term_name + " / / " + _term_title; //창 이름 변경

                    tbox_descript.Text = _term_descript;



                }

            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (m_popMode == ePopMode.add)
            {
            }
            else if (m_popMode == ePopMode.modify)
            {
               

                string _term_descript = tbox_descript.Text;

                //이름 제목 설정 할거면 "ModifyTerm" 주석 없애기
                int _result = App.Instance().DBManager.ModifyTermPop(m_term_num, _term_descript);
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

            }
            DialogResult = DialogResult.OK;
        }
    }
}
