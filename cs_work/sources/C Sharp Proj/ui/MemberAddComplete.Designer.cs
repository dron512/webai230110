namespace KBbooks.ui
{
    partial class MemberAddComplete
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
            this.label6 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.PictureBox();
            this.homeLabel = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(445, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 37;
            this.label6.Text = "회원가입";
            // 
            // underbar
            // 
            this.underbar.AutoSize = true;
            this.underbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.underbar.Location = new System.Drawing.Point(445, 49);
            this.underbar.Name = "underbar";
            this.underbar.Size = new System.Drawing.Size(377, 12);
            this.underbar.TabIndex = 36;
            this.underbar.Text = "                                                                                 " +
    "            ";
            this.underbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(445, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "이름 님,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(445, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "경북문고 회원가입이 완료되었습니다.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(593, 185);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(78, 26);
            this.loginLabel.TabIndex = 47;
            this.loginLabel.Text = "로그인";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.loginBtn.Location = new System.Drawing.Point(447, 177);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(371, 43);
            this.loginBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginBtn.TabIndex = 46;
            this.loginBtn.TabStop = false;
            this.loginBtn.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.homeLabel.ForeColor = System.Drawing.Color.White;
            this.homeLabel.Location = new System.Drawing.Point(568, 242);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(128, 26);
            this.homeLabel.TabIndex = 49;
            this.homeLabel.Text = "첫 화면으로";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.homeBtn.Location = new System.Drawing.Point(447, 234);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(371, 43);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeBtn.TabIndex = 48;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // MemberAddComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.underbar);
            this.Name = "MemberAddComplete";
            this.Size = new System.Drawing.Size(1264, 822);
            this.Load += new System.EventHandler(this.MemberAddComplete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label underbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox loginBtn;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox homeBtn;
    }
}
