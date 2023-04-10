namespace KBbooks.ui.admin
{
    partial class AdminSalesManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSalesManage));
            this.memberlabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.noticelabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salesmanagelabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.bookreview = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bookupdate = new System.Windows.Forms.Label();
            this.bookadd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saleslabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.booklabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.PictureBox();
            this.salesView = new System.Windows.Forms.ListView();
            this.scode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            this.salescode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // memberlabel
            // 
            this.memberlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberlabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberlabel.Location = new System.Drawing.Point(512, 25);
            this.memberlabel.Name = "memberlabel";
            this.memberlabel.Size = new System.Drawing.Size(83, 25);
            this.memberlabel.TabIndex = 226;
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
            this.label21.TabIndex = 225;
            this.label21.Text = "・";
            // 
            // noticelabel
            // 
            this.noticelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noticelabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticelabel.Location = new System.Drawing.Point(401, 25);
            this.noticelabel.Name = "noticelabel";
            this.noticelabel.Size = new System.Drawing.Size(83, 25);
            this.noticelabel.TabIndex = 224;
            this.noticelabel.Text = "공지 관리";
            this.noticelabel.Click += new System.EventHandler(this.noticelabel_Click);
            this.noticelabel.MouseEnter += new System.EventHandler(this.noticelabel_MouseEnter);
            this.noticelabel.MouseLeave += new System.EventHandler(this.noticelabel_MouseLeave);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(379, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 23);
            this.label18.TabIndex = 223;
            this.label18.Text = "・";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salesmanagelabel);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.bookreview);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.bookupdate);
            this.panel1.Controls.Add(this.bookadd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(174, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 26);
            this.panel1.TabIndex = 222;
            // 
            // salesmanagelabel
            // 
            this.salesmanagelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesmanagelabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.salesmanagelabel.Location = new System.Drawing.Point(373, 2);
            this.salesmanagelabel.Name = "salesmanagelabel";
            this.salesmanagelabel.Size = new System.Drawing.Size(122, 23);
            this.salesmanagelabel.TabIndex = 167;
            this.salesmanagelabel.Text = "판매 내역 관리";
            this.salesmanagelabel.Click += new System.EventHandler(this.salesmanagelabel_Click);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(352, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 23);
            this.label22.TabIndex = 166;
            this.label22.Text = "・";
            // 
            // bookreview
            // 
            this.bookreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookreview.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookreview.Location = new System.Drawing.Point(263, 2);
            this.bookreview.Name = "bookreview";
            this.bookreview.Size = new System.Drawing.Size(83, 23);
            this.bookreview.TabIndex = 161;
            this.bookreview.Text = "리뷰 관리";
            this.bookreview.Click += new System.EventHandler(this.bookreview_Click);
            this.bookreview.MouseEnter += new System.EventHandler(this.bookreview_MouseEnter);
            this.bookreview.MouseLeave += new System.EventHandler(this.bookreview_MouseLeave);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(242, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 23);
            this.label19.TabIndex = 160;
            this.label19.Text = "・";
            // 
            // bookupdate
            // 
            this.bookupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookupdate.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookupdate.Location = new System.Drawing.Point(114, 2);
            this.bookupdate.Name = "bookupdate";
            this.bookupdate.Size = new System.Drawing.Size(122, 23);
            this.bookupdate.TabIndex = 159;
            this.bookupdate.Text = "도서 정보 수정";
            this.bookupdate.Click += new System.EventHandler(this.bookupdate_Click);
            this.bookupdate.MouseEnter += new System.EventHandler(this.bookupdate_MouseEnter);
            this.bookupdate.MouseLeave += new System.EventHandler(this.bookupdate_MouseLeave);
            // 
            // bookadd
            // 
            this.bookadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookadd.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookadd.Location = new System.Drawing.Point(2, 2);
            this.bookadd.Name = "bookadd";
            this.bookadd.Size = new System.Drawing.Size(84, 23);
            this.bookadd.TabIndex = 157;
            this.bookadd.Text = "도서 등록";
            this.bookadd.Click += new System.EventHandler(this.bookadd_Click);
            this.bookadd.MouseEnter += new System.EventHandler(this.bookadd_MouseEnter);
            this.bookadd.MouseLeave += new System.EventHandler(this.bookadd_MouseLeave);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(93, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 23);
            this.label9.TabIndex = 158;
            this.label9.Text = "・";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(18, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 30);
            this.label10.TabIndex = 221;
            this.label10.Text = "관리자 메뉴";
            // 
            // saleslabel
            // 
            this.saleslabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleslabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saleslabel.Location = new System.Drawing.Point(289, 25);
            this.saleslabel.Name = "saleslabel";
            this.saleslabel.Size = new System.Drawing.Size(83, 26);
            this.saleslabel.TabIndex = 220;
            this.saleslabel.Text = "매출 정보";
            this.saleslabel.Click += new System.EventHandler(this.saleslabel_Click);
            this.saleslabel.MouseEnter += new System.EventHandler(this.saleslabel_MouseEnter);
            this.saleslabel.MouseLeave += new System.EventHandler(this.saleslabel_MouseLeave);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(267, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 23);
            this.label12.TabIndex = 219;
            this.label12.Text = "・";
            // 
            // booklabel
            // 
            this.booklabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booklabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.booklabel.Location = new System.Drawing.Point(176, 25);
            this.booklabel.Name = "booklabel";
            this.booklabel.Size = new System.Drawing.Size(84, 23);
            this.booklabel.TabIndex = 218;
            this.booklabel.Text = "도서 관리";
            this.booklabel.Click += new System.EventHandler(this.booklabel_Click);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(960, 712);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(56, 26);
            this.update.TabIndex = 241;
            this.update.Text = "삭제";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.updateBtn.Location = new System.Drawing.Point(912, 705);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(152, 40);
            this.updateBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateBtn.TabIndex = 240;
            this.updateBtn.TabStop = false;
            this.updateBtn.Click += new System.EventHandler(this.update_Click);
            // 
            // salesView
            // 
            this.salesView.BackColor = System.Drawing.Color.White;
            this.salesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.scode,
            this.bcode,
            this.btitle,
            this.memid,
            this.date});
            this.salesView.ForeColor = System.Drawing.Color.Black;
            this.salesView.FullRowSelect = true;
            this.salesView.GridLines = true;
            this.salesView.HideSelection = false;
            this.salesView.Location = new System.Drawing.Point(204, 169);
            this.salesView.MultiSelect = false;
            this.salesView.Name = "salesView";
            this.salesView.Size = new System.Drawing.Size(860, 530);
            this.salesView.TabIndex = 235;
            this.salesView.UseCompatibleStateImageBehavior = false;
            this.salesView.View = System.Windows.Forms.View.Details;
            this.salesView.SelectedIndexChanged += new System.EventHandler(this.salesView_SelectedIndexChanged);
            // 
            // scode
            // 
            this.scode.Text = "주문번호";
            // 
            // bcode
            // 
            this.bcode.Text = "도서번호";
            this.bcode.Width = 120;
            // 
            // btitle
            // 
            this.btitle.Text = "도서명";
            this.btitle.Width = 440;
            // 
            // memid
            // 
            this.memid.Text = "주문자";
            this.memid.Width = 100;
            // 
            // date
            // 
            this.date.Text = "주문일자";
            this.date.Width = 130;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(196, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 26);
            this.label11.TabIndex = 234;
            this.label11.Text = "판매 내역 관리";
            // 
            // underbar
            // 
            this.underbar.AutoSize = true;
            this.underbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.underbar.Location = new System.Drawing.Point(196, 138);
            this.underbar.Name = "underbar";
            this.underbar.Size = new System.Drawing.Size(873, 12);
            this.underbar.TabIndex = 233;
            this.underbar.Text = resources.GetString("underbar.Text");
            this.underbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salescode
            // 
            this.salescode.AutoSize = true;
            this.salescode.Location = new System.Drawing.Point(28, 774);
            this.salescode.Name = "salescode";
            this.salescode.Size = new System.Drawing.Size(135, 12);
            this.salescode.TabIndex = 242;
            this.salescode.Text = "선택한주문번호(안보임)";
            this.salescode.Visible = false;
            // 
            // AdminSalesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.salescode);
            this.Controls.Add(this.update);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.salesView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.underbar);
            this.Controls.Add(this.memberlabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.noticelabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saleslabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.booklabel);
            this.Name = "AdminSalesManage";
            this.Size = new System.Drawing.Size(1264, 822);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberlabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label noticelabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label salesmanagelabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label bookreview;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label bookupdate;
        private System.Windows.Forms.Label bookadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label saleslabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label booklabel;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.PictureBox updateBtn;
        private System.Windows.Forms.ListView salesView;
        private System.Windows.Forms.ColumnHeader scode;
        private System.Windows.Forms.ColumnHeader bcode;
        private System.Windows.Forms.ColumnHeader btitle;
        private System.Windows.Forms.ColumnHeader memid;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label underbar;
        private System.Windows.Forms.Label salescode;
    }
}
