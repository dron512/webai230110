namespace KBbooks
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topLayout = new System.Windows.Forms.Panel();
            this.noticeCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.noticeTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recomBtn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.memberAdd = new System.Windows.Forms.Label();
            this.cartBtn = new System.Windows.Forms.PictureBox();
            this.myPageBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.novel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.best = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.topLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            this.topLayout.Controls.Add(this.noticeCode);
            this.topLayout.Controls.Add(this.label5);
            this.topLayout.Controls.Add(this.noticeTitle);
            this.topLayout.Controls.Add(this.label4);
            this.topLayout.Controls.Add(this.recomBtn);
            this.topLayout.Controls.Add(this.label6);
            this.topLayout.Controls.Add(this.label7);
            this.topLayout.Controls.Add(this.memberAdd);
            this.topLayout.Controls.Add(this.cartBtn);
            this.topLayout.Controls.Add(this.myPageBtn);
            this.topLayout.Controls.Add(this.label1);
            this.topLayout.Controls.Add(this.novel);
            this.topLayout.Controls.Add(this.label2);
            this.topLayout.Controls.Add(this.best);
            this.topLayout.Controls.Add(this.pictureBox2);
            this.topLayout.Controls.Add(this.textBox1);
            this.topLayout.Controls.Add(this.pictureBox1);
            this.topLayout.Controls.Add(this.pictureBox3);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(1264, 163);
            this.topLayout.TabIndex = 0;
            // 
            // noticeCode
            // 
            this.noticeCode.AutoEllipsis = true;
            this.noticeCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.noticeCode.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticeCode.Location = new System.Drawing.Point(492, 133);
            this.noticeCode.Name = "noticeCode";
            this.noticeCode.Size = new System.Drawing.Size(117, 23);
            this.noticeCode.TabIndex = 34;
            this.noticeCode.Text = "공지번호(안보임)";
            this.noticeCode.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(422, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "공지사항";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // noticeTitle
            // 
            this.noticeTitle.AutoEllipsis = true;
            this.noticeTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noticeTitle.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticeTitle.Location = new System.Drawing.Point(492, 106);
            this.noticeTitle.Name = "noticeTitle";
            this.noticeTitle.Size = new System.Drawing.Size(427, 23);
            this.noticeTitle.TabIndex = 32;
            this.noticeTitle.Text = "label3";
            this.noticeTitle.Click += new System.EventHandler(this.noticeTitle_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(-2, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1274, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // recomBtn
            // 
            this.recomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recomBtn.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.recomBtn.Location = new System.Drawing.Point(259, 120);
            this.recomBtn.Name = "recomBtn";
            this.recomBtn.Size = new System.Drawing.Size(105, 40);
            this.recomBtn.TabIndex = 30;
            this.recomBtn.Text = "추천마법사";
            this.recomBtn.Click += new System.EventHandler(this.recomBtn_Click);
            this.recomBtn.MouseEnter += new System.EventHandler(this.recomBtn_MouseEnter);
            this.recomBtn.MouseLeave += new System.EventHandler(this.recomBtn_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(1193, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "로그인";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(1175, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "|";
            // 
            // memberAdd
            // 
            this.memberAdd.AutoSize = true;
            this.memberAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberAdd.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberAdd.Location = new System.Drawing.Point(1105, 9);
            this.memberAdd.Name = "memberAdd";
            this.memberAdd.Size = new System.Drawing.Size(64, 17);
            this.memberAdd.TabIndex = 27;
            this.memberAdd.Text = "회원가입";
            this.memberAdd.Click += new System.EventHandler(this.memberAdd_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.Image = global::KBbooks.Properties.Resources.카트;
            this.cartBtn.Location = new System.Drawing.Point(1118, 59);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(45, 45);
            this.cartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartBtn.TabIndex = 26;
            this.cartBtn.TabStop = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            this.cartBtn.MouseEnter += new System.EventHandler(this.cartBtn_MouseEnter);
            this.cartBtn.MouseLeave += new System.EventHandler(this.cartBtn_MouseLeave);
            // 
            // myPageBtn
            // 
            this.myPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myPageBtn.Image = global::KBbooks.Properties.Resources.마이페이지;
            this.myPageBtn.Location = new System.Drawing.Point(1192, 44);
            this.myPageBtn.Name = "myPageBtn";
            this.myPageBtn.Size = new System.Drawing.Size(60, 60);
            this.myPageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myPageBtn.TabIndex = 25;
            this.myPageBtn.TabStop = false;
            this.myPageBtn.Click += new System.EventHandler(this.myPageBtn_Click);
            this.myPageBtn.MouseEnter += new System.EventHandler(this.myPageBtn_MouseEnter);
            this.myPageBtn.MouseLeave += new System.EventHandler(this.myPageBtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(233, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "・";
            // 
            // novel
            // 
            this.novel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novel.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.novel.Location = new System.Drawing.Point(176, 120);
            this.novel.Name = "novel";
            this.novel.Size = new System.Drawing.Size(49, 40);
            this.novel.TabIndex = 16;
            this.novel.Text = "신간";
            this.novel.Click += new System.EventHandler(this.novelBtn_Click);
            this.novel.MouseEnter += new System.EventHandler(this.novel_MouseEnter);
            this.novel.MouseLeave += new System.EventHandler(this.novel_MouseLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(150, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "・";
            // 
            // best
            // 
            this.best.Cursor = System.Windows.Forms.Cursors.Hand;
            this.best.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.best.Location = new System.Drawing.Point(37, 120);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(105, 40);
            this.best.TabIndex = 14;
            this.best.Text = "베스트셀러";
            this.best.Click += new System.EventHandler(this.bestBtn_Click);
            this.best.MouseEnter += new System.EventHandler(this.best_MouseEnter);
            this.best.MouseLeave += new System.EventHandler(this.best_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::KBbooks.Properties.Resources.search_mushimegane;
            this.pictureBox2.Location = new System.Drawing.Point(862, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(445, 48);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 34);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KBbooks.Properties.Resources.로고4;
            this.pictureBox1.Location = new System.Drawing.Point(41, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KBbooks.Properties.Resources.검색창2;
            this.pictureBox3.Location = new System.Drawing.Point(425, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(494, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(0, 163);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(1264, 822);
            this.centerLayout.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.topLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "경북문고";
            this.topLayout.ResumeLayout(false);
            this.topLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLayout;
        private System.Windows.Forms.Panel centerLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label novel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label best;
        private System.Windows.Forms.PictureBox myPageBtn;
        private System.Windows.Forms.PictureBox cartBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label memberAdd;
        private System.Windows.Forms.Label recomBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label noticeTitle;
        private System.Windows.Forms.Label noticeCode;
    }
}

