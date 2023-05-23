using Lib.Manager;
using Lib.Windows.Frame;
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

namespace KB.Windows.Pop.Class
{
    public partial class ClassPop : MasterPop
    {
        private int m_cls_num = -1;
        public ClassPop()
        {
            InitializeComponent();
        }

        public override DialogResult ShowDialog(ePopMode aMode, object aParam)
        {
            Initialize(aMode, aParam);
            return base.ShowDialog(aMode, aParam);
        }

        /*//창 여러개 켜둘거면 이거 사용하세요
        public void ShowMulti(ePopMode aPopMode, object aParam)
        {
            if (aPopMode == ePopMode.add)
            {

            }
            else
            {
                if (aParam != null && aParam is DataRow)//전달값이 존재하며 전달값은 데이터행
                {
                    DataRow row = (DataRow)aParam;//데이터행 "row" 는 데이터행의 전달값
                    m_cls_num = Convert.ToInt32(row["cls_num"]);
                    string _cls_name = Convert.ToString(row["cls_name"]);
                    string _cls_src_path = Convert.ToString(row["cls_src_path"]);
                    string _cls_descript = Convert.ToString(row["cls_descript"]);


                    // 마지막 '\' 또는 '|' 뒤에 있는 텍스트 추출
                    string path = @_cls_src_path;

                    // 마지막 '\' 또는 '|' 뒤에 있는 텍스트 추출
                    int lastIndex = path.LastIndexOfAny(new char[] { '\\', '|' });
                    string extractedText = path.Substring(lastIndex + 1);

                    _cls_src_path = extractedText;

                    this.Text = _cls_src_path + "  |  " + _cls_name; //창 이름 변경

                    rtbox_descript.Text = _cls_descript;



                }

            }
        }
        */

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
                    m_cls_num = Convert.ToInt32(row["cls_num"]);
                    string _cls_name = Convert.ToString(row["cls_name"]);
                    string _cls_src_path = Convert.ToString(row["cls_src_path"]);
                    string _cls_descript = Convert.ToString(row["cls_descript"]);

                    
                    // 마지막 '\' 또는 '|' 뒤에 있는 텍스트 추출
                    string path = @_cls_src_path;

                    // 마지막 '\' 또는 '|' 뒤에 있는 텍스트 추출
                    int lastIndex = path.LastIndexOfAny(new char[] { '\\', '|' });
                    string extractedText = path.Substring(lastIndex + 1);

                    _cls_src_path = extractedText;

                    this.Text = _cls_name + "  |  " + _cls_src_path; //창 이름 변경
                    
                    rtbox_descript.Text = _cls_descript;



                }

            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (m_popMode == ePopMode.add)
            {
            }
            else if (m_popMode == ePopMode.modify)
            {
                string _cls_descript = rtbox_descript.Text;

                //이름 제목 설정 할거면 "ModifyTerm" 주석 없애기
                int _result = App.Instance().DBManager.ModifyClassPop(m_cls_num, _cls_descript);
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
