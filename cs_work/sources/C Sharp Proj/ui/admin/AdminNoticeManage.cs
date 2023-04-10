using KBbooks.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KBbooks.ui.admin
{
    partial class AdminNoticeManage : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public AdminNoticeManage(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            loadNotice();
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

        private void noticeadd_MouseEnter(object sender, EventArgs e)
        {
            noticeadd.Font = new Font(noticeadd.Font.Name, noticeadd.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void noticeadd_MouseLeave(object sender, EventArgs e)
        {
            noticeadd.Font = new Font(noticeadd.Font.Name, noticeadd.Font.SizeInPoints, FontStyle.Bold);
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
        private void loadNotice()
        {
            noticeView.Items.Clear();
            List<Notice> notices = ora.getAllNotice();
            for (int i = 0; i < notices.Count; i++)
            {
                noticeView.Items.Add(new ListViewItem(new string[] { notices[i].Code, notices[i].Title, notices[i].Date, notices[i].Content }));
            }
        }
        private void noticeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noticeView.SelectedItems.Count != 0)
            {
                int n = noticeView.SelectedItems[0].Index;
                string code = noticeView.Items[n].SubItems[0].Text;
                string title = noticeView.Items[n].SubItems[1].Text;
                string content = noticeView.Items[n].SubItems[3].Text;
                noticecode.Text = code;
                noticetitle.Text = title;
                noticecontent.Text = content;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (noticecode.Text != "" && (noticetitle.Text != "" || noticetitle.Text != "제목을 입력하세요."))
            {
                ora.noticeUpdate(noticetitle.Text, noticecontent.Text, noticecode.Text);
                ora.commit();
                MessageBox.Show("공지가 수정되었습니다.", "공지 수정");
                label11.Focus();
                loadNotice();
                mf.showNotice();
                noticetitle.Text = "";
                noticecontent.Text = "";
                noticecode.Text = "";
            }
            else if(noticetitle.Text == "")
            {
                noticetitle.Text = "제목을 입력하세요.";
            }
        }
        private void noticetitle_Enter(object sender, EventArgs e)
        {
            if(noticetitle.Text == "제목을 입력하세요.")
            {
                noticetitle.Text = "";
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("공지를 삭제하시겠습니까?", "공지 삭제", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ora.noticeDelete(noticecode.Text);
                ora.commit();
                MessageBox.Show("공지를 삭제했습니다.", "공지 삭제");
                loadNotice();
                mf.showNotice();
                noticetitle.Text = "";
                noticecontent.Text = "";
                noticecode.Text = "";
            }
        }
    }
}
