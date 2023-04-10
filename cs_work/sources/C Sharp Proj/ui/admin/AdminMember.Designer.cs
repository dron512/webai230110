namespace KBbooks.ui.admin
{
    partial class AdminMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMember));
            this.noticelabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saleslabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.booklabel = new System.Windows.Forms.Label();
            this.memberlabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.forcedelete = new System.Windows.Forms.Label();
            this.memberView = new System.Windows.Forms.ListView();
            this.memid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memaddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memtel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.membuy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // noticelabel
            // 
            this.noticelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noticelabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticelabel.Location = new System.Drawing.Point(401, 25);
            this.noticelabel.Name = "noticelabel";
            this.noticelabel.Size = new System.Drawing.Size(83, 25);
            this.noticelabel.TabIndex = 221;
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
            this.label18.TabIndex = 220;
            this.label18.Text = "・";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(18, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 30);
            this.label10.TabIndex = 219;
            this.label10.Text = "관리자 메뉴";
            // 
            // saleslabel
            // 
            this.saleslabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleslabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saleslabel.Location = new System.Drawing.Point(289, 25);
            this.saleslabel.Name = "saleslabel";
            this.saleslabel.Size = new System.Drawing.Size(83, 26);
            this.saleslabel.TabIndex = 218;
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
            this.label12.TabIndex = 217;
            this.label12.Text = "・";
            // 
            // booklabel
            // 
            this.booklabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booklabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.booklabel.Location = new System.Drawing.Point(176, 25);
            this.booklabel.Name = "booklabel";
            this.booklabel.Size = new System.Drawing.Size(84, 23);
            this.booklabel.TabIndex = 216;
            this.booklabel.Text = "도서 관리";
            this.booklabel.Click += new System.EventHandler(this.booklabel_Click);
            this.booklabel.MouseEnter += new System.EventHandler(this.booklabel_MouseEnter);
            this.booklabel.MouseLeave += new System.EventHandler(this.booklabel_MouseLeave);
            // 
            // memberlabel
            // 
            this.memberlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberlabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberlabel.Location = new System.Drawing.Point(512, 25);
            this.memberlabel.Name = "memberlabel";
            this.memberlabel.Size = new System.Drawing.Size(83, 25);
            this.memberlabel.TabIndex = 223;
            this.memberlabel.Text = "회원 관리";
            this.memberlabel.Click += new System.EventHandler(this.memberlabel_Click);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(490, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 23);
            this.label21.TabIndex = 222;
            this.label21.Text = "・";
            // 
            // forcedelete
            // 
            this.forcedelete.AutoSize = true;
            this.forcedelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.forcedelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forcedelete.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.forcedelete.ForeColor = System.Drawing.Color.White;
            this.forcedelete.Location = new System.Drawing.Point(935, 712);
            this.forcedelete.Name = "forcedelete";
            this.forcedelete.Size = new System.Drawing.Size(106, 26);
            this.forcedelete.TabIndex = 241;
            this.forcedelete.Text = "강제 탈퇴";
            this.forcedelete.Click += new System.EventHandler(this.forcedelete_Click);
            // 
            // memberView
            // 
            this.memberView.BackColor = System.Drawing.Color.White;
            this.memberView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memid,
            this.memname,
            this.memaddr,
            this.memtel,
            this.membuy});
            this.memberView.ForeColor = System.Drawing.Color.Black;
            this.memberView.FullRowSelect = true;
            this.memberView.GridLines = true;
            this.memberView.HideSelection = false;
            this.memberView.Location = new System.Drawing.Point(204, 169);
            this.memberView.MultiSelect = false;
            this.memberView.Name = "memberView";
            this.memberView.Size = new System.Drawing.Size(860, 530);
            this.memberView.TabIndex = 235;
            this.memberView.UseCompatibleStateImageBehavior = false;
            this.memberView.View = System.Windows.Forms.View.Details;
            this.memberView.SelectedIndexChanged += new System.EventHandler(this.memberView_SelectedIndexChanged);
            // 
            // memid
            // 
            this.memid.Text = "회원 ID";
            this.memid.Width = 100;
            // 
            // memname
            // 
            this.memname.Text = "성명";
            this.memname.Width = 150;
            // 
            // memaddr
            // 
            this.memaddr.Text = "주소";
            this.memaddr.Width = 396;
            // 
            // memtel
            // 
            this.memtel.Text = "전화번호";
            this.memtel.Width = 150;
            // 
            // membuy
            // 
            this.membuy.Text = "구매횟수";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(196, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 26);
            this.label11.TabIndex = 234;
            this.label11.Text = "회원 관리";
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
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(50, 750);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(85, 12);
            this.idlabel.TabIndex = 242;
            this.idlabel.Text = "회원id(안보임)";
            this.idlabel.Visible = false;
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
            this.updateBtn.Click += new System.EventHandler(this.forcedelete_Click);
            // 
            // AdminMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.forcedelete);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.memberView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.underbar);
            this.Controls.Add(this.memberlabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.noticelabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saleslabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.booklabel);
            this.Name = "AdminMember";
            this.Size = new System.Drawing.Size(1264, 822);
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noticelabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label saleslabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label booklabel;
        private System.Windows.Forms.Label memberlabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label forcedelete;
        private System.Windows.Forms.PictureBox updateBtn;
        private System.Windows.Forms.ListView memberView;
        private System.Windows.Forms.ColumnHeader memid;
        private System.Windows.Forms.ColumnHeader memname;
        private System.Windows.Forms.ColumnHeader memaddr;
        private System.Windows.Forms.ColumnHeader memtel;
        private System.Windows.Forms.ColumnHeader membuy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label underbar;
        private System.Windows.Forms.Label idlabel;
    }
}
