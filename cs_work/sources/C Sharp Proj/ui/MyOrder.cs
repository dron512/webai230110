using KBbooks.Buy;
using KBbooks.Properties;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace KBbooks.ui
{
    partial class MyOrder : UserControl
    {
        DaoOra ora;
        MainForm mf;
        int i;
        int max;
        int reviewScore;
        List<Order> orders = new List<Order>();
        public MyOrder(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            i = 0;
            max = 0;
            reviewScore = 0;
            getOrders();
            max = orders.Count / 4;
            if((orders.Count % 4) > 0)
            {
                max++;
            }
            showOrderInfo();
        }

        public void showOrderInfo()
        {
            makeInvisible();
            if (i<orders.Count)
            {
                pic1.Visible = true;
                orderNo1.Visible = true;
                title1.Visible = true;
                date1.Visible = true;
                price1.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                ora.getImg(pic1, orders[i].Code);
                orderNo1.Text = $"주문번호: {orders[i].No}";
                title1.Text = orders[i].Title;
                date1.Text = orders[i].Date;
                price1.Text = int.Parse(orders[i].Price).ToString("#,##0") + "원";
                if (ora.isThereReview(orders[i].No) == 0)
                {
                    review1.Visible = true;
                    reviewBtn1.Visible = true;
                }
            }
            if(i + 1 < orders.Count)
            {
                pic2.Visible = true;
                orderNo2.Visible = true;
                title2.Visible = true;
                date2.Visible = true;
                price2.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                ora.getImg(pic2, orders[i+1].Code);
                orderNo2.Text = $"주문번호: {orders[i + 1].No}";
                title2.Text = orders[i + 1].Title;
                date2.Text = orders[i + 1].Date;
                price2.Text = int.Parse(orders[i + 1].Price).ToString("#,##0") + "원";
                if (ora.isThereReview(orders[i+1].No) == 0)
                {
                    review2.Visible = true;
                    reviewBtn2.Visible = true;
                }
            }
            if(i + 2 < orders.Count)
            {
                pic3.Visible = true;
                orderNo3.Visible = true;
                title3.Visible = true;
                date3.Visible = true;
                price3.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                ora.getImg(pic3, orders[i+2].Code);
                orderNo3.Text = $"주문번호: {orders[i + 2].No}";
                title3.Text = orders[i + 2].Title;
                date3.Text = orders[i + 2].Date;
                price3.Text = int.Parse(orders[i + 2].Price).ToString("#,##0") + "원";
                if (ora.isThereReview(orders[i+2].No) == 0)
                {
                    review3.Visible = true;
                    reviewBtn3.Visible = true;
                }
            }
            if(i + 3 < orders.Count)
            {
                pic4.Visible = true;
                orderNo4.Visible = true;
                title4.Visible = true;
                date4.Visible = true;
                price4.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                ora.getImg(pic4, orders[i+3].Code);
                orderNo4.Text = $"주문번호: {orders[i + 3].No}";
                title4.Text = orders[i + 3].Title;
                date4.Text = orders[i + 3].Date;
                price4.Text = int.Parse(orders[i + 3].Price).ToString("#,##0") + "원";
                if (ora.isThereReview(orders[i+3].No) == 0)
                {
                    review4.Visible = true;
                    reviewBtn4.Visible = true;
                }
            }
        }

        public List<Order> getOrders()
        {
            OracleDataReader dr = ora.getOrder(mf.sendID());
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    orders.Add(new Order(dr["sale_code"].ToString(), dr["book_title"].ToString(), dr["sale_date"].ToString().Substring(0, 10), dr["book_price"].ToString(), dr["book_code"].ToString()));
                }
            }
            dr.Close();
            return orders;
        }

        private void makeInvisible()
        {
            panel1.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            review1.Visible = false;
            review2.Visible = false;
            review3.Visible = false;
            review4.Visible = false;
            reviewBtn1.Visible = false;
            reviewBtn2.Visible = false;
            reviewBtn3.Visible = false;
            reviewBtn4.Visible = false;
            pic1.Image = null;
            pic2.Image = null;
            pic3.Image = null;
            pic4.Image = null;
            orderNo1.Text = "";
            orderNo2.Text = "";
            orderNo3.Text = "";
            orderNo4.Text = "";
            title1.Text = "";
            title2.Text = "";
            title3.Text = "";
            title4.Text = "";
            date1.Text = "";
            date2.Text = "";
            date3.Text = "";
            date4.Text = "";
            price1.Text = "";
            price2.Text = "";
            price3.Text = "";
            price4.Text = "";
            pic1.Visible = false;
            orderNo1.Visible = false;
            title1.Visible = false;
            date1.Visible = false;
            price1.Visible = false;
            pic2.Visible = false;
            orderNo2.Visible = false;
            title2.Visible = false;
            date2.Visible = false;
            price2.Visible = false;
            pic3.Visible = false;
            orderNo3.Visible = false;
            title3.Visible = false;
            date3.Visible = false;
            price3.Visible = false;
            pic4.Visible = false;
            orderNo4.Visible = false;
            title4.Visible = false;
            date4.Visible = false;
            price4.Visible = false;
        }

        private void infolabel_MouseEnter(object sender, EventArgs e)
        {
            infolabel.Font = new Font(infolabel.Font.Name, infolabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void infolabel_MouseLeave(object sender, EventArgs e)
        {
            infolabel.Font = new Font(infolabel.Font.Name, infolabel.Font.SizeInPoints, FontStyle.Bold);
        }

        private void orderlabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new MyOrder(ora, mf), "MyOrder");
        }

        private void infolabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new MyInfo(ora, mf), "MyInfo");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void nextBtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(page.Text) < max)
            {
                page.Text = (int.Parse(page.Text) + 1).ToString();
                i = i + 4;
                showOrderInfo();
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(page.Text) > 1)
            {
                page.Text = (int.Parse(page.Text) - 1).ToString();
                i = i - 4;
                showOrderInfo();
            }
        }

        private void title1_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic1.Image, mf, ora.getBookCode(orderNo1.Text.Substring(6)), 5), "Bookinfo");
        }

        private void title2_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic2.Image, mf, ora.getBookCode(orderNo2.Text.Substring(6)), 5), "Bookinfo");
        }

        private void title3_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic3.Image, mf, ora.getBookCode(orderNo3.Text.Substring(6)), 5), "Bookinfo");
        }

        private void title4_Click(object sender, EventArgs e)
        {
            mf.controlView(new Bookinfo(ora, pic4.Image, mf, ora.getBookCode(orderNo4.Text.Substring(6)), 5), "Bookinfo");
        }

        
        private void review1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.BringToFront();
            reviewPic.Image = pic1.Image;
            reviewOrdNo.Text = orderNo1.Text;
            reviewTitle.Text = title1.Text;
            reviewDate.Text = date1.Text;
            reviewPrice.Text = price1.Text;
            reviewUpload.Enabled = true;
            reviewUploadBtn.Enabled = true;
            reviewScore = 0;
            reviewWrite.Text = "배송 문의나 욕설, 인신 공격성 글은 삭제됩니다.";
            star1.Image = Resources.별off;
            star2.Image = Resources.별off;
            star3.Image = Resources.별off;
            star4.Image = Resources.별off;
            star5.Image = Resources.별off;
        }

        private void review2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.BringToFront();
            reviewPic.Image = pic2.Image;
            reviewOrdNo.Text = orderNo2.Text;
            reviewTitle.Text = title2.Text;
            reviewDate.Text = date2.Text;
            reviewPrice.Text = price2.Text;
            reviewUpload.Enabled = true;
            reviewUploadBtn.Enabled = true;
            reviewScore = 0;
            reviewWrite.Text = "배송 문의나 욕설, 인신 공격성 글은 삭제됩니다.";
            star1.Image = Resources.별off;
            star2.Image = Resources.별off;
            star3.Image = Resources.별off;
            star4.Image = Resources.별off;
            star5.Image = Resources.별off;
        }

        private void review3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.BringToFront();
            reviewPic.Image = pic3.Image;
            reviewOrdNo.Text = orderNo3.Text;
            reviewTitle.Text = title3.Text;
            reviewDate.Text = date3.Text;
            reviewPrice.Text = price3.Text;
            reviewUpload.Enabled = true;
            reviewUploadBtn.Enabled = true;
            reviewScore = 0;
            reviewWrite.Text = "배송 문의나 욕설, 인신 공격성 글은 삭제됩니다.";
            star1.Image = Resources.별off;
            star2.Image = Resources.별off;
            star3.Image = Resources.별off;
            star4.Image = Resources.별off;
            star5.Image = Resources.별off;
        }

        private void review4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.BringToFront();
            reviewPic.Image = pic4.Image;
            reviewOrdNo.Text = orderNo4.Text;
            reviewTitle.Text = title4.Text;
            reviewDate.Text = date4.Text;
            reviewPrice.Text = price4.Text;
            reviewUpload.Enabled = true;
            reviewUploadBtn.Enabled = true;
            reviewScore = 0;
            reviewWrite.Text = "배송 문의나 욕설, 인신 공격성 글은 삭제됩니다.";
            star1.Image = Resources.별off;
            star2.Image = Resources.별off;
            star3.Image = Resources.별off;
            star4.Image = Resources.별off;
            star5.Image = Resources.별off;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            reviewPic.Image = null;
            reviewOrdNo.Text = "";
            reviewTitle.Text = "";
            reviewDate.Text = "";
            reviewPrice.Text = "";
            reviewScore = 0;
            reviewWrite.Text = "배송 문의나 욕설, 인신 공격성 글은 삭제됩니다.";
            star1.Image = Resources.별off;
            star2.Image = Resources.별off;
            star3.Image = Resources.별off;
            star4.Image = Resources.별off;
            star5.Image = Resources.별off;
            showOrderInfo();
        }

        private void reviewUpload_Click(object sender, EventArgs e)
        {
            if (reviewScore > 0 && reviewWrite.Text != "배송 문의나 욕설, 인신 공격성 글은 삭제됩니다." && reviewWrite.Text != "" && reviewWrite.Text != "리뷰 내용을 입력해주세요.")
            {
                ora.uploadReview(reviewOrdNo.Text.Substring(6), reviewScore, reviewWrite.Text);
                ora.commit();
                panel2.Visible = true;
                reviewUpload.Enabled = false;
                reviewUploadBtn.Enabled = false;
            }
            else
            {
                label8.Visible = true;
            }
            if (reviewWrite.Text == "배송 문의나 욕설, 인신 공격성 글은 삭제됩니다." || reviewWrite.Text == "" || reviewWrite.Text == "리뷰 내용을 입력해주세요.")
            {
                reviewWrite.Text = "리뷰 내용을 입력해주세요.";
            }
        }

        private void star1_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            if (reviewScore == 1)
            {
                star2.Image = Resources.별off;
                star3.Image = Resources.별off;
                star4.Image = Resources.별off;
                star5.Image = Resources.별off;
                reviewScore = 1;
            }
            else if (reviewScore != 1)
            {
                star1.Image = Resources.별on;
                reviewScore = 1;
            }
        }

        private void star2_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            star1.Image = Resources.별on;
            if (reviewScore == 2)
            {
                star2.Image = Resources.별off;
                star3.Image = Resources.별off;
                star4.Image = Resources.별off;
                star5.Image = Resources.별off;
                reviewScore = 1;
            }
            else if(reviewScore != 2)
            {
                star2.Image = Resources.별on;
                reviewScore = 2;
            }
        }

        private void star3_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            star1.Image = Resources.별on;
            star2.Image = Resources.별on;
            if (reviewScore == 3)
            {
                star3.Image = Resources.별off;
                star4.Image = Resources.별off;
                star5.Image = Resources.별off;
                reviewScore = 2;
            }
            else if (reviewScore != 3)
            {
                star3.Image = Resources.별on;
                reviewScore = 3;
            }
        }

        private void star4_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            star1.Image = Resources.별on;
            star2.Image = Resources.별on;
            star3.Image = Resources.별on;
            if (reviewScore == 4)
            {
                star4.Image = Resources.별off;
                star5.Image = Resources.별off;
                reviewScore = 3;
            }
            else if (reviewScore != 4)
            {
                star4.Image = Resources.별on;
                reviewScore = 4;
            }
        }

        private void star5_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            star1.Image = Resources.별on;
            star2.Image = Resources.별on;
            star3.Image = Resources.별on;
            star4.Image = Resources.별on;
            if (reviewScore == 5)
            {
                star5.Image = Resources.별off;
                reviewScore = 4;
            }
            else if (reviewScore != 5)
            {
                star5.Image = Resources.별on;
                reviewScore = 5;
            }
        }

        private void star5_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Resources.별on;
            star2.Image = Resources.별on;
            star3.Image = Resources.별on;
            star4.Image = Resources.별on;
            star5.Image = Resources.별on;
        }

        private void star4_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Resources.별on;
            star2.Image = Resources.별on;
            star3.Image = Resources.별on;
            star4.Image = Resources.별on;
        }

        private void star3_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Resources.별on;
            star2.Image = Resources.별on;
            star3.Image = Resources.별on;
        }

        private void star2_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Resources.별on;
            star2.Image = Resources.별on;
        }

        private void star1_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Resources.별on;
        }

        private void star5_MouseLeave(object sender, EventArgs e)
        {
            if(reviewScore == 0)
            {
                star1.Image = Resources.별off;
                star2.Image = Resources.별off;
                star3.Image = Resources.별off;
                star4.Image = Resources.별off;
                star5.Image = Resources.별off;
            }
            else if(reviewScore == 1)
            {
                star1.Image = Resources.별on;
                star2.Image = Resources.별off;
                star3.Image = Resources.별off;
                star4.Image = Resources.별off;
                star5.Image = Resources.별off;
            }
            else if(reviewScore == 2)
            {
                star1.Image = Resources.별on;
                star2.Image = Resources.별on;
                star3.Image = Resources.별off;
                star4.Image = Resources.별off;
                star5.Image = Resources.별off;
            }
            else if(reviewScore == 3)
            {
                star1.Image = Resources.별on;
                star2.Image = Resources.별on;
                star3.Image = Resources.별on;
                star4.Image = Resources.별off;
                star5.Image = Resources.별off;
            }
            else if(reviewScore == 4)
            {
                star1.Image = Resources.별on;
                star2.Image = Resources.별on;
                star3.Image = Resources.별on;
                star4.Image = Resources.별on;
                star5.Image = Resources.별off;
            }
            else if(reviewScore == 5)
            {
                star1.Image = Resources.별on;
                star2.Image = Resources.별on;
                star3.Image = Resources.별on;
                star4.Image = Resources.별on;
                star5.Image = Resources.별on;
            }
        }

        private void reviewWrite_Enter(object sender, EventArgs e)
        {
            if (reviewWrite.Text == "배송 문의나 욕설, 인신 공격성 글은 삭제됩니다." || reviewWrite.Text == "리뷰 내용을 입력해주세요.")
            {
                reviewWrite.Text = "";
            }
        }
    }
}
