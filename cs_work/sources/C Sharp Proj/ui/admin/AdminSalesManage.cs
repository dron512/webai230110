using KBbooks.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui.admin
{
    partial class AdminSalesManage : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public AdminSalesManage(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            showSalesList();
        }
        private void showSalesList()
        {
            salesView.Items.Clear();
            List<Sales> sales = ora.getSales();
            for (int i = 0; i < sales.Count; i++)
            {
                salesView.Items.Add(new ListViewItem(new string[] { sales[i].Scode, sales[i].Bcode, sales[i].Title, sales[i].Id, sales[i].Date }));
            }
        }
        private void bookupdate_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminUpdate(ora, mf), "AdminUpdate");
        }
        private void noticelabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminNoticeManage(ora, mf), "AdminNoticeManage");
        }
        private void bookadd_MouseEnter(object sender, EventArgs e)
        {
            bookadd.Font = new Font(bookadd.Font.Name, bookadd.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void bookadd_MouseLeave(object sender, EventArgs e)
        {
            bookadd.Font = new Font(bookadd.Font.Name, bookadd.Font.SizeInPoints, FontStyle.Bold);
        }
        private void noticelabel_MouseEnter(object sender, EventArgs e)
        {
            noticelabel.Font = new Font(noticelabel.Font.Name, noticelabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void noticelabel_MouseLeave(object sender, EventArgs e)
        {
            noticelabel.Font = new Font(noticelabel.Font.Name, noticelabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void bookreview_MouseEnter(object sender, EventArgs e)
        {
            bookreview.Font = new Font(bookreview.Font.Name, bookreview.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void bookreview_MouseLeave(object sender, EventArgs e)
        {
            bookreview.Font = new Font(bookreview.Font.Name, bookreview.Font.SizeInPoints, FontStyle.Bold);
        }
        private void bookreview_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminReview(ora, mf), "AdminReview");
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
        private void salesmanagelabel_MouseEnter(object sender, EventArgs e)
        {
            salesmanagelabel.Font = new Font(salesmanagelabel.Font.Name, salesmanagelabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void salesmanagelabel_MouseLeave(object sender, EventArgs e)
        {
            salesmanagelabel.Font = new Font(salesmanagelabel.Font.Name, salesmanagelabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void salesmanagelabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminSalesManage(ora, mf), "AdminSalesManage");
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
        private void bookupdate_MouseEnter(object sender, EventArgs e)
        {
            bookupdate.Font = new Font(bookupdate.Font.Name, bookupdate.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void bookupdate_MouseLeave(object sender, EventArgs e)
        {
            bookupdate.Font = new Font(bookupdate.Font.Name, bookupdate.Font.SizeInPoints, FontStyle.Bold);
        }
        private void booklabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
        }

        private void bookadd_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
        }

        private void salesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (salesView.SelectedItems.Count != 0)
            {
                int n = salesView.SelectedItems[0].Index;
                string code = salesView.Items[n].SubItems[0].Text;
                salescode.Text = code;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (salescode.Text != "")
            {
                if (MessageBox.Show("선택한 구매 내역과 해당 도서의 리뷰를 삭제합니다.\n정말 진행하시겠습니까?\n(이 작업은 되돌릴 수 없습니다!)", "구매 내역 삭제", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ora.deleteReviewBySales(salescode.Text);
                    ora.deleteSales(salescode.Text);
                    ora.commit();
                    MessageBox.Show("구매 내역 삭제가 완료되었습니다.", "구매 내역 삭제");
                    salescode.Text = "";
                    showSalesList();
                }
            }
        }
    }
}
