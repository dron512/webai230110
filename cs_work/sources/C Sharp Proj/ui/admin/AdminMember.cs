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

namespace KBbooks.ui.admin
{
    partial class AdminMember : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public AdminMember(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            initListView();
        }
        private void initListView()
        {
            memberView.Items.Clear();
            List<Member> list = ora.memberShow(); // 오라클 데이터를 list에 담는다.
            for (int i = 0; i < list.Count; i++)
            {
                memberView.Items.Add(new ListViewItem(new string[] { list[i].Id, list[i].Name, list[i].Addr,
                    list[i].Phone, list[i].Buy.ToString() }));
            }
        }

        private void booklabel_MouseEnter(object sender, EventArgs e)
        {
            booklabel.Font = new Font(booklabel.Font.Name, booklabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void booklabel_MouseLeave(object sender, EventArgs e)
        {
            booklabel.Font = new Font(booklabel.Font.Name, booklabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void booklabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
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
        private void noticelabel_MouseEnter(object sender, EventArgs e)
        {
            noticelabel.Font = new Font(noticelabel.Font.Name, noticelabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void noticelabel_MouseLeave(object sender, EventArgs e)
        {
            noticelabel.Font = new Font(noticelabel.Font.Name, noticelabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void noticelabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminNoticeManage(ora, mf), "AdminNoticeManage");
        }
        private void memberlabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminMember(ora, mf), "AdminMember");
        }

        private void memberView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberView.SelectedItems.Count != 0)
            {
                int n = memberView.SelectedItems[0].Index;
                string id = memberView.Items[n].SubItems[0].Text;

                idlabel.Text = id;
            }
        }

        private void forcedelete_Click(object sender, EventArgs e)
        {
            if(idlabel.Text != "")
            {
                if(MessageBox.Show("선택한 회원을 강제 탈퇴시킵니다.\n정말 진행하시겠습니까?\n(이 작업은 되돌릴 수 없습니다!)", "회원 강제 탈퇴", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ora.revChangeId(idlabel.Text);
                    ora.deleteMember(idlabel.Text);
                    ora.commit();
                    MessageBox.Show("강제 탈퇴가 완료되었습니다.", "회원 강제 탈퇴");
                    idlabel.Text = "";
                    initListView();
                }
            }
        }
    }
}
