namespace KBbooks.ui.admin
{
    partial class AdminNoticeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminNoticeAdd));
            this.noticelabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noticeadd = new System.Windows.Forms.Label();
            this.noticemanage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saleslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booklabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            this.noticecontent = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.PictureBox();
            this.noticetitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.memberlabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // noticelabel
            // 
            this.noticelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noticelabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticelabel.Location = new System.Drawing.Point(401, 25);
            this.noticelabel.Name = "noticelabel";
            this.noticelabel.Size = new System.Drawing.Size(83, 25);
            this.noticelabel.TabIndex = 229;
            this.noticelabel.Text = "공지 관리";
            this.noticelabel.Click += new System.EventHandler(this.noticelabel_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(379, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 23);
            this.label16.TabIndex = 228;
            this.label16.Text = "・";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noticeadd);
            this.panel1.Controls.Add(this.noticemanage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(399, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 26);
            this.panel1.TabIndex = 227;
            // 
            // noticeadd
            // 
            this.noticeadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noticeadd.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticeadd.Location = new System.Drawing.Point(112, 2);
            this.noticeadd.Name = "noticeadd";
            this.noticeadd.Size = new System.Drawing.Size(83, 23);
            this.noticeadd.TabIndex = 159;
            this.noticeadd.Text = "공지 작성";
            this.noticeadd.Click += new System.EventHandler(this.noticeadd_Click);
            // 
            // noticemanage
            // 
            this.noticemanage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noticemanage.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticemanage.Location = new System.Drawing.Point(2, 2);
            this.noticemanage.Name = "noticemanage";
            this.noticemanage.Size = new System.Drawing.Size(83, 23);
            this.noticemanage.TabIndex = 157;
            this.noticemanage.Text = "공지 수정";
            this.noticemanage.Click += new System.EventHandler(this.noticelabel_Click);
            this.noticemanage.MouseEnter += new System.EventHandler(this.noticemanage_MouseEnter);
            this.noticemanage.MouseLeave += new System.EventHandler(this.noticemanage_MouseLeave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(91, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 23);
            this.label3.TabIndex = 158;
            this.label3.Text = "・";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(18, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 30);
            this.label6.TabIndex = 226;
            this.label6.Text = "관리자 메뉴";
            // 
            // saleslabel
            // 
            this.saleslabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleslabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saleslabel.Location = new System.Drawing.Point(289, 25);
            this.saleslabel.Name = "saleslabel";
            this.saleslabel.Size = new System.Drawing.Size(83, 26);
            this.saleslabel.TabIndex = 225;
            this.saleslabel.Text = "매출 정보";
            this.saleslabel.Click += new System.EventHandler(this.saleslabel_Click);
            this.saleslabel.MouseEnter += new System.EventHandler(this.saleslabel_MouseEnter);
            this.saleslabel.MouseLeave += new System.EventHandler(this.saleslabel_MouseLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 23);
            this.label2.TabIndex = 224;
            this.label2.Text = "・";
            // 
            // booklabel
            // 
            this.booklabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booklabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.booklabel.Location = new System.Drawing.Point(176, 25);
            this.booklabel.Name = "booklabel";
            this.booklabel.Size = new System.Drawing.Size(84, 23);
            this.booklabel.TabIndex = 223;
            this.booklabel.Text = "도서 관리";
            this.booklabel.Click += new System.EventHandler(this.booklabel_Click);
            this.booklabel.MouseEnter += new System.EventHandler(this.booklabel_MouseEnter);
            this.booklabel.MouseLeave += new System.EventHandler(this.booklabel_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(196, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 26);
            this.label12.TabIndex = 231;
            this.label12.Text = "공지 작성";
            // 
            // underbar
            // 
            this.underbar.AutoSize = true;
            this.underbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.underbar.Location = new System.Drawing.Point(196, 146);
            this.underbar.Name = "underbar";
            this.underbar.Size = new System.Drawing.Size(873, 12);
            this.underbar.TabIndex = 230;
            this.underbar.Text = resources.GetString("underbar.Text");
            this.underbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noticecontent
            // 
            this.noticecontent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noticecontent.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticecontent.Location = new System.Drawing.Point(202, 262);
            this.noticecontent.MaxLength = 650;
            this.noticecontent.Multiline = true;
            this.noticecontent.Name = "noticecontent";
            this.noticecontent.Size = new System.Drawing.Size(860, 153);
            this.noticecontent.TabIndex = 261;
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(920, 428);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 26);
            this.update.TabIndex = 260;
            this.update.Text = "작성하기";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.updateBtn.Location = new System.Drawing.Point(879, 421);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(183, 40);
            this.updateBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateBtn.TabIndex = 259;
            this.updateBtn.TabStop = false;
            this.updateBtn.Click += new System.EventHandler(this.update_Click);
            // 
            // noticetitle
            // 
            this.noticetitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noticetitle.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticetitle.Location = new System.Drawing.Point(202, 197);
            this.noticetitle.MaxLength = 33;
            this.noticetitle.Name = "noticetitle";
            this.noticetitle.Size = new System.Drawing.Size(860, 25);
            this.noticetitle.TabIndex = 258;
            this.noticetitle.Enter += new System.EventHandler(this.noticetitle_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(202, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 257;
            this.label5.Text = "내용";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(202, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 19);
            this.label11.TabIndex = 256;
            this.label11.Text = "제목";
            // 
            // memberlabel
            // 
            this.memberlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberlabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberlabel.Location = new System.Drawing.Point(512, 25);
            this.memberlabel.Name = "memberlabel";
            this.memberlabel.Size = new System.Drawing.Size(83, 25);
            this.memberlabel.TabIndex = 263;
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
            this.label21.TabIndex = 262;
            this.label21.Text = "・";
            // 
            // AdminNoticeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.memberlabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.noticecontent);
            this.Controls.Add(this.update);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.noticetitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.underbar);
            this.Controls.Add(this.noticelabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saleslabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.booklabel);
            this.Name = "AdminNoticeAdd";
            this.Size = new System.Drawing.Size(1264, 822);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noticelabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noticeadd;
        private System.Windows.Forms.Label noticemanage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label saleslabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label booklabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label underbar;
        private System.Windows.Forms.TextBox noticecontent;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.PictureBox updateBtn;
        private System.Windows.Forms.TextBox noticetitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label memberlabel;
        private System.Windows.Forms.Label label21;
    }
}
