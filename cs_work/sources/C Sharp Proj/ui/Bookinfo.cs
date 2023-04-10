using KBbooks.Properties;
using KBbooks.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui
{
    partial class Bookinfo : UserControl
    {
        DaoOra ora;
        string title, author, pub, date, price, sales, genre, rank, find, code;
        int page;
        MainForm mf;
        Image img;
        List<Review> rev;
        int i = 0;
        int count = 0;
        int searchResult = 0;
        const string UC_BEST = "Best";
        const string UC_SEARCH = "Search";
        const string UC_HOME = "Home";
        const string UC_NEWBOOK = "Newbook";

        public Bookinfo(DaoOra ora, Image img, string rank, string title, string author, string pub, string date, string price, string sales, string genre, string page, MainForm mf, int searchResult)
        {
            InitializeComponent();
            rev = null;
            i = 0;
            count = 0;
            this.ora = ora;
            this.img = img;
            this.rank = rank;
            this.title = title;
            this.author = author;
            this.pub = pub;
            this.date = date;
            this.price = price;
            this.sales = sales;
            this.genre = genre;
            string printgenre = "";
            if (genre == "novel")
            {
                printgenre = "소설";
            }
            else if (genre == "inmun")
            {
                printgenre = "인문";
            }
            else if (genre == "dev")
            {
                printgenre = "자기계발";
            }
            else if (genre == "finance")
            {
                printgenre = "경제";
            }
            else if (genre == "comics")
            {
                printgenre = "만화";
            }
            else if (genre == "all")
            {
                printgenre = "베스트셀러";
            }
            this.page = int.Parse(page);
            this.mf = mf;
            this.searchResult = searchResult;
            if (img != null )
            {
                pic1.Image = img;
            }
            if (searchResult == 3)
            {
                rank1.Text = "";
            }
            else
            {
                rank1.Text = printgenre + " " + rank + "위";
            }
            title1.Text = title;
            author1.Text = author;
            pub1.Text = pub;
            date1.Text = date;
            price1.Text = price.Substring(5);
            sales1.Text = sales.Substring(6);
            panel1.Visible = false;
            showReview(title, pub);
        }
        public Bookinfo(DaoOra ora, Image img, string rank, string title, string author, string pub, string date, string price, string sales, string genre, string page, MainForm mf, int searchResult, string find)
        {
            InitializeComponent();
            this.ora = ora;
            this.img = img;
            this.rank = rank;
            this.title = title;
            this.author = author;
            this.pub = pub;
            this.date = date;
            this.price = price;
            this.sales = sales;
            this.genre = genre;
            this.page = int.Parse(page);
            this.mf = mf;
            this.searchResult = searchResult;
            this.find = find;
            if (img != null)
            {
                pic1.Image = img;
            }
            rank1.Text = genre + " " + rank + "위";
            title1.Text = title;
            author1.Text = author;
            pub1.Text = pub;
            date1.Text = date.Substring(0, 10);
            price1.Text = price.Substring(5);
            sales1.Text = sales.Substring(6);
            panel1.Visible = false;
            showReview(title, pub);
        }
        public Bookinfo(DaoOra ora, Image img, MainForm mf, string code)
        {
            InitializeComponent();
            this.ora = ora;
            this.img = img;
            this.code = code;
            this.mf = mf;
            if (img != null)
            {
                pic1.Image = img;
            }
            List<Book> books = ora.getBookInfo(code);
            rank1.Text = "베스트셀러 " + books[0].Rank + "위";
            title1.Text = books[0].Title;
            author1.Text = books[0].Author;
            pub1.Text = books[0].Pub;
            date1.Text = books[0].Date.Substring(0, 10);
            price1.Text = int.Parse(books[0].Price).ToString("#,##0") + "원";
            sales1.Text = books[0].Sale + "권";
            panel1.Visible = false;
            showReview(books[0].Title, books[0].Pub);
            searchResult = 2;
        }
        public Bookinfo(DaoOra ora, Image img, MainForm mf, string code, int num)
        {
            InitializeComponent();
            this.ora = ora;
            this.img = img;
            this.code = code;
            this.mf = mf;
            if (img != null)
            {
                pic1.Image = img;
            }
            List<Book> books = ora.getBookInfo(code);
            rank1.Text = "베스트셀러 " + books[0].Rank + "위";
            title1.Text = books[0].Title;
            author1.Text = books[0].Author;
            pub1.Text = books[0].Pub;
            date1.Text = books[0].Date.Substring(0, 10);
            price1.Text = int.Parse(books[0].Price).ToString("#,##0") + "원";
            sales1.Text = books[0].Sale + "권";
            panel1.Visible = false;
            showReview(books[0].Title, books[0].Pub);
            searchResult = num;
        }

        private void showReview(string title, string pub)
        {
            OracleDataReader dr = ora.getReview(title, pub);
            rev = new List<Review>();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    rev.Add(new Review(dr["rev_score"].ToString(), dr["rev_content"].ToString()));
                    count++;
                }
            }
            dr.Close();
            makeInvisible();
            if(i<rev.Count)
            {
                printStar(star1, int.Parse(rev[i].Score));
                cont1.Text = rev[i].Content;
                star1.Visible = true;
            }
            if (i + 1 < rev.Count)
            {
                printStar(star2, int.Parse(rev[i + 1].Score));
                cont2.Text = rev[i+1].Content;
                star2.Visible = true;
            }
            if(i + 2 < rev.Count)
            {
                printStar(star3, int.Parse(rev[i + 2].Score));
                cont3.Text = rev[i + 2].Content;
                star3.Visible = true;
            }
            if (i + 3 < rev.Count)
            {
                printStar(star4, int.Parse(rev[i + 3].Score));
                cont4.Text = rev[i + 3].Content;
                star4.Visible = true;
            }
            if (i + 4 < rev.Count)
            {
                printStar(star5, int.Parse(rev[i + 4].Score));
                cont5.Text = rev[i + 4].Content;
                star5.Visible = true;
            }
        }
        private void printStar(PictureBox pb, int score)
        {
            if(score == 1)
            {
                pb.Image = Resources.별1;
            }
            else if(score == 2)
            {
                pb.Image = Resources.별2;
            }
            else if(score == 3)
            {
                pb.Image = Resources.별3;
            }
            else if(score == 4)
            {
                pb.Image = Resources.별4;
            }
            else if(score == 5)
            {
                pb.Image = Resources.별5;
            }
        }
        private void makeInvisible()
        {
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;
            cont1.Text = "";
            cont2.Text = "";
            cont3.Text = "";
            cont4.Text = "";
            cont5.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(searchResult == 0)
            {
                mf.controlView(new Best(ora, genre, mf, page - 1), UC_BEST);
            }
            else if(searchResult == 1)
            {
                mf.controlView(new Search(ora, find, mf, page), UC_SEARCH);
            }
            else if(searchResult == 3)
            {
                mf.controlView(new Newbook(ora, genre, mf, page - 1), UC_NEWBOOK);
            }
            else if(searchResult == 4)
            {
                mf.controlView(new Recom(ora, mf), "Recom");
            }
            else if(searchResult == 5)
            {
                mf.controlView(new MyOrder(ora, mf), "MyOrder");
            }
            else
            {
                mf.controlView(new Home(ora, mf, mf.getToday()), UC_HOME);
            }
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            int max = count / 5;
            if(count % 5 > 0)
            {
                max++;
            }
            if (int.Parse(page1.Text) < max)
            {
                makeInvisible();
                page1.Text = (int.Parse(page1.Text) + 1).ToString();
                i = i + 5;
                if (i < rev.Count)
                {
                    printStar(star1, int.Parse(rev[i].Score));
                    cont1.Text = rev[i].Content;
                    star1.Visible = true;
                }
                if (i + 1 < rev.Count)
                {
                    printStar(star2, int.Parse(rev[i + 1].Score));
                    cont2.Text = rev[i + 1].Content;
                    star2.Visible = true;
                }
                if (i + 2 < rev.Count)
                {
                    printStar(star3, int.Parse(rev[i + 2].Score));
                    cont3.Text = rev[i + 2].Content;
                    star3.Visible = true;
                }
                if (i + 3 < rev.Count)
                {
                    printStar(star4, int.Parse(rev[i + 3].Score));
                    cont4.Text = rev[i + 3].Content;
                    star4.Visible = true;
                }
                if (i + 4 < rev.Count)
                {
                    printStar(star5, int.Parse(rev[i + 4].Score));
                    cont5.Text = rev[i + 4].Content;
                    star5.Visible = true;
                }
            }
        }
        private void prevBtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(page1.Text) > 1)
            {
                makeInvisible();
                page1.Text = (int.Parse(page1.Text) - 1).ToString();
                i = i - 5;
                if (i < rev.Count)
                {
                    printStar(star1, int.Parse(rev[i].Score));
                    cont1.Text = rev[i].Content;
                    star1.Visible = true;
                }
                if (i + 1 < rev.Count)
                {
                    printStar(star2, int.Parse(rev[i + 1].Score));
                    cont2.Text = rev[i + 1].Content;
                    star2.Visible = true;
                }
                if (i + 2 < rev.Count)
                {
                    printStar(star3, int.Parse(rev[i + 2].Score));
                    cont3.Text = rev[i + 2].Content;
                    star3.Visible = true;
                }
                if (i + 3 < rev.Count)
                {
                    printStar(star4, int.Parse(rev[i + 3].Score));
                    cont4.Text = rev[i + 3].Content;
                    star4.Visible = true;
                }
                if (i + 4 < rev.Count)
                {
                    printStar(star5, int.Parse(rev[i + 4].Score));
                    cont5.Text = rev[i + 4].Content;
                    star5.Visible = true;
                }
            }
        }
        private void buy_Click(object sender, EventArgs e)
        {
            string id = mf.sendID();
            string code = ora.getBookCode(title1.Text, pub1.Text);
            List<Member> mem = new List<Member>(ora.GetMember(id));
            if (id != null)
            {
                mf.controlView(new Buy(ora, mf, code, mem), "Buy");
            }
            else
            {
                mf.controlView(new Login(ora, mf), "Login");
            }
        }
        private void cart_Click(object sender, EventArgs e)
        {
            string code = ora.getBookCode(title1.Text, pub1.Text);
            panel1.Visible = true;
            if (mf.getCart().Count > 4)
            {
                cartmes1.Text = "카트가 가득 찼습니다.";
            }
            else if (!mf.getCart().Contains(code))
            {
                cartmes1.Text = "카트에 담았습니다.";
                mf.getInCart(code);
            }
            else if (mf.getCart().Contains(code))
            {
                cartmes1.Text = "이미 담긴 책입니다.";
            }
        }

        private void lsee1_Click(object sender, EventArgs e)
        {
            mf.controlView(new Cart(ora, mf, mf.getCart()), "Cart");
        }

        private void lclose1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
