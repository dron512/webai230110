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

namespace KBbooks.ui
{
    partial class Recom : UserControl
    {
        DaoOra ora;
        MainForm mf;
        string code1, code2, code3, code4, code5, code6, code7, code8 = "";

        
        public Recom(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            string id = mf.sendID();
            if(ora.lastBuy(id) == "")
            {
                label6.Text = "아직 책을 구매하지 않으셨네요. 책을 구매하고 추천 마법사의 추천을 받아보세요.";
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic7.Visible = false;
                pic8.Visible = false;
                title1.Visible = false;
                title2.Visible = false;
                title3.Visible = false;
                title4.Visible = false;
                title5.Visible = false;
                title6.Visible = false;
                title7.Visible = false;
                title8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                return;
            }
            label9.Visible = true;
            label10.Visible = true;
            label6.Text = "같은 책을 구매하신 분들은 이런 책을 샀어요";
            List<string> books = ora.getFirstRecom(ora.lastBuy(id));
            int i = 0;
            if(i<books.Count)
            {
                pic1.Visible = true;
                title1.Visible = true;
                List<Book> info = new List<Book>(ora.getBookInfo(books[i]));
                title1.Text = info[0].Title;
                code1 = info[0].Code;
                ora.getImg(pic1, books[i]);
            }
            if(i + 1 < books.Count)
            {
                pic2.Visible = true;
                title2.Visible = true;
                List<Book> info = ora.getBookInfo(books[i + 1]);
                title2.Text = info[0].Title;
                code2 = info[0].Code;
                ora.getImg(pic2, books[i + 1]);
            }
            if(i + 2 < books.Count)
            {
                pic3.Visible = true;
                title3.Visible = true;
                List<Book> info = ora.getBookInfo(books[i + 2]);
                title3.Text = info[0].Title;
                code3 = info[0].Code;
                ora.getImg(pic3, books[i + 2]);
            }
            if(i + 3 < books.Count)
            {
                pic4.Visible = true;
                title4.Visible = true;
                List<Book> info = ora.getBookInfo(books[i + 3]);
                title4.Text = info[0].Title;
                code4 = info[0].Code;
                ora.getImg(pic4, books[i + 3]);
            }

            string genre = ora.getLikeGenre(id);
            label9.Text = $"선호하시는 '{genre}' 장르의 베스트셀러입니다.";
            List<string> books2 = ora.getLikeRecom(ora.getLikeGenre(id));
            int j = 0;
            if (j < books2.Count)
            {
                pic5.Visible = true;
                title5.Visible = true;
                List<Book> info = new List<Book>(ora.getBookInfo(books2[j]));
                title5.Text = info[0].Title;
                code5 = info[0].Code;
                ora.getImg(pic5, books2[j]);
            }
            if (j + 1 < books2.Count)
            {
                pic6.Visible = true;
                title6.Visible = true;
                List<Book> info = ora.getBookInfo(books2[j + 1]);
                title6.Text = info[0].Title;
                code6 = info[0].Code;
                ora.getImg(pic6, books2[j + 1]);
            }
            if (j + 2 < books2.Count)
            {
                pic7.Visible = true;
                title7.Visible = true;
                List<Book> info = ora.getBookInfo(books2[j + 2]);
                title7.Text = info[0].Title;
                code7 = info[0].Code;
                ora.getImg(pic7, books2[j + 2]);
            }
            if (j + 3 < books2.Count)
            {
                pic8.Visible = true;
                title8.Visible = true;
                List<Book> info = ora.getBookInfo(books2[j + 3]);
                title8.Text = info[0].Title;
                code8 = info[0].Code;
                ora.getImg(pic8, books2[j + 3]);
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic1.Image, mf, code1, 4), "Bookinfo");
        }
        private void pic7_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic7.Image, mf, code7, 4), "Bookinfo");
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic8.Image, mf, code8, 4), "Bookinfo");
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic6.Image, mf, code6, 4), "Bookinfo");
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic5.Image, mf, code5, 4), "Bookinfo");
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic4.Image, mf, code4, 4), "Bookinfo");
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic3.Image, mf, code3, 4), "Bookinfo");
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic2.Image, mf, code2, 4), "Bookinfo");
        }

    }
}
