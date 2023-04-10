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
    partial class AdminReview : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public AdminReview(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            showReviewList();
        }

        private void showReviewList()
        {
            reviewView.Items.Clear();
            List<Review> reviews = ora.getReviews();
            for(int i = 0; i < reviews.Count; i++)
            {
                reviewView.Items.Add(new ListViewItem(new string[] { reviews[i].Code, reviews[i].Title, reviews[i].Score, reviews[i].Content, reviews[i].Id }));
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
        private void bookadd_MouseEnter(object sender, EventArgs e)
        {
            bookadd.Font = new Font(bookadd.Font.Name, bookadd.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void bookadd_MouseLeave(object sender, EventArgs e)
        {
            bookadd.Font = new Font(bookadd.Font.Name, bookadd.Font.SizeInPoints, FontStyle.Bold);
        }
        private void bookadd_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
        }
        private void booklabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
        }
        private void bookupdate_MouseEnter(object sender, EventArgs e)
        {
            bookupdate.Font = new Font(bookupdate.Font.Name, bookupdate.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void bookupdate_MouseLeave(object sender, EventArgs e)
        {
            bookupdate.Font = new Font(bookupdate.Font.Name, bookupdate.Font.SizeInPoints, FontStyle.Bold);
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

        private void reviewView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reviewView.SelectedItems.Count != 0)
            {
                int n = reviewView.SelectedItems[0].Index;
                string code = reviewView.Items[n].SubItems[0].Text;
                reviewcode.Text = code;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("선택한 리뷰를 삭제하시겠습니까?", "리뷰 삭제", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ora.deleteReview(reviewcode.Text);
                ora.commit();
                MessageBox.Show("리뷰를 삭제했습니다.", "리뷰 삭제");
            }
            showReviewList();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            showReviewList();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void searchColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchText.Text = "";
            searchGenre.SelectedItem = null;
            if(searchColumn.Text == "점수")
            {
                searchText.Visible = false;
                searchGenre.Visible = true;
            }
            else
            {
                searchText.Visible = true;
                searchGenre.Visible = false;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchText.Text != "" && searchColumn.Text == "도서명")
            {
                string find = searchText.Text;
                string searchquery = $"select r.rev_code, b.book_title, r.rev_score, r.rev_content, m.mem_id from proj_rev r inner join proj_sale s on r.rev_code = s.sale_code inner join proj_books b on s.sale_book = b.book_code inner join proj_member m on s.sale_mem = m.mem_id where UTL_MATCH.jaro_winkler_similarity(b.book_title, '{find}') > 80 order by r.rev_code desc";
                searchResult(searchquery);
            }
            else if (searchText.Text != "" && searchColumn.Text == "작성자")
            {
                string find = searchText.Text;
                string searchquery = $"select r.rev_code, b.book_title, r.rev_score, r.rev_content, m.mem_id from proj_rev r inner join proj_sale s on r.rev_code = s.sale_code inner join proj_books b on s.sale_book = b.book_code inner join proj_member m on s.sale_mem = m.mem_id where m.mem_id = '{find}' order by r.rev_code desc";
                searchResult(searchquery);
            }
            else if (searchGenre.Text != "" && searchColumn.Text == "점수")
            {
                string find = searchGenre.Text;
                string searchquery = $"select r.rev_code, b.book_title, r.rev_score, r.rev_content, m.mem_id from proj_rev r inner join proj_sale s on r.rev_code = s.sale_code inner join proj_books b on s.sale_book = b.book_code inner join proj_member m on s.sale_mem = m.mem_id where r.rev_score = {find} order by r.rev_code desc";
                searchResult(searchquery);
            }
        }
        private void searchResult(string query)
        {
            reviewView.Items.Clear();
            List<Review> reviews = ora.getReviews(query);
            for (int i = 0; i < reviews.Count; i++)
            {
                reviewView.Items.Add(new ListViewItem(new string[] { reviews[i].Code, reviews[i].Title, reviews[i].Score, reviews[i].Content, reviews[i].Id }));
            }
        }
    }
}
