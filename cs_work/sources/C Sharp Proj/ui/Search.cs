using KBbooks.util;
using Oracle.ManagedDataAccess.Client;
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
    partial class Search : UserControl
    {
        DaoOra ora = null;
        MainForm mf = null;
        const string UC_BOOKINFO = "Bookinfo";
        int pages = 0;
        int i;
        List<Book> books;
        string find = "";
        string rank1 = "", rank2 = "", rank3 = "", rank4 = "", rank5 = "", rank6 = "";
        string genre1 = "", genre2 = "", genre3 = "", genre4 = "", genre5 = "", genre6 = "";
        public Search(DaoOra ora, string find, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            this.find = find;
            books = new List<Book>();
            read_result(find);
            string finditem = "";
            if(find.Length > 30)
            {
                finditem = find.Substring(0, 30) + "...";
            }
            else
            {
                finditem = find;
            }
            label6.Text = $"\"{finditem}\" 검색 결과 총 {books.Count} 건";
            i = 0;
            show_result();
        }
        public Search(DaoOra ora, string find, MainForm mf, int page)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            this.find = find;
            books = new List<Book>();
            i = (page-1) * 6;
            read_result(find);
            show_result(page-1);
        }

        private void read_result(string find)
        {
            OracleDataReader dr = ora.searchDB(find);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    books.Add(new Book(dr["순위"].ToString(), dr["book_code"].ToString(), dr["book_title"].ToString(), dr["book_author"].ToString(), dr["book_pub"].ToString(), dr["book_date"].ToString(), dr["book_price"].ToString(), dr["book_genre"].ToString(), dr["판매부수"].ToString()));
                }
                pages = books.Count / 6;
                try
                {
                    if (books.Count % (pages * 6) > 0)
                    {
                        pages++;
                    }
                }
                catch (DivideByZeroException) {}
            }
            dr.Close();
        }

        public void show_result()
        {
            makeInvisible();
            if(books.Count == 0)
            {
                title1.Text = "검색 결과가 없습니다.";
            }
            if (i < books.Count)
            {
                title1.Visible = true;
                author1.Visible = true;
                pub1.Visible = true;
                date1.Visible = true;
                price1.Visible = true;
                sales1.Visible = true;
                pic1.Visible = true;
                rank1 = books[i].Rank.ToString();
                title1.Text = books[i].Title.ToString();
                author1.Text = books[i].Author.ToString();
                pub1.Text = books[i].Pub.ToString();
                date1.Text = books[i].Date.ToString().Substring(0, 10);
                price1.Text = "판매가: " + int.Parse(books[i].Price).ToString("#,##0") + "원";
                sales1.Text = "판매부수: " + books[i].Sale.ToString() + "권";
                genre1 = books[i].Genre.ToString();
                buy1.Visible = true;
                cart1.Visible = true;
            }
            if (i+1 < books.Count)
            {
                title2.Visible = true;
                author2.Visible = true;
                pub2.Visible = true;
                date2.Visible = true;
                price2.Visible = true;
                sales2.Visible = true;
                pic2.Visible = true;
                rank2 = books[i + 1].Rank.ToString();
                title2.Text = books[i + 1].Title.ToString();
                author2.Text = books[i+1].Author.ToString();
                pub2.Text = books[i+1].Pub.ToString();
                date2.Text = books[i+1].Date.ToString().Substring(0, 10);
                price2.Text = "판매가: " + int.Parse(books[i+1].Price).ToString("#,##0") + "원";
                sales2.Text = "판매부수: " + books[i + 1].Sale.ToString() + "권";
                genre2 = books[i+1].Genre.ToString();
                buy2.Visible = true;
                cart2.Visible = true;
            }
            if (i + 2 < books.Count)
            {
                title3.Visible = true;
                author3.Visible = true;
                pub3.Visible = true;
                date3.Visible = true;
                price3.Visible = true;
                sales3.Visible = true;
                pic3.Visible = true;
                rank3 = books[i + 2].Rank.ToString();
                title3.Text = books[i + 2].Title.ToString();
                author3.Text = books[i+2].Author.ToString();
                pub3.Text = books[i+2].Pub.ToString();
                date3.Text = books[i+2].Date.ToString().Substring(0, 10);
                price3.Text = "판매가: " + int.Parse(books[i + 2].Price).ToString("#,##0") + "원";
                sales3.Text = "판매부수: " + books[i + 2].Sale.ToString() + "권";
                genre3 = books[i+2].Genre.ToString();
                buy3.Visible = true;
                cart3.Visible = true;
            }
            if (i + 3 < books.Count)
            {
                title4.Visible = true;
                author4.Visible = true;
                pub4.Visible = true;
                date4.Visible = true;
                price4.Visible = true;
                sales4.Visible = true;
                pic4.Visible = true;
                rank4 = books[i + 3].Rank.ToString();
                title4.Text = books[i + 3].Title.ToString();
                author4.Text = books[i+3].Author.ToString();
                pub4.Text = books[i+3].Pub.ToString();
                date4.Text = books[i+3].Date.ToString().Substring(0, 10);
                price4.Text = "판매가: " + int.Parse(books[i + 3].Price).ToString("#,##0") + "원";
                sales4.Text = "판매부수: " + books[i + 3].Sale.ToString() + "권";
                genre4 = books[i+3].Genre.ToString();
                buy4.Visible = true;
                cart4.Visible = true;
            }
            if (i + 4 < books.Count)
            {
                title5.Visible = true;
                author5.Visible = true;
                pub5.Visible = true;
                date5.Visible = true;
                price5.Visible = true;
                sales5.Visible = true;
                pic5.Visible = true;
                rank5 = books[i + 4].Rank.ToString();
                title5.Text = books[i + 4].Title.ToString();
                author5.Text = books[i+4].Author.ToString();
                pub5.Text = books[i+4].Pub.ToString();
                date5.Text = books[i+4].Date.ToString().Substring(0, 10);
                price5.Text = "판매가: " + int.Parse(books[i + 4].Price).ToString("#,##0") + "원";
                sales5.Text = "판매부수: " + books[i + 4].Sale.ToString() + "권";
                genre5 = books[i+4].Genre.ToString();
                buy5.Visible = true;
                cart5.Visible = true;
            }
            if (i + 5 < books.Count)
            {
                title6.Visible = true;
                author6.Visible = true;
                pub6.Visible = true;
                date6.Visible = true;
                price6.Visible = true;
                sales6.Visible = true;
                pic6.Visible = true;
                rank6 = books[i + 5].Rank.ToString();
                title6.Text = books[i + 5].Title.ToString();
                author6.Text = books[i+5].Author.ToString();
                pub6.Text = books[i+5].Pub.ToString();
                date6.Text = books[i+5].Date.ToString().Substring(0, 10);
                price6.Text = "판매가: " + int.Parse(books[i + 5].Price).ToString("#,##0") + "원";
                sales6.Text = "판매부수: " + books[i + 5].Sale.ToString() + "권";
                genre6 = books[i+5].Genre.ToString();
                buy6.Visible = true;
                cart6.Visible = true;
            }
            showImage();
        }
        public void show_result(int page)
        {
            makeInvisible();
            int i = 0 + (page * 6);
            this.page.Text = (page + 1).ToString();
            if (books.Count == 0)
            {
                title1.Text = "검색 결과가 없습니다.";
            }
            if (i < books.Count)
            {
                title1.Visible = true;
                author1.Visible = true;
                pub1.Visible = true;
                date1.Visible = true;
                price1.Visible = true;
                sales1.Visible = true;
                pic1.Visible = true;
                rank1 = books[i].Rank.ToString();
                title1.Text = books[i].Title.ToString();
                author1.Text = books[i].Author.ToString();
                pub1.Text = books[i].Pub.ToString();
                date1.Text = books[i].Date.ToString().Substring(0, 10);
                price1.Text = "판매가: " + int.Parse(books[i].Price).ToString("#,##0") + "원";
                sales1.Text = "판매부수: " + books[i].Sale.ToString() + "권";
                genre1 = books[i].Genre.ToString();
                buy1.Visible = true;
                cart1.Visible = true;
            }
            if (i + 1 < books.Count)
            {
                title2.Visible = true;
                author2.Visible = true;
                pub2.Visible = true;
                date2.Visible = true;
                price2.Visible = true;
                sales2.Visible = true;
                pic2.Visible = true;
                rank2 = books[i + 1].Rank.ToString();
                title2.Text = books[i + 1].Title.ToString();
                author2.Text = books[i + 1].Author.ToString();
                pub2.Text = books[i + 1].Pub.ToString();
                date2.Text = books[i + 1].Date.ToString().Substring(0, 10);
                price2.Text = "판매가: " + int.Parse(books[i + 1].Price).ToString("#,##0") + "원";
                sales2.Text = "판매부수: " + books[i + 1].Sale.ToString() + "권";
                genre2 = books[i + 1].Genre.ToString();
                buy2.Visible = true;
                cart2.Visible = true;
            }
            if (i + 2 < books.Count)
            {
                title3.Visible = true;
                author3.Visible = true;
                pub3.Visible = true;
                date3.Visible = true;
                price3.Visible = true;
                sales3.Visible = true;
                pic3.Visible = true;
                rank3 = books[i + 2].Rank.ToString();
                title3.Text = books[i + 2].Title.ToString();
                author3.Text = books[i + 2].Author.ToString();
                pub3.Text = books[i + 2].Pub.ToString();
                date3.Text = books[i + 2].Date.ToString().Substring(0, 10);
                price3.Text = "판매가: " + int.Parse(books[i + 2].Price).ToString("#,##0") + "원";
                sales3.Text = "판매부수: " + books[i + 2].Sale.ToString() + "권";
                genre3 = books[i + 2].Genre.ToString();
                buy3.Visible = true;
                cart3.Visible = true;
            }
            if (i + 3 < books.Count)
            {
                title4.Visible = true;
                author4.Visible = true;
                pub4.Visible = true;
                date4.Visible = true;
                price4.Visible = true;
                sales4.Visible = true;
                pic4.Visible = true;
                rank4 = books[i + 3].Rank.ToString();
                title4.Text = books[i + 3].Title.ToString();
                author4.Text = books[i + 3].Author.ToString();
                pub4.Text = books[i + 3].Pub.ToString();
                date4.Text = books[i + 3].Date.ToString().Substring(0, 10);
                price4.Text = "판매가: " + int.Parse(books[i + 3].Price).ToString("#,##0") + "원";
                sales4.Text = "판매부수: " + books[i + 3].Sale.ToString() + "권";
                genre4 = books[i + 3].Genre.ToString();
                buy4.Visible = true;
                cart4.Visible = true;
            }
            if (i + 4 < books.Count)
            {
                title5.Visible = true;
                author5.Visible = true;
                pub5.Visible = true;
                date5.Visible = true;
                price5.Visible = true;
                sales5.Visible = true;
                pic5.Visible = true;
                rank5 = books[i + 4].Rank.ToString();
                title5.Text = books[i + 4].Title.ToString();
                author5.Text = books[i + 4].Author.ToString();
                pub5.Text = books[i + 4].Pub.ToString();
                date5.Text = books[i + 4].Date.ToString().Substring(0, 10);
                price5.Text = "판매가: " + int.Parse(books[i + 4].Price).ToString("#,##0") + "원";
                sales5.Text = "판매부수: " + books[i + 4].Sale.ToString() + "권";
                genre5 = books[i + 4].Genre.ToString();
                buy5.Visible = true;
                cart5.Visible = true;
            }
            if (i + 5 < books.Count)
            {
                title6.Visible = true;
                author6.Visible = true;
                pub6.Visible = true;
                date6.Visible = true;
                price6.Visible = true;
                sales6.Visible = true;
                pic6.Visible = true;
                rank6 = books[i + 5].Rank.ToString();
                title6.Text = books[i + 5].Title.ToString();
                author6.Text = books[i + 5].Author.ToString();
                pub6.Text = books[i + 5].Pub.ToString();
                date6.Text = books[i + 5].Date.ToString().Substring(0, 10);
                price6.Text = "판매가: " + int.Parse(books[i + 5].Price).ToString("#,##0") + "원";
                sales6.Text = "판매부수: " + books[i + 5].Sale.ToString() + "권";
                genre6 = books[i + 5].Genre.ToString();
                buy6.Visible = true;
                cart6.Visible = true;
            }
            showImage();
        }
        private void showImage()
        {
            
            if (title1.Text != "")
            {
                ora.getImg(pic1, title1.Text, pub1.Text);
            }
            if (title2.Text != "")
            {
                ora.getImg(pic2, title2.Text, pub2.Text);
            }
            if (title3.Text != "")
            {
                ora.getImg(pic3, title3.Text, pub3.Text);
            }
            if (title4.Text != "")
            {
                ora.getImg(pic4, title4.Text, pub4.Text);
            }
            if (title5.Text != "")
            {
                ora.getImg(pic5, title5.Text, pub5.Text);
            }
            if (title6.Text != "")
            {
                ora.getImg(pic6, title6.Text, pub6.Text);
            }
        }
        private void nextPage_Click(object sender, EventArgs e)
        {
            int max = pages;
            if (int.Parse(page.Text) < max)
            {
                i = i + 6;
                page.Text = (int.Parse(page.Text) + 1).ToString();
                show_result();
            }
        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            if (int.Parse(page.Text) > 1)
            {
                i = i - 6;
                page.Text = (int.Parse(page.Text) - 1).ToString();
                show_result();
            }
        }
        private void title1_Click(object sender, EventArgs e)
        {
            if (title1.Text != "")
            {
                mf.controlView(new Bookinfo(ora, pic1.Image, rank1, title1.Text, author1.Text, pub1.Text, date1.Text, price1.Text, sales1.Text, genre1, page.Text, mf, 1, find), UC_BOOKINFO);
            }
        }

        private void title2_Click(object sender, EventArgs e)
        {
            if (title2.Text != "")
            {
                mf.controlView(new Bookinfo(ora, pic2.Image, rank2, title2.Text, author2.Text, pub2.Text, date2.Text, price2.Text, sales2.Text, genre2, page.Text, mf, 1, find), UC_BOOKINFO);
            }
        }

        private void title3_Click(object sender, EventArgs e)
        {
            if (title3.Text != "")
            {
                mf.controlView(new Bookinfo(ora, pic3.Image, rank3, title3.Text, author3.Text, pub3.Text, date3.Text, price3.Text, sales3.Text, genre3, page.Text, mf, 1, find), UC_BOOKINFO);
            }
        }

        private void title4_Click(object sender, EventArgs e)
        {
            if (title4.Text != "")
            {
                mf.controlView(new Bookinfo(ora, pic4.Image, rank4, title4.Text, author4.Text, pub4.Text, date4.Text, price4.Text, sales4.Text, genre4, page.Text, mf, 1, find), UC_BOOKINFO);
            }
        }

        private void title5_Click(object sender, EventArgs e)
        {
            if (title5.Text != "")
            {
                mf.controlView(new Bookinfo(ora, pic5.Image, rank5, title5.Text, author5.Text, pub5.Text, date5.Text, price5.Text, sales5.Text, genre5, page.Text, mf, 1, find), UC_BOOKINFO);
            }
        }

        private void title6_Click(object sender, EventArgs e)
        {
            if (title6.Text != "")
            {
                mf.controlView(new Bookinfo(ora, pic6.Image, rank6, title6.Text, author6.Text, pub6.Text, date6.Text, price6.Text, sales6.Text, genre6, page.Text, mf, 1, find), UC_BOOKINFO);
            }
        }
        private void buy1_Click(object sender, EventArgs e)
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
        private void buy2_Click(object sender, EventArgs e)
        {
            string id = mf.sendID();
            string code = ora.getBookCode(title2.Text, pub2.Text);
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
        private void buy3_Click(object sender, EventArgs e)
        {
            string id = mf.sendID();
            string code = ora.getBookCode(title3.Text, pub3.Text);
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
        private void buy4_Click(object sender, EventArgs e)
        {
            string id = mf.sendID();
            string code = ora.getBookCode(title4.Text, pub4.Text);
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
        private void buy5_Click(object sender, EventArgs e)
        {
            string id = mf.sendID();
            string code = ora.getBookCode(title5.Text, pub5.Text);
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
        private void buy6_Click(object sender, EventArgs e)
        {
            string id = mf.sendID();
            string code = ora.getBookCode(title6.Text, pub6.Text);
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

        private void cartP1_Click(object sender, EventArgs e)
        {
            string code = ora.getBookCode(title1.Text, pub1.Text);
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
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

        private void cart2_Click(object sender, EventArgs e)
        {
            string code = ora.getBookCode(title2.Text, pub2.Text);
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            if (mf.getCart().Count > 4)
            {
                cartmes2.Text = "카트가 가득 찼습니다.";
            }
            else if (!mf.getCart().Contains(code))
            {
                cartmes2.Text = "카트에 담았습니다.";
                mf.getInCart(code);
            }
            else if (mf.getCart().Contains(code))
            {
                cartmes2.Text = "이미 담긴 책입니다.";
            }
        }

        private void cart3_Click(object sender, EventArgs e)
        {
            string code = ora.getBookCode(title3.Text, pub3.Text);
            panel3.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            if (mf.getCart().Count > 4)
            {
                cartmes3.Text = "카트가 가득 찼습니다.";
            }
            else if (!mf.getCart().Contains(code))
            {
                cartmes3.Text = "카트에 담았습니다.";
                mf.getInCart(code);
            }
            else if (mf.getCart().Contains(code))
            {
                cartmes3.Text = "이미 담긴 책입니다.";
            }
        }

        private void cart4_Click(object sender, EventArgs e)
        {
            string code = ora.getBookCode(title4.Text, pub4.Text);
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            if (mf.getCart().Count > 4)
            {
                cartmes4.Text = "카트가 가득 찼습니다.";
            }
            else if (!mf.getCart().Contains(code))
            {
                cartmes4.Text = "카트에 담았습니다.";
                mf.getInCart(code);
            }
            else if (mf.getCart().Contains(code))
            {
                cartmes4.Text = "이미 담긴 책입니다.";
            }
        }

        private void cart5_Click(object sender, EventArgs e)
        {
            string code = ora.getBookCode(title5.Text, pub5.Text);
            panel5.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Visible = false;
            panel6.Visible = false;

            if (mf.getCart().Count > 4)
            {
                cartmes5.Text = "카트가 가득 찼습니다.";
            }
            else if (!mf.getCart().Contains(code))
            {
                cartmes5.Text = "카트에 담았습니다.";
                mf.getInCart(code);
            }
            else if (mf.getCart().Contains(code))
            {
                cartmes5.Text = "이미 담긴 책입니다.";
            }
        }

        private void cart6_Click(object sender, EventArgs e)
        {
            string code = ora.getBookCode(title6.Text, pub6.Text);
            panel6.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel1.Visible = false;

            if (mf.getCart().Count > 4)
            {
                cartmes6.Text = "카트가 가득 찼습니다.";
            }
            else if (!mf.getCart().Contains(code))
            {
                cartmes6.Text = "카트에 담았습니다.";
                mf.getInCart(code);
            }
            else if (mf.getCart().Contains(code))
            {
                cartmes6.Text = "이미 담긴 책입니다.";
            }
        }
        private void makeInvisible()
        {
            pic1.Image = null;
            pic2.Image = null;
            pic3.Image = null;
            pic4.Image = null;
            pic5.Image = null;
            pic6.Image = null;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            title1.Text = "";
            title2.Text = "";
            title3.Text = "";
            title4.Text = "";
            title5.Text = "";
            title6.Text = "";
            author1.Text = "";
            author2.Text = "";
            author3.Text = "";
            author4.Text = "";
            author5.Text = "";
            author6.Text = "";
            pub1.Text = "";
            pub2.Text = "";
            pub3.Text = "";
            pub4.Text = "";
            pub5.Text = "";
            pub6.Text = "";
            date1.Text = "";
            date2.Text = "";
            date3.Text = "";
            date4.Text = "";
            date5.Text = "";
            date6.Text = "";
            price1.Text = "";
            price2.Text = "";
            price3.Text = "";
            price4.Text = "";
            price5.Text = "";
            price6.Text = "";
            sales1.Text = "";
            sales2.Text = "";
            sales3.Text = "";
            sales4.Text = "";
            sales5.Text = "";
            sales6.Text = "";
            title1.Visible = false;
            author1.Visible = false;
            pub1.Visible = false;
            date1.Visible = false;
            price1.Visible = false;
            sales1.Visible = false;
            pic1.Visible = false;
            title2.Visible = false;
            author2.Visible = false;
            pub2.Visible = false;
            date2.Visible = false;
            price2.Visible = false;
            sales2.Visible = false;
            pic2.Visible = false;
            title3.Visible = false;
            author3.Visible = false;
            pub3.Visible = false;
            date3.Visible = false;
            price3.Visible = false;
            sales3.Visible = false;
            pic3.Visible = false;
            title4.Visible = false;
            author4.Visible = false;
            pub4.Visible = false;
            date4.Visible = false;
            price4.Visible = false;
            sales4.Visible = false;
            pic4.Visible = false;
            title5.Visible = false;
            author5.Visible = false;
            pub5.Visible = false;
            date5.Visible = false;
            price5.Visible = false;
            sales5.Visible = false;
            pic5.Visible = false;
            title6.Visible = false;
            author6.Visible = false;
            pub6.Visible = false;
            date6.Visible = false;
            price6.Visible = false;
            sales6.Visible = false;
            pic6.Visible = false;
            buy1.Visible = false;
            buy2.Visible = false;
            buy3.Visible = false;
            buy4.Visible = false;
            buy5.Visible = false;
            buy6.Visible = false;
            cart1.Visible = false;
            cart2.Visible = false;
            cart3.Visible = false;
            cart4.Visible = false;
            cart5.Visible = false;
            cart6.Visible = false;
        }
        private void lsee1_Click(object sender, EventArgs e)
        {
            mf.controlView(new Cart(ora, mf, mf.getCart()), "Cart");
        }

        private void lclose1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void lclose2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void lclose3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void lclose4_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void lclose5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void lclose6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }
    }
}
