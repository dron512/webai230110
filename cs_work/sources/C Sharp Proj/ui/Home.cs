using KBbooks.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KBbooks.ui
{
    
    partial class Home : UserControl
    {
        DaoOra ora;
        MainForm mf;
        List<Book> books;
        string tcode1, tcode2, tcode3, tcode4, bcode1, bcode2, bcode3, bcode4;
        const string UC_BOOKINFO = "Bookinfo";
        public Home(DaoOra ora, MainForm mf, List<Book> today)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            this.books = today;
            showToday(books);
            showBest();
        }
        private void showToday(List<Book> today)
        {
            int i = 0;
            if (i < today.Count)
            {
                ttitle1.Text = today[i].Title.ToString();
                tauthor.Text = today[i].Author.ToString();
                tpub.Text = today[i].Pub.ToString();
                tdate.Text = today[i].Date.ToString().Substring(0, 10);
                tprice.Text = "판매가: " + int.Parse(today[i].Price).ToString("#,##0") + "원";
                tcode1 = today[i].Code.ToString();
                ora.getImg(tpic1, tcode1);
            }
            if (i + 1 < today.Count)
            {
                ttitle2.Text = today[i + 1].Title.ToString();
                tcode2 = today[i+1].Code.ToString();
                ora.getImg(tpic2, tcode2);
            }
            if (i + 2 < today.Count)
            {
                ttitle3.Text = today[i + 2].Title.ToString();
                tcode3 = today[i+2].Code.ToString();
                ora.getImg(tpic3, tcode3);
            }
            if (i + 3 < today.Count)
            {
                ttitle4.Text = today[i + 3].Title.ToString();
                tcode4 = today[i+3].Code.ToString();
                ora.getImg(tpic4, tcode4);
            }
        }
        private void showBest()
        {
            OracleDataReader dr = ora.homeBest();
            List<Book> best = new List<Book>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    best.Add(new Book(dr["book_code"].ToString(), dr["book_title"].ToString(), dr["book_author"].ToString(), dr["book_pub"].ToString(), dr["book_date"].ToString(), dr["book_price"].ToString()));
                }
            }
            int i = 0;
            if (i < best.Count)
            {
                btitle1.Text = best[i].Title.ToString();
                bauthor.Text = best[i].Author.ToString();
                bpub.Text = best[i].Pub.ToString();
                bdate.Text = best[i].Date.ToString().Substring(0, 10);
                bprice.Text = "판매가: " + int.Parse(best[i].Price).ToString("#,##0") + "원";
                bcode1 = best[i].Code.ToString();
                ora.getImg(bpic1, bcode1);
            }
            if (i + 1 < best.Count)
            {
                btitle2.Text = best[i + 1].Title.ToString();
                bcode2 = best[i + 1].Code.ToString();
                ora.getImg(bpic2, bcode2);
            }
            if (i + 2 < best.Count)
            {
                btitle3.Text = best[i + 2].Title.ToString();
                bcode3 = best[i + 2].Code.ToString();
                ora.getImg(bpic3, bcode3);
            }
            if (i + 3 < best.Count)
            {
                btitle4.Text = best[i + 3].Title.ToString();
                bcode4 = best[i + 3].Code.ToString();
                ora.getImg(bpic4, bcode4);
            }
            dr.Close();
        }

        private void ttitle1_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, tpic1.Image, mf, tcode1), UC_BOOKINFO);
        }
        private void ttitle2_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, tpic2.Image, mf, tcode2), UC_BOOKINFO);
        }
        private void ttitle3_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, tpic3.Image, mf, tcode3), UC_BOOKINFO);
        }
        private void ttitle4_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, tpic4.Image, mf,tcode4), UC_BOOKINFO);
        }
        private void btitle1_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, bpic1.Image, mf, bcode1), UC_BOOKINFO);
        }
        private void btitle2_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, bpic2.Image, mf, bcode2), UC_BOOKINFO);
        }
        private void btitle3_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, bpic3.Image, mf, bcode3), UC_BOOKINFO);
        }
        private void btitle4_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, bpic4.Image, mf, bcode4), UC_BOOKINFO);
        }
    }
}
