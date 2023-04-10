using KBbooks.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KBbooks.ui
{
    partial class Cart : UserControl
    {
        DaoOra ora;
        MainForm mf;
        List<string> bookcode;
        public Cart(DaoOra ora, MainForm mf, List<string> books)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            this.bookcode = books;
            int i = 0;
            makeInvisible();
            if (bookcode.Count == 0)
            {
                buyText.Enabled = false;
                buyBtn.Enabled = false;
                buyText.Cursor = Cursors.Default;
                buyBtn.Cursor = Cursors.Default;
                buyBtn.Image = Resources.버튼비활성;
                buyText.BackColor = Color.FromArgb(107, 112, 120);
                buyText.ForeColor = Color.White;
            }
            else
            {
                buyText.Enabled = true;
                buyBtn.Enabled = true;
                buyText.Cursor = Cursors.Hand;
                buyBtn.Cursor = Cursors.Hand;
                buyBtn.Image = Resources.버튼;
                buyText.BackColor = Color.FromArgb(0, 176, 240);
                buyText.ForeColor = Color.White;
            }
            if (i < bookcode.Count)
            {
                ora.getImg(pic1, bookcode[0]);
                List<Book> book = ora.getBookInfo(bookcode[0]);
                title1.Text = book[0].Title;
                author1.Text = book[0].Author;
                pub1.Text = book[0].Pub;
                date1.Text = book[0].Date.Substring(0, 10);
                price1.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                trash1.Visible = true;
                
            }
            if (i + 1 < bookcode.Count)
            {
                ora.getImg(pic2, bookcode[1]);
                List<Book> book = ora.getBookInfo(bookcode[1]);
                title2.Text = book[0].Title;
                author2.Text = book[0].Author;
                pub2.Text = book[0].Pub;
                date2.Text = book[0].Date.Substring(0, 10);
                price2.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                trash2.Visible = true;
            }
            if (i + 2 < bookcode.Count)
            {
                ora.getImg(pic3, bookcode[2]);
                List<Book> book = ora.getBookInfo(bookcode[2]);
                title3.Text = book[0].Title;
                author3.Text = book[0].Author;
                pub3.Text = book[0].Pub;
                date3.Text = book[0].Date.Substring(0, 10);
                price3.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                trash3.Visible = true;
            }
            if (i + 3 < bookcode.Count)
            {
                ora.getImg(pic4, bookcode[3]);
                List<Book> book = ora.getBookInfo(bookcode[3]);
                title4.Text = book[0].Title;
                author4.Text = book[0].Author;
                pub4.Text = book[0].Pub;
                date4.Text = book[0].Date.Substring(0, 10);
                price4.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                trash4.Visible = true;
            }
            if (i + 4 < bookcode.Count)
            {
                ora.getImg(pic5, bookcode[4]);
                List<Book> book = ora.getBookInfo(bookcode[4]);
                title5.Text = book[0].Title;
                author5.Text = book[0].Author;
                pub5.Text = book[0].Pub;
                date5.Text = book[0].Date.Substring(0, 10);
                price5.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                trash5.Visible = true;
            }
        }
        private void makeInvisible()
        {
            pic1.Image = null;
            pic2.Image = null;
            pic3.Image = null;
            pic4.Image = null;
            pic5.Image = null;
            title1.Text = "";
            title2.Text = "";
            title3.Text = "";
            title4.Text = "";
            title5.Text = "";
            author1.Text = "";
            author2.Text = "";
            author3.Text = "";
            author4.Text = "";
            author5.Text = "";
            pub1.Text = "";
            pub2.Text = "";
            pub3.Text = "";
            pub4.Text = "";
            pub5.Text = "";
            date1.Text = "";
            date2.Text = "";
            date3.Text = "";
            date4.Text = "";
            date5.Text = "";
            price1.Text = "";
            price2.Text = "";
            price3.Text = "";
            price4.Text = "";
            price5.Text = "";
        }

        private void trash1_Click(object sender, EventArgs e)
        {
            mf.getOutCart(0);
        }
        private void trash2_Click(object sender, EventArgs e)
        {
            mf.getOutCart(1);
        }
        private void trash3_Click(object sender, EventArgs e)
        {
            mf.getOutCart(2);
        }
        private void trash4_Click(object sender, EventArgs e)
        {
            mf.getOutCart(3);
        }
        private void trash5_Click(object sender, EventArgs e)
        {
            mf.getOutCart(4);
        }

        private void buyText_Click(object sender, EventArgs e)
        {
            List<Member> mem = ora.GetMember(mf.sendID());
            mf.controlView(new Buy(ora, mf, bookcode, mem), "Buy");
        }
    }
}
