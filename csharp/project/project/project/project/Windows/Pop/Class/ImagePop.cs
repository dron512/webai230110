
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.Windows.Frame;
using Lib.Manager;
using System.IO;

namespace KB.Windows.Pop.Class
{
    public partial class ImagePop : MasterPop
    {
        private int m_cls_num = -1;
        private DataTable m_img_table = null;
        private int m_img_cursor = 0;
        public int ImgCursor
        {
            get { return m_img_cursor; }
            set
            {
                m_img_cursor = value;
                label_img_num.Text = (m_img_cursor+1).ToString();
            }
        }
        public ImagePop()
        {
            InitializeComponent();
        }
        public override DialogResult ShowDialog(ePopMode aMode, object aParam)
        {
            Initialize(aMode, aParam);
            return base.ShowDialog(aMode, aParam);
        }
        public void ShowMulti(ePopMode aPopMode, object aaParam, object aParam)
        {
            m_popMode = aPopMode;
            if (aPopMode == ePopMode.add)
            {

            }
            else
            {
                if (aaParam != null && aaParam is DataRow)//전달값이 존재하며 전달값은 데이터행
                {
                    DataRow row = (DataRow)aaParam;//데이터행 "row" 는 데이터행의 전달값
                    //??? m_cls_num = Convert.ToInt32(row["cls_num"]);
                    string _cls_name = Convert.ToString(row["cls_name"]);

                    this.Text = "(image) " + _cls_name; //창 이름 변경


                }
            }
            if (aParam != null && aParam is int)
            {
                int _cls_num = (int)aParam;



                m_img_table = App.Instance().DBManager.ReadRunImage(_cls_num);
                if (m_img_table != null & m_img_table.Rows.Count > 0)
                {
                    ImgCursor = 0; DisplayImage(m_img_cursor);
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
                    m_cls_num = Convert.ToInt32(row["cls_num"]);
                    string _cls_name = Convert.ToString(row["cls_name"]);

                    this.Text = "이미지) " +_cls_name; //창 이름 변경


                }
            }
            if (aParam != null && aParam is int)
            {
                int _cls_num = (int)aParam;



                m_img_table = App.Instance().DBManager.ReadRunImage(_cls_num);
                if(m_img_table != null & m_img_table.Rows.Count>0) {
                    ImgCursor = 0; DisplayImage(m_img_cursor);
                }


            }

           

        }

        private void DisplayImage(int _cursor)
        {
            DataRow dr = m_img_table.Rows[_cursor];
            string _image_file = Convert.ToString(dr["img_picture"]);
            pbox_run.Image = Bitmap.FromFile(_image_file);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {

            ImgCursor--;
            if (ImgCursor < 0) { ImgCursor = 0; }
            DisplayImage(ImgCursor);

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            ImgCursor++;
            if(ImgCursor >= m_img_table.Rows.Count) { ImgCursor = m_img_table.Rows.Count-1; }
            DisplayImage(ImgCursor);
        }
    }
}
