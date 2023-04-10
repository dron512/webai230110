using KBbooks.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KBbooks.ui.admin
{
    partial class AdminAdd : UserControl
    {
        DaoOra ora;
        MainForm mf;
        string imagename;
        string imagepath;
        public AdminAdd(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            label17.Text = "";
            label16.Text = "";
            for (int i = 2023; i >= 1940; i--)
            {
                year.Items.Add($"{i}");
            }
            for (int i = 1; i <= 30; i++)
            {
                day.Items.Add($"{i}");
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            int err = 0;
            label10.Focus();
            Regex reg = new Regex(@"[0-9]");
            if (!reg.IsMatch(code.Text))
            {
                code.Text = "도서 코드 형식이 맞지 않습니다.";
                err++;
            }
            if (code.Text == "" || code.Text == "도서 코드를 입력하세요.")
            {
                code.Text = "도서 코드를 입력하세요.";
                err++;
            }
            if(title.Text == "" || title.Text == "도서 제목을 입력하세요.")
            {
                title.Text = "도서 제목을 입력하세요.";
                err++;
            }
            if(author.Text == "" || author.Text == "저자를 입력하세요.")
            {
                author.Text = "저자를 입력하세요.";
                err++;
            }
            if(pub.Text == "" || pub.Text == "출판사를 입력하세요.")
            {
                pub.Text = "출판사를 입력하세요.";
                err++;
            }
            if(year.Text == "" || month.Text == "" || day.Text == "")
            {
                label16.Text = "발행일을 입력하세요.";
                err++;
            }
            if (!reg.IsMatch(price.Text))
            {
                price.Text = "가격을 올바르게 입력하세요.";
                err++;
            }
            if (price.Text == "" || price.Text == "가격을 입력하세요." || price.Text == "가격을 올바르게 입력하세요.")
            {
                price.Text = "가격을 입력하세요.";
                err++;
            }
            if(genre.Text == "")
            {
                label17.Text = "장르를 입력하세요.";
                err++;
            }
            if(err < 1)
            {
                string date = year.Text.Substring(2, 2) + "/" + month.Text.PadLeft(2, '0') + "/" + day.Text.PadLeft(2, '0');
                ora.uploadBook(new Book(code.Text, title.Text, author.Text, pub.Text,
                    date, price.Text, genre.Text, imagename), imagepath);
                ora.commit();
                MessageBox.Show("도서가 등록되었습니다.");
                imagename = null;
                imagepath = null;
                pic.Image = null;
                code.Text = "";
                title.Text = "";
                author.Text = "";
                pub.Text = "";
                year.SelectedIndex = -1;
                month.SelectedIndex = -1;
                day.SelectedIndex = -1;
                day.Items.Clear();
                genre.SelectedIndex = -1;
            }
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "jpeg 파일(*.jpg)|*.jpg|" +
                "png 파일(*.png)|*.png|" +
                "gif 파일(*.gif)|*.gif|" +
                "모든 파일(*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(ofd.FileName);
                imagepath = ofd.FileName;
                imagename = Path.GetFileNameWithoutExtension(imagepath);
            }
        }

        private void code_Enter(object sender, EventArgs e)
        {
            if (code.Text == "도서 코드를 입력하세요." || code.Text == "도서 코드 형식이 맞지 않습니다.")
            {
                code.Text = "";
            }
        }

        private void title_Enter(object sender, EventArgs e)
        {
            if(title.Text == "도서 제목을 입력하세요.")
            {
                title.Text = "";
            }
        }

        private void author_Enter(object sender, EventArgs e)
        {
            if (author.Text == "저자를 입력하세요.")
            {
                author.Text = "";
            }
        }

        private void pub_Enter(object sender, EventArgs e)
        {
            if (pub.Text == "출판사를 입력하세요.")
            {
                pub.Text = "";
            }
        }

        private void price_Enter(object sender, EventArgs e)
        {
            if (price.Text == "가격을 입력하세요." || price.Text == "가격을 올바르게 입력하세요.")
            {
                price.Text = "";
            }
        }

        private void genre_Enter(object sender, EventArgs e)
        {
            if (label17.Text == "장르를 입력하세요.")
            {
                label17.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            code.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            title.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            author.Focus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pub.Focus();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price.Focus();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            genre.Focus();
        }

        private void deleteImage_Click(object sender, EventArgs e)
        {
            pic.Image = null;
            imagename = null;
            imagepath = null;
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

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (month.Text == "1" || month.Text == "3" || month.Text == "5" || month.Text == "7" || month.Text == "8" || month.Text == "10" || month.Text == "12")
            {
                day.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    day.Items.Add($"{i}");
                }
                day.Text = "";
            }
            else if (month.Text == "4" || month.Text == "6" || month.Text == "9" || month.Text == "11")
            {
                day.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    day.Items.Add($"{i}");
                }
                day.Text = "";
            }
            else if (month.Text == "2")
            {
                day.Items.Clear();
                for (int i = 1; i <= 28; i++)
                {
                    day.Items.Add($"{i}");
                }
                day.Text = "";
            }
        }

        private void year_Enter(object sender, EventArgs e)
        {
            if (label16.Text == "발행일을 입력하세요.")
            {
                label16.Text = "";
            }
        }

        private void month_Enter(object sender, EventArgs e)
        {
            if (label16.Text == "발행일을 입력하세요.")
            {
                label16.Text = "";
            }
        }

        private void day_Enter(object sender, EventArgs e)
        {
            if (label16.Text == "발행일을 입력하세요.")
            {
                label16.Text = "";
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
    }
}
