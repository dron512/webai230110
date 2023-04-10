using KBbooks.Properties;
using KBbooks.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui
{
    partial class Buy : UserControl
    {
        DaoOra ora;
        MainForm mf;
        int multibuy = 0;
        int bookcount = 0;
        public Buy(DaoOra ora, MainForm mf, string code, List<Member> mem)
        {
            InitializeComponent();
            multibuy = 0;
            this.ora = ora;
            this.mf = mf;
            makeInvisible();
            ora.getImg(pic1, code);
            List<Book> book = ora.getBookInfo(code);
            title1.Text = book[0].Title;
            author1.Text = book[0].Author;
            pub1.Text = book[0].Pub;
            date1.Text = book[0].Date.Substring(0, 10);
            int price = int.Parse(book[0].Price);
            price1.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
            name.Text = mem[0].Name;
            addr.Text = mem[0].Addr;
            tel.Text = mem[0].Phone;
            many.Text = "총 1 권";
            sumprice.Text = price.ToString("#,##0") + "원";
        }

        public Buy(DaoOra ora, MainForm mf, List<string> codes, List<Member> mem)
        {
            InitializeComponent();
            multibuy = 1;
            this.ora = ora;
            this.mf = mf;
            makeInvisible();
            int i = 0;
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, sum5 = 0;
            if (i < codes.Count)
            {
                ora.getImg(pic1, codes[0]);
                List<Book> book = ora.getBookInfo(codes[0]);
                title1.Text = book[0].Title;
                author1.Text = book[0].Author;
                pub1.Text = book[0].Pub;
                date1.Text = book[0].Date.Substring(0, 10);
                sum1 = int.Parse(book[0].Price);
                price1.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                bookcount++;

            }
            if (i + 1 < codes.Count)
            {
                ora.getImg(pic2, codes[1]);
                List<Book> book = ora.getBookInfo(codes[1]);
                title2.Text = book[0].Title;
                author2.Text = book[0].Author;
                pub2.Text = book[0].Pub;
                date2.Text = book[0].Date.Substring(0, 10);
                sum2 = int.Parse(book[0].Price);
                price2.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                bookcount++;
            }
            if (i + 2 < codes.Count)
            {
                ora.getImg(pic3, codes[2]);
                List<Book> book = ora.getBookInfo(codes[2]);
                title3.Text = book[0].Title;
                author3.Text = book[0].Author;
                pub3.Text = book[0].Pub;
                date3.Text = book[0].Date.Substring(0, 10);
                sum3 = int.Parse(book[0].Price);
                price3.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                bookcount++;
            }
            if (i + 3 < codes.Count)
            {
                ora.getImg(pic4, codes[3]);
                List<Book> book = ora.getBookInfo(codes[3]);
                title4.Text = book[0].Title;
                author4.Text = book[0].Author;
                pub4.Text = book[0].Pub;
                date4.Text = book[0].Date.Substring(0, 10);
                sum4 = int.Parse(book[0].Price);
                price4.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                bookcount++;
            }
            if (i + 4 < codes.Count)
            {
                ora.getImg(pic5, codes[4]);
                List<Book> book = ora.getBookInfo(codes[4]);
                title5.Text = book[0].Title;
                author5.Text = book[0].Author;
                pub5.Text = book[0].Pub;
                date5.Text = book[0].Date.Substring(0, 10);
                sum5 = int.Parse(book[0].Price);
                price5.Text = int.Parse(book[0].Price).ToString("#,##0") + "원";
                bookcount++;
            }
            name.Text = mem[0].Name;
            addr.Text = mem[0].Addr;
            tel.Text = mem[0].Phone;
            many.Text = $"총 {bookcount} 권";
            sumprice.Text = (sum1 + sum2 + sum3 + sum4 + sum5).ToString("#,##0") + "원";
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

        private void label7_Click(object sender, EventArgs e)
        {
            tryBuy();
        }
        private void buyBtn_Click(object sender, EventArgs e)
        {
            tryBuy();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                buyText.Enabled = true;
                buyBtn.Enabled = true;
                buyText.Cursor = Cursors.Hand;
                buyBtn.Cursor = Cursors.Hand;
                buyBtn.Image = Resources.버튼;
                buyText.BackColor = Color.FromArgb(0, 176, 240);
                buyText.ForeColor = Color.White;
            }
            else
            {
                buyText.Enabled = false;
                buyBtn.Enabled = false;
                buyText.Cursor = Cursors.Default;
                buyBtn.Cursor = Cursors.Default;
                buyBtn.Image = Resources.버튼비활성;
                buyText.BackColor = Color.FromArgb(107, 112, 120);
                buyText.ForeColor = Color.White;
            }
        }

        private void tryBuy()
        {
            if (multibuy == 0)
            {
                ora.buy(mf.sendID(), title1.Text, pub1.Text);
                ora.commit();
                mf.controlView(new BuyComplete(ora, mf), "BuyComplete");
            }
            else
            {
                string id = mf.sendID();
                if(title1.Text != "")
                {
                    ora.buy(id, title1.Text, pub1.Text);
                }
                if(title2.Text != "")
                {
                    ora.buy(id, title2.Text, pub2.Text);
                }
                if(title3.Text != "")
                {
                    ora.buy(id, title3.Text, pub3.Text);
                }
                if(title4.Text != "")
                {
                    ora.buy(id, title4.Text, pub4.Text);
                }
                if(title5.Text != "")
                {
                    ora.buy(id, title5.Text, pub5.Text);
                }
                mf.cleanCart();
                ora.commit();
                mf.controlView(new BuyComplete(ora, mf), "BuyComplete");
            }
        }
    }
}
