using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KBbooks.ui.admin
{
    partial class AdminSales : UserControl
    {
        DaoOra ora;
        MainForm mf;
        int year = 23;
        int month = 1;
        int viewmode = 0;
        int monthweek = 0;
        public AdminSales(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            panel1.Visible = true;
            viewMonthlySales();
        }


        private void viewMonthlySales()
        {
            if(viewmode != 0)
            {
                viewmode = 0;
                year = 23;
                month = 1;
            }
            Title title = new Title();
            title.Text = $"20{year}년 매출액";
            title.Font = new Font("나눔스퀘어 Bold", 18);
            chart1.Titles.Clear();
            chart1.Titles.Add(title);
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series1"));
            chart1.Series["Series1"].Points.Clear();
            List<int> sales = ora.getMonthlySales(year);
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
            for (int i = 0; i < sales.Count; i++)
            {
                if (i != 12)
                {
                    chart1.Series["Series1"].Points.AddXY($"{i + 1}월", sales[i]);
                    chart1.Series["Series1"].Points[i].Label = sales[i].ToString("C");
                }
                else
                {
                    sumprice.Text = $"20{year}년의 총 매출액은 {sales[i].ToString("#,##0")}원 입니다.";
                }
            }
            chart1.Series["Series1"].LegendText = "월별 매출";
            string genre = ora.getBestGenre(year);
            if(genre != null)
            {
                bestgenre.Text = $"가장 많이 팔린 장르는 '{genre}'입니다.";
            }
            else
            {
                bestgenre.Text = $"판매 내역이 없습니다.";
            }
        }
        private void viewWeeklySales()
        {
            if(viewmode != 0)
            {
                viewmode = 0;
                year = 23;
                month = 1;
            }
            Title title = new Title();
            title.Text = $"20{year}년 {month}월 매출액";
            title.Font = new Font("나눔스퀘어 Bold", 18);
            chart1.Titles.Clear();
            chart1.Titles.Add(title);
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series1"));
            chart1.Series["Series1"].Points.Clear();
            List<int> sales = ora.getWeeklySales(year, month);
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
            for (int i = 0; i < sales.Count; i++)
            {
                if (i != 5)
                {
                    chart1.Series["Series1"].Points.AddXY($"{i + 1}주", sales[i]);
                    chart1.Series["Series1"].Points[i].Label = sales[i].ToString("C");
                }
                else
                {
                    sumprice.Text = $"20{year}년 {month}월 총 매출액은 {sales[i].ToString("#,##0")}원 입니다.";
                }
            }
            chart1.Series["Series1"].LegendText = "주간 매출";
            string genre = ora.getBestGenre(year, month);
            if (genre != null)
            {
                bestgenre.Text = $"가장 많이 팔린 장르는 '{genre}'입니다.";
            }
            else
            {
                bestgenre.Text = $"판매 내역이 없습니다.";
            }
        }
        private void viewWeeklyGenre()
        {
            if (viewmode != 1)
            {
                viewmode = 1;
                year = 23;
                month = 1;
            }
            Title title = new Title();
            title.Text = $"20{year}년 {month}월 장르별 판매부수";
            title.Font = new Font("나눔스퀘어 Bold", 18);
            chart1.Titles.Clear();
            chart1.Titles.Add(title);
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series1"));
            chart1.Series.Add(new Series("Series2"));
            chart1.Series.Add(new Series("Series3"));
            chart1.Series.Add(new Series("Series4"));
            chart1.Series.Add(new Series("Series5"));
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            chart1.Series["Series3"].Points.Clear();
            chart1.Series["Series4"].Points.Clear();
            chart1.Series["Series5"].Points.Clear();
            List<int> novel = ora.getWeeklySales(year, month, "소설");
            List<int> inmun = ora.getWeeklySales(year, month, "인문");
            List<int> dev = ora.getWeeklySales(year, month, "자기계발");
            List<int> finance = ora.getWeeklySales(year, month, "경제");
            List<int> comics = ora.getWeeklySales(year, month, "만화");
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
            int novelsum, inmunsum, devsum, financesum, comicssum, salessum;
            for (int i = 0; i < novel.Count; i++)
            {
                if (i != 5)
                {
                    chart1.Series["Series1"].Points.AddXY($"{i + 1}주", novel[i]);
                    chart1.Series["Series2"].Points.Add(inmun[i]);
                    chart1.Series["Series3"].Points.Add(dev[i]);
                    chart1.Series["Series4"].Points.Add(finance[i]);
                    chart1.Series["Series5"].Points.Add(comics[i]);
                    chart1.Series["Series1"].Points[i].Label = novel[i].ToString();
                    chart1.Series["Series2"].Points[i].Label = inmun[i].ToString();
                    chart1.Series["Series3"].Points[i].Label = dev[i].ToString();
                    chart1.Series["Series4"].Points[i].Label = finance[i].ToString();
                    chart1.Series["Series5"].Points[i].Label = comics[i].ToString();
                }
                else
                {
                    novelsum = novel[i];
                    inmunsum = inmun[i];
                    devsum = dev[i];
                    financesum = finance[i];
                    comicssum = comics[i];
                    salessum = novelsum + inmunsum + devsum + financesum + comicssum;
                    sumprice.Text = $"20{year}년 {month}월 총 판매부수는 {salessum}권 입니다.";
                }
            }

            chart1.Series["Series1"].LegendText = "소설";
            chart1.Series["Series2"].LegendText = "인문";
            chart1.Series["Series3"].LegendText = "자기계발";
            chart1.Series["Series4"].LegendText = "경제";
            chart1.Series["Series5"].LegendText = "만화";
            string genre = ora.getBestGenre(year, month);
            if (genre != null)
            {
                bestgenre.Text = $"가장 많이 팔린 장르는 '{genre}'입니다.";
            }
            else
            {
                bestgenre.Text = $"판매 내역이 없습니다.";
            }
        }
        private void viewGenreSales()
        {
            if(viewmode != 1)
            {
                viewmode = 1;
                year = 23;
                month = 1;
            }
            Title title = new Title();
            title.Text = $"20{year}년 장르별 판매부수";
            title.Font = new Font("나눔스퀘어 Bold", 18);
            chart1.Titles.Clear();
            chart1.Titles.Add(title);
            chart1.Series.Clear();
            chart1.Series.Add(new Series("Series1"));
            chart1.Series.Add(new Series("Series2"));
            chart1.Series.Add(new Series("Series3"));
            chart1.Series.Add(new Series("Series4"));
            chart1.Series.Add(new Series("Series5"));
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            chart1.Series["Series3"].Points.Clear();
            chart1.Series["Series4"].Points.Clear();
            chart1.Series["Series5"].Points.Clear();
            List<int> novel = ora.getMonthlyGenre("소설", year);
            List<int> inmun = ora.getMonthlyGenre("인문", year);
            List<int> dev = ora.getMonthlyGenre("자기계발", year);
            List<int> finance = ora.getMonthlyGenre("경제", year);
            List<int> comics = ora.getMonthlyGenre("만화", year);
            int novelsum, inmunsum, devsum, financesum, comicssum, salessum;
            for (int i = 0; i < novel.Count; i++)
            {
                if (i != 12)
                {
                    chart1.Series["Series1"].Points.AddXY($"{i + 1}월", novel[i]);
                    chart1.Series["Series2"].Points.Add(inmun[i]);
                    chart1.Series["Series3"].Points.Add(dev[i]);
                    chart1.Series["Series4"].Points.Add(finance[i]);
                    chart1.Series["Series5"].Points.Add(comics[i]);
                    chart1.Series["Series1"].Points[i].Label = novel[i].ToString();
                    chart1.Series["Series2"].Points[i].Label = inmun[i].ToString();
                    chart1.Series["Series3"].Points[i].Label = dev[i].ToString();
                    chart1.Series["Series4"].Points[i].Label = finance[i].ToString();
                    chart1.Series["Series5"].Points[i].Label = comics[i].ToString();
                }
                else
                {
                    novelsum = novel[i];
                    inmunsum = inmun[i];
                    devsum = dev[i];
                    financesum = finance[i];
                    comicssum = comics[i];
                    salessum = novelsum + inmunsum + devsum + financesum + comicssum;
                    sumprice.Text = $"20{year}년 총 판매부수는 {salessum}권 입니다.";
                }
            }
            chart1.Series["Series1"].LegendText = "소설";
            chart1.Series["Series2"].LegendText = "인문";
            chart1.Series["Series3"].LegendText = "자기계발";
            chart1.Series["Series4"].LegendText = "경제";
            chart1.Series["Series5"].LegendText = "만화";
            string genre = ora.getBestGenre(year);
            if (genre != null)
            {
                bestgenre.Text = $"가장 많이 팔린 장르는 '{genre}'입니다.";
            }
            else
            {
                bestgenre.Text = $"판매 내역이 없습니다.";
            }
        }

        private void viewMonthly_Click(object sender, EventArgs e)
        {
            monthweek = 0;
            year = 23;
            month = 1;
            monthly.Font = new Font(monthly.Font.Name, monthly.Font.SizeInPoints, FontStyle.Bold);
            yearly.Font = new Font(yearly.Font.Name, yearly.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
            viewSales.Font = new Font(viewSales.Font.Name, viewSales.Font.SizeInPoints, FontStyle.Underline);
            viewPerGenre.Font = new Font(viewPerGenre.Font.Name, viewPerGenre.Font.SizeInPoints);
            viewMonthlySales();
        }

        private void viewPerGenre_Click(object sender, EventArgs e)
        {
            viewSales.Font = new Font(viewSales.Font.Name, viewSales.Font.SizeInPoints);
            viewPerGenre.Font = new Font(viewPerGenre.Font.Name, viewPerGenre.Font.SizeInPoints, FontStyle.Underline);
            if (monthweek == 0)
            {
                viewGenreSales();
            }
            else if(monthweek == 1)
            {
                viewWeeklyGenre();
            }
        }
        private void viewWeekly_Click(object sender, EventArgs e)
        {
            monthweek = 1;
            year = 23;
            month = 1;
            monthly.Font = new Font(monthly.Font.Name, monthly.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
            yearly.Font = new Font(yearly.Font.Name, yearly.Font.SizeInPoints, FontStyle.Bold);
            viewSales.Font = new Font(viewSales.Font.Name, viewSales.Font.SizeInPoints, FontStyle.Underline);
            viewPerGenre.Font = new Font(viewPerGenre.Font.Name, viewPerGenre.Font.SizeInPoints);
            viewWeeklySales();
        }

        private void prevyear_Click(object sender, EventArgs e)
        {
            if(monthweek == 0)
            {
                if (viewmode != 1)
                {
                    if (year > 21)
                    {
                        year = year - 1;
                        viewMonthlySales();
                    }
                }
                else if (viewmode == 1)
                {
                    if (year > 21)
                    {
                        year = year - 1;
                        viewGenreSales();
                    }
                }
            }
            else if(monthweek == 1)
            {
                if (viewmode != 1)
                {
                    if (year > 21 && month > 1)
                    {
                        month = month - 1;
                        viewWeeklySales();
                    }
                    else if (year == 21 && month > 11)
                    {
                        month = month - 1;
                        viewWeeklySales();
                    }
                    else if (year > 21 && month == 1)
                    {
                        month = 12;
                        year = year - 1;
                        viewWeeklySales();
                    }
                }
                else if(viewmode == 1)
                {
                    if (year > 21 && month > 1)
                    {
                        month = month - 1;
                        viewWeeklyGenre();
                    }
                    else if (year == 21 && month > 11)
                    {
                        month = month - 1;
                        viewWeeklyGenre();
                    }
                    else if (year > 21 && month == 1)
                    {
                        month = 12;
                        year = year - 1;
                        viewWeeklyGenre();
                    }
                }
            } 
        }

        private void nextyear_Click(object sender, EventArgs e)
        {
            if (monthweek == 0)
            {
                if (viewmode != 1)
                {
                    if (year < 23)
                    {
                        year = year + 1;
                        viewMonthlySales();
                    }
                }
                else if (viewmode == 1)
                {
                    if (year < 23)
                    {
                        year = year + 1;
                        viewGenreSales();
                    }
                }
            }
            else if (monthweek == 1)
            {
                if (viewmode != 1)
                {
                    if (year != 23 && month < 12)
                    {
                        month = month + 1;
                        viewWeeklySales();
                    }
                    else if (year < 23 && month == 12)
                    {
                        month = 1;
                        year = year + 1;
                        viewWeeklySales();
                    }
                }
                else if (viewmode == 1)
                {
                    if (year != 23 && month < 12)
                    {
                        month = month + 1;
                        viewWeeklyGenre();
                    }
                    else if (year < 23 && month == 12)
                    {
                        month = 1;
                        year = year + 1;
                        viewWeeklyGenre();
                    }
                }
            }
        }

        private void viewSales_Click(object sender, EventArgs e)
        {
            viewSales.Font = new Font(viewSales.Font.Name, viewSales.Font.SizeInPoints, FontStyle.Underline);
            viewPerGenre.Font = new Font(viewPerGenre.Font.Name, viewPerGenre.Font.SizeInPoints);
            if (monthweek == 0)
            {
                viewMonthlySales();
            }
            else if(monthweek == 1)
            {
                viewWeeklySales();
            }
        }

        private void booklabel_MouseEnter(object sender, EventArgs e)
        {
            booklabel.Font = new Font(booklabel.Font.Name, booklabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void booklabel_MouseLeave(object sender, EventArgs e)
        {
            booklabel.Font = new Font(booklabel.Font.Name, booklabel.Font.SizeInPoints, FontStyle.Bold);
        }
        private void saleslabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminSales(ora, mf), "AdminSales");
        }
        private void noticelabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminNoticeManage(ora, mf), "AdminNoticeManage");
        }
        private void yearly_MouseEnter(object sender, EventArgs e)
        {
            yearly.Font = new Font(yearly.Font.Name, yearly.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void monthly_MouseEnter(object sender, EventArgs e)
        {
            monthly.Font = new Font(monthly.Font.Name, monthly.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void yearly_MouseLeave(object sender, EventArgs e)
        {
            if (monthweek != 0)
            {
                yearly.Font = new Font(yearly.Font.Name, yearly.Font.SizeInPoints, FontStyle.Bold);
            }
        }
        private void monthly_MouseLeave(object sender, EventArgs e)
        {
            if (monthweek != 1)
            {
                monthly.Font = new Font(monthly.Font.Name, monthly.Font.SizeInPoints, FontStyle.Bold);
            }
        }

        private void booklabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new AdminAdd(ora, mf), "AdminAdd");
        }

        private void viewPerGenre_MouseLeave(object sender, EventArgs e)
        {
            if(viewmode != 1)
            {
                viewPerGenre.Font = new Font(viewPerGenre.Font.Name, viewPerGenre.Font.SizeInPoints);
            }
        }
        private void viewPerGenre_MouseEnter(object sender, EventArgs e)
        {
            viewPerGenre.Font = new Font(viewPerGenre.Font.Name, viewPerGenre.Font.SizeInPoints, FontStyle.Underline);
        }

        private void viewSales_MouseEnter(object sender, EventArgs e)
        {
            viewSales.Font = new Font(viewSales.Font.Name, viewSales.Font.SizeInPoints, FontStyle.Underline);
        }
        private void viewSales_MouseLeave(object sender, EventArgs e)
        {
            if (viewmode != 0)
            {
                viewSales.Font = new Font(viewSales.Font.Name, viewSales.Font.SizeInPoints);
            }
        }
        private void noticelabel_MouseEnter(object sender, EventArgs e)
        {
            noticelabel.Font = new Font(noticelabel.Font.Name, noticelabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }

        private void noticelabel_MouseLeave(object sender, EventArgs e)
        {
            noticelabel.Font = new Font(noticelabel.Font.Name, noticelabel.Font.SizeInPoints, FontStyle.Bold);
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
    }
}
