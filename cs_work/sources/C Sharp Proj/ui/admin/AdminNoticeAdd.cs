using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui.admin
{
    partial class AdminNoticeAdd : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public AdminNoticeAdd(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
        }
        private void booklabel_MouseEnter(object sender, EventArgs e)
        {
            booklabel.Font = new Font(booklabel.Font.Name, booklabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void booklabel_MouseLeave(object sender, EventArgs e)
        {
            booklabel.Font = new Font(booklabel.Font.Name, booklabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void saleslabel_MouseEnter(object sender, EventArgs e)
        {
            saleslabel.Font = new Font(saleslabel.Font.Name, saleslabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void saleslabel_MouseLeave(object sender, EventArgs e)
        {
            saleslabel.Font = new Font(saleslabel.Font.Name, saleslabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void saleslabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminSales(ora, mf), "AdminSales");
        }
        private void booklabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
        }
        private void noticelabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminNoticeManage(ora, mf), "AdminNoticeManage");
        }

        private void noticeadd_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminNoticeAdd(ora, mf), "AdminNoticeAdd");
        }

        private void noticemanage_MouseEnter(object sender, EventArgs e)
        {
            noticemanage.Font = new Font(noticemanage.Font.Name, noticemanage.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }

        private void noticemanage_MouseLeave(object sender, EventArgs e)
        {
            noticemanage.Font = new Font(noticemanage.Font.Name, noticemanage.Font.SizeInPoints, FontStyle.Bold);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (noticetitle.Text != "" || noticetitle.Text != "제목을 입력하세요.")
            {
                ora.uploadNotice(noticetitle.Text, noticecontent.Text);
                ora.commit();
                MessageBox.Show("공지가 작성되었습니다.", "공지 작성");
                label11.Focus();
                mf.showNotice();
                noticetitle.Text = "";
                noticecontent.Text = "";
            }
            else if (noticetitle.Text == "")
            {
                noticetitle.Text = "제목을 입력하세요.";
            }
        }

        private void noticetitle_Enter(object sender, EventArgs e)
        {
            if (noticetitle.Text == "제목을 입력하세요.")
            {
                noticetitle.Text = "";
            }
        }
        private void memberlabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminMember(ora, mf), "AdminMember");
        }
        private void memberlabel_MouseEnter(object sender, EventArgs e)
        {
            memberlabel.Font = new Font(memberlabel.Font.Name, memberlabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void memberlabel_MouseLeave(object sender, EventArgs e)
        {
            memberlabel.Font = new Font(memberlabel.Font.Name, memberlabel.Font.SizeInPoints, FontStyle.Bold);
        }
    }
}
