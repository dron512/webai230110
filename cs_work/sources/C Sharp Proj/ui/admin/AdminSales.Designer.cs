namespace KBbooks.ui.admin
{
    partial class AdminSales
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSales));
            this.label6 = new System.Windows.Forms.Label();
            this.saleslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booklabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthly = new System.Windows.Forms.Label();
            this.yearly = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            this.nextyear = new System.Windows.Forms.PictureBox();
            this.prevyear = new System.Windows.Forms.PictureBox();
            this.sumprice = new System.Windows.Forms.Label();
            this.bestgenre = new System.Windows.Forms.Label();
            this.viewPerGenre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewSales = new System.Windows.Forms.Label();
            this.noticelabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.memberlabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevyear)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(18, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 30);
            this.label6.TabIndex = 154;
            this.label6.Text = "관리자 메뉴";
            // 
            // saleslabel
            // 
            this.saleslabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleslabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saleslabel.Location = new System.Drawing.Point(289, 25);
            this.saleslabel.Name = "saleslabel";
            this.saleslabel.Size = new System.Drawing.Size(83, 26);
            this.saleslabel.TabIndex = 153;
            this.saleslabel.Text = "매출 정보";
            this.saleslabel.Click += new System.EventHandler(this.saleslabel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 23);
            this.label2.TabIndex = 152;
            this.label2.Text = "・";
            // 
            // booklabel
            // 
            this.booklabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booklabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.booklabel.Location = new System.Drawing.Point(176, 25);
            this.booklabel.Name = "booklabel";
            this.booklabel.Size = new System.Drawing.Size(84, 23);
            this.booklabel.TabIndex = 151;
            this.booklabel.Text = "도서 관리";
            this.booklabel.Click += new System.EventHandler(this.booklabel_Click);
            this.booklabel.MouseEnter += new System.EventHandler(this.booklabel_MouseEnter);
            this.booklabel.MouseLeave += new System.EventHandler(this.booklabel_MouseLeave);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(126, 167);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "매출액";
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1018, 415);
            this.chart1.TabIndex = 155;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "n년 월별 매출액";
            this.chart1.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthly);
            this.panel1.Controls.Add(this.yearly);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(285, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 26);
            this.panel1.TabIndex = 156;
            // 
            // monthly
            // 
            this.monthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthly.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monthly.Location = new System.Drawing.Point(129, 2);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(83, 23);
            this.monthly.TabIndex = 159;
            this.monthly.Text = "월별 매출";
            this.monthly.Click += new System.EventHandler(this.viewWeekly_Click);
            this.monthly.MouseEnter += new System.EventHandler(this.monthly_MouseEnter);
            this.monthly.MouseLeave += new System.EventHandler(this.monthly_MouseLeave);
            // 
            // yearly
            // 
            this.yearly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearly.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yearly.Location = new System.Drawing.Point(2, 2);
            this.yearly.Name = "yearly";
            this.yearly.Size = new System.Drawing.Size(100, 23);
            this.yearly.TabIndex = 157;
            this.yearly.Text = "연도별 매출";
            this.yearly.Click += new System.EventHandler(this.viewMonthly_Click);
            this.yearly.MouseEnter += new System.EventHandler(this.yearly_MouseEnter);
            this.yearly.MouseLeave += new System.EventHandler(this.yearly_MouseLeave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(108, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 23);
            this.label3.TabIndex = 158;
            this.label3.Text = "・";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(111, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 26);
            this.label11.TabIndex = 170;
            this.label11.Text = "매출 정보";
            // 
            // underbar
            // 
            this.underbar.AutoSize = true;
            this.underbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.underbar.Location = new System.Drawing.Point(111, 138);
            this.underbar.Name = "underbar";
            this.underbar.Size = new System.Drawing.Size(1045, 12);
            this.underbar.TabIndex = 169;
            this.underbar.Text = resources.GetString("underbar.Text");
            this.underbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextyear
            // 
            this.nextyear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextyear.Image = global::KBbooks.Properties.Resources.다음;
            this.nextyear.Location = new System.Drawing.Point(1116, 350);
            this.nextyear.Name = "nextyear";
            this.nextyear.Size = new System.Drawing.Size(40, 40);
            this.nextyear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nextyear.TabIndex = 192;
            this.nextyear.TabStop = false;
            this.nextyear.Click += new System.EventHandler(this.nextyear_Click);
            // 
            // prevyear
            // 
            this.prevyear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevyear.Image = global::KBbooks.Properties.Resources.이전;
            this.prevyear.Location = new System.Drawing.Point(113, 350);
            this.prevyear.Name = "prevyear";
            this.prevyear.Size = new System.Drawing.Size(40, 40);
            this.prevyear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prevyear.TabIndex = 191;
            this.prevyear.TabStop = false;
            this.prevyear.Click += new System.EventHandler(this.prevyear_Click);
            // 
            // sumprice
            // 
            this.sumprice.AutoSize = true;
            this.sumprice.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sumprice.Location = new System.Drawing.Point(175, 594);
            this.sumprice.Name = "sumprice";
            this.sumprice.Size = new System.Drawing.Size(339, 26);
            this.sumprice.TabIndex = 193;
            this.sumprice.Text = "2022년 총 매출액은 얼마입니다.";
            // 
            // bestgenre
            // 
            this.bestgenre.AutoSize = true;
            this.bestgenre.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bestgenre.Location = new System.Drawing.Point(175, 635);
            this.bestgenre.Name = "bestgenre";
            this.bestgenre.Size = new System.Drawing.Size(329, 26);
            this.bestgenre.TabIndex = 194;
            this.bestgenre.Text = "가장 많이 팔린 장르는 뭐입니다.";
            // 
            // viewPerGenre
            // 
            this.viewPerGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPerGenre.Font = new System.Drawing.Font("나눔스퀘어", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.viewPerGenre.Location = new System.Drawing.Point(316, 110);
            this.viewPerGenre.Name = "viewPerGenre";
            this.viewPerGenre.Size = new System.Drawing.Size(78, 23);
            this.viewPerGenre.TabIndex = 200;
            this.viewPerGenre.Text = "판매부수";
            this.viewPerGenre.Click += new System.EventHandler(this.viewPerGenre_Click);
            this.viewPerGenre.MouseEnter += new System.EventHandler(this.viewPerGenre_MouseEnter);
            this.viewPerGenre.MouseLeave += new System.EventHandler(this.viewPerGenre_MouseLeave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("나눔스퀘어", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(298, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 23);
            this.label4.TabIndex = 199;
            this.label4.Text = "・";
            // 
            // viewSales
            // 
            this.viewSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSales.Font = new System.Drawing.Font("나눔스퀘어", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.viewSales.Location = new System.Drawing.Point(234, 110);
            this.viewSales.Name = "viewSales";
            this.viewSales.Size = new System.Drawing.Size(61, 23);
            this.viewSales.TabIndex = 198;
            this.viewSales.Text = "매출액";
            this.viewSales.Click += new System.EventHandler(this.viewSales_Click);
            this.viewSales.MouseEnter += new System.EventHandler(this.viewSales_MouseEnter);
            this.viewSales.MouseLeave += new System.EventHandler(this.viewSales_MouseLeave);
            // 
            // noticelabel
            // 
            this.noticelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noticelabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticelabel.Location = new System.Drawing.Point(401, 25);
            this.noticelabel.Name = "noticelabel";
            this.noticelabel.Size = new System.Drawing.Size(83, 25);
            this.noticelabel.TabIndex = 215;
            this.noticelabel.Text = "공지 관리";
            this.noticelabel.Click += new System.EventHandler(this.noticelabel_Click);
            this.noticelabel.MouseEnter += new System.EventHandler(this.noticelabel_MouseEnter);
            this.noticelabel.MouseLeave += new System.EventHandler(this.noticelabel_MouseLeave);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(379, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 23);
            this.label16.TabIndex = 214;
            this.label16.Text = "・";
            // 
            // memberlabel
            // 
            this.memberlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberlabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberlabel.Location = new System.Drawing.Point(512, 25);
            this.memberlabel.Name = "memberlabel";
            this.memberlabel.Size = new System.Drawing.Size(83, 25);
            this.memberlabel.TabIndex = 219;
            this.memberlabel.Text = "회원 관리";
            this.memberlabel.Click += new System.EventHandler(this.memberlabel_Click);
            this.memberlabel.MouseEnter += new System.EventHandler(this.memberlabel_MouseEnter);
            this.memberlabel.MouseLeave += new System.EventHandler(this.memberlabel_MouseLeave);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(490, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 23);
            this.label21.TabIndex = 218;
            this.label21.Text = "・";
            // 
            // AdminSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.memberlabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.noticelabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.viewPerGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.viewSales);
            this.Controls.Add(this.nextyear);
            this.Controls.Add(this.bestgenre);
            this.Controls.Add(this.sumprice);
            this.Controls.Add(this.prevyear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.underbar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saleslabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.booklabel);
            this.Name = "AdminSales";
            this.Size = new System.Drawing.Size(1264, 822);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label saleslabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label booklabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label monthly;
        private System.Windows.Forms.Label yearly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label underbar;
        private System.Windows.Forms.PictureBox nextyear;
        private System.Windows.Forms.PictureBox prevyear;
        private System.Windows.Forms.Label sumprice;
        private System.Windows.Forms.Label bestgenre;
        private System.Windows.Forms.Label viewPerGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label viewSales;
        private System.Windows.Forms.Label noticelabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label memberlabel;
        private System.Windows.Forms.Label label21;
    }
}
