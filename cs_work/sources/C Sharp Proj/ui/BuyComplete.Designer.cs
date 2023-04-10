namespace KBbooks.ui
{
    partial class BuyComplete
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
            this.homeLabel = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.mypageLabel = new System.Windows.Forms.Label();
            this.mypageBtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypageBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.homeLabel.ForeColor = System.Drawing.Color.White;
            this.homeLabel.Location = new System.Drawing.Point(567, 242);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(128, 26);
            this.homeLabel.TabIndex = 57;
            this.homeLabel.Text = "첫 화면으로";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.homeBtn.Location = new System.Drawing.Point(446, 234);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(371, 43);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeBtn.TabIndex = 56;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // mypageLabel
            // 
            this.mypageLabel.AutoSize = true;
            this.mypageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.mypageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mypageLabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.mypageLabel.ForeColor = System.Drawing.Color.White;
            this.mypageLabel.Location = new System.Drawing.Point(578, 185);
            this.mypageLabel.Name = "mypageLabel";
            this.mypageLabel.Size = new System.Drawing.Size(106, 26);
            this.mypageLabel.TabIndex = 55;
            this.mypageLabel.Text = "주문 확인";
            this.mypageLabel.Click += new System.EventHandler(this.mypageLabel_Click);
            // 
            // mypageBtn
            // 
            this.mypageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mypageBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.mypageBtn.Location = new System.Drawing.Point(446, 177);
            this.mypageBtn.Name = "mypageBtn";
            this.mypageBtn.Size = new System.Drawing.Size(371, 43);
            this.mypageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mypageBtn.TabIndex = 54;
            this.mypageBtn.TabStop = false;
            this.mypageBtn.Click += new System.EventHandler(this.mypageLabel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(444, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "배송이 시작되면 문자로 알려드릴게요.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(444, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "주문이 완료되었습니다.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(444, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 26);
            this.label6.TabIndex = 51;
            this.label6.Text = "주문 완료";
            // 
            // underbar
            // 
            this.underbar.AutoSize = true;
            this.underbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.underbar.Location = new System.Drawing.Point(444, 49);
            this.underbar.Name = "underbar";
            this.underbar.Size = new System.Drawing.Size(377, 12);
            this.underbar.TabIndex = 50;
            this.underbar.Text = "                                                                                 " +
    "            ";
            this.underbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.mypageLabel);
            this.Controls.Add(this.mypageBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.underbar);
            this.Name = "BuyComplete";
            this.Size = new System.Drawing.Size(1264, 822);
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypageBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.Label mypageLabel;
        private System.Windows.Forms.PictureBox mypageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label underbar;
    }
}
