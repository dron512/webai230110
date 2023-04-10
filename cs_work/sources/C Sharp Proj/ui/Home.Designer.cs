namespace KBbooks.ui
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tdate = new System.Windows.Forms.Label();
            this.tpub = new System.Windows.Forms.Label();
            this.tprice = new System.Windows.Forms.Label();
            this.tauthor = new System.Windows.Forms.Label();
            this.ttitle1 = new System.Windows.Forms.Label();
            this.ttitle2 = new System.Windows.Forms.Label();
            this.ttitle3 = new System.Windows.Forms.Label();
            this.ttitle4 = new System.Windows.Forms.Label();
            this.btitle4 = new System.Windows.Forms.Label();
            this.btitle3 = new System.Windows.Forms.Label();
            this.btitle2 = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.Label();
            this.bpub = new System.Windows.Forms.Label();
            this.bprice = new System.Windows.Forms.Label();
            this.bauthor = new System.Windows.Forms.Label();
            this.btitle1 = new System.Windows.Forms.Label();
            this.bpic4 = new System.Windows.Forms.PictureBox();
            this.bpic3 = new System.Windows.Forms.PictureBox();
            this.bpic2 = new System.Windows.Forms.PictureBox();
            this.tpic4 = new System.Windows.Forms.PictureBox();
            this.tpic3 = new System.Windows.Forms.PictureBox();
            this.tpic2 = new System.Windows.Forms.PictureBox();
            this.bpic1 = new System.Windows.Forms.PictureBox();
            this.tpic1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bpic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpic1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tdate
            // 
            this.tdate.AutoSize = true;
            this.tdate.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tdate.Location = new System.Drawing.Point(291, 313);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(64, 21);
            this.tdate.TabIndex = 143;
            this.tdate.Text = "발행일";
            // 
            // tpub
            // 
            this.tpub.AutoSize = true;
            this.tpub.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tpub.Location = new System.Drawing.Point(291, 277);
            this.tpub.Name = "tpub";
            this.tpub.Size = new System.Drawing.Size(64, 21);
            this.tpub.TabIndex = 142;
            this.tpub.Text = "출판사";
            // 
            // tprice
            // 
            this.tprice.AutoSize = true;
            this.tprice.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tprice.Location = new System.Drawing.Point(291, 349);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(46, 21);
            this.tprice.TabIndex = 140;
            this.tprice.Text = "가격";
            // 
            // tauthor
            // 
            this.tauthor.AutoSize = true;
            this.tauthor.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tauthor.Location = new System.Drawing.Point(291, 241);
            this.tauthor.Name = "tauthor";
            this.tauthor.Size = new System.Drawing.Size(46, 21);
            this.tauthor.TabIndex = 139;
            this.tauthor.Text = "저자";
            // 
            // ttitle1
            // 
            this.ttitle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ttitle1.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ttitle1.Location = new System.Drawing.Point(290, 92);
            this.ttitle1.Name = "ttitle1";
            this.ttitle1.Size = new System.Drawing.Size(370, 132);
            this.ttitle1.TabIndex = 138;
            this.ttitle1.Text = "제목";
            this.ttitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttitle1.Click += new System.EventHandler(this.ttitle1_Click);
            // 
            // ttitle2
            // 
            this.ttitle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ttitle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ttitle2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ttitle2.Location = new System.Drawing.Point(693, 319);
            this.ttitle2.Name = "ttitle2";
            this.ttitle2.Size = new System.Drawing.Size(167, 86);
            this.ttitle2.TabIndex = 149;
            this.ttitle2.Text = "제목";
            this.ttitle2.Click += new System.EventHandler(this.ttitle2_Click);
            // 
            // ttitle3
            // 
            this.ttitle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ttitle3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ttitle3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ttitle3.Location = new System.Drawing.Point(870, 319);
            this.ttitle3.Name = "ttitle3";
            this.ttitle3.Size = new System.Drawing.Size(167, 86);
            this.ttitle3.TabIndex = 150;
            this.ttitle3.Text = "제목";
            this.ttitle3.Click += new System.EventHandler(this.ttitle3_Click);
            // 
            // ttitle4
            // 
            this.ttitle4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ttitle4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ttitle4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ttitle4.Location = new System.Drawing.Point(1045, 319);
            this.ttitle4.Name = "ttitle4";
            this.ttitle4.Size = new System.Drawing.Size(167, 86);
            this.ttitle4.TabIndex = 151;
            this.ttitle4.Text = "제목";
            this.ttitle4.Click += new System.EventHandler(this.ttitle4_Click);
            // 
            // btitle4
            // 
            this.btitle4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btitle4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btitle4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btitle4.Location = new System.Drawing.Point(1045, 722);
            this.btitle4.Name = "btitle4";
            this.btitle4.Size = new System.Drawing.Size(167, 86);
            this.btitle4.TabIndex = 163;
            this.btitle4.Text = "제목";
            this.btitle4.Click += new System.EventHandler(this.btitle4_Click);
            // 
            // btitle3
            // 
            this.btitle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btitle3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btitle3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btitle3.Location = new System.Drawing.Point(870, 722);
            this.btitle3.Name = "btitle3";
            this.btitle3.Size = new System.Drawing.Size(167, 86);
            this.btitle3.TabIndex = 162;
            this.btitle3.Text = "제목";
            this.btitle3.Click += new System.EventHandler(this.btitle3_Click);
            // 
            // btitle2
            // 
            this.btitle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btitle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btitle2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btitle2.Location = new System.Drawing.Point(693, 722);
            this.btitle2.Name = "btitle2";
            this.btitle2.Size = new System.Drawing.Size(167, 86);
            this.btitle2.TabIndex = 161;
            this.btitle2.Text = "제목";
            this.btitle2.Click += new System.EventHandler(this.btitle2_Click);
            // 
            // bdate
            // 
            this.bdate.AutoSize = true;
            this.bdate.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bdate.Location = new System.Drawing.Point(291, 716);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(64, 21);
            this.bdate.TabIndex = 157;
            this.bdate.Text = "발행일";
            // 
            // bpub
            // 
            this.bpub.AutoSize = true;
            this.bpub.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bpub.Location = new System.Drawing.Point(291, 680);
            this.bpub.Name = "bpub";
            this.bpub.Size = new System.Drawing.Size(64, 21);
            this.bpub.TabIndex = 156;
            this.bpub.Text = "출판사";
            // 
            // bprice
            // 
            this.bprice.AutoSize = true;
            this.bprice.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bprice.Location = new System.Drawing.Point(291, 752);
            this.bprice.Name = "bprice";
            this.bprice.Size = new System.Drawing.Size(46, 21);
            this.bprice.TabIndex = 154;
            this.bprice.Text = "가격";
            // 
            // bauthor
            // 
            this.bauthor.AutoSize = true;
            this.bauthor.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bauthor.Location = new System.Drawing.Point(291, 644);
            this.bauthor.Name = "bauthor";
            this.bauthor.Size = new System.Drawing.Size(46, 21);
            this.bauthor.TabIndex = 153;
            this.bauthor.Text = "저자";
            // 
            // btitle1
            // 
            this.btitle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btitle1.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btitle1.Location = new System.Drawing.Point(290, 495);
            this.btitle1.Name = "btitle1";
            this.btitle1.Size = new System.Drawing.Size(370, 132);
            this.btitle1.TabIndex = 152;
            this.btitle1.Text = "제목";
            this.btitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btitle1.Click += new System.EventHandler(this.btitle1_Click);
            // 
            // bpic4
            // 
            this.bpic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpic4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bpic4.Location = new System.Drawing.Point(1049, 495);
            this.bpic4.Name = "bpic4";
            this.bpic4.Size = new System.Drawing.Size(162, 220);
            this.bpic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bpic4.TabIndex = 160;
            this.bpic4.TabStop = false;
            this.bpic4.Click += new System.EventHandler(this.btitle4_Click);
            // 
            // bpic3
            // 
            this.bpic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpic3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bpic3.Location = new System.Drawing.Point(874, 495);
            this.bpic3.Name = "bpic3";
            this.bpic3.Size = new System.Drawing.Size(162, 220);
            this.bpic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bpic3.TabIndex = 159;
            this.bpic3.TabStop = false;
            this.bpic3.Click += new System.EventHandler(this.btitle3_Click);
            // 
            // bpic2
            // 
            this.bpic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bpic2.Location = new System.Drawing.Point(698, 495);
            this.bpic2.Name = "bpic2";
            this.bpic2.Size = new System.Drawing.Size(162, 220);
            this.bpic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bpic2.TabIndex = 158;
            this.bpic2.TabStop = false;
            this.bpic2.Click += new System.EventHandler(this.btitle2_Click);
            // 
            // tpic4
            // 
            this.tpic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpic4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpic4.Location = new System.Drawing.Point(1049, 92);
            this.tpic4.Name = "tpic4";
            this.tpic4.Size = new System.Drawing.Size(162, 220);
            this.tpic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tpic4.TabIndex = 148;
            this.tpic4.TabStop = false;
            this.tpic4.Click += new System.EventHandler(this.ttitle4_Click);
            // 
            // tpic3
            // 
            this.tpic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpic3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpic3.Location = new System.Drawing.Point(874, 92);
            this.tpic3.Name = "tpic3";
            this.tpic3.Size = new System.Drawing.Size(162, 220);
            this.tpic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tpic3.TabIndex = 147;
            this.tpic3.TabStop = false;
            this.tpic3.Click += new System.EventHandler(this.ttitle3_Click);
            // 
            // tpic2
            // 
            this.tpic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpic2.Location = new System.Drawing.Point(698, 92);
            this.tpic2.Name = "tpic2";
            this.tpic2.Size = new System.Drawing.Size(162, 220);
            this.tpic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tpic2.TabIndex = 146;
            this.tpic2.TabStop = false;
            this.tpic2.Click += new System.EventHandler(this.ttitle2_Click);
            // 
            // bpic1
            // 
            this.bpic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bpic1.Location = new System.Drawing.Point(50, 495);
            this.bpic1.Name = "bpic1";
            this.bpic1.Size = new System.Drawing.Size(224, 298);
            this.bpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bpic1.TabIndex = 145;
            this.bpic1.TabStop = false;
            this.bpic1.Click += new System.EventHandler(this.btitle1_Click);
            // 
            // tpic1
            // 
            this.tpic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpic1.Location = new System.Drawing.Point(50, 92);
            this.tpic1.Name = "tpic1";
            this.tpic1.Size = new System.Drawing.Size(224, 298);
            this.tpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tpic1.TabIndex = 136;
            this.tpic1.TabStop = false;
            this.tpic1.Click += new System.EventHandler(this.ttitle1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(45, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 173;
            this.label3.Text = "오늘의 책";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(45, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1173, 12);
            this.label4.TabIndex = 172;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(48, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1173, 12);
            this.label2.TabIndex = 174;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(48, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 175;
            this.label1.Text = "베스트셀러";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btitle4);
            this.Controls.Add(this.btitle3);
            this.Controls.Add(this.btitle2);
            this.Controls.Add(this.bpic4);
            this.Controls.Add(this.bpic3);
            this.Controls.Add(this.bpic2);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.bpub);
            this.Controls.Add(this.bprice);
            this.Controls.Add(this.bauthor);
            this.Controls.Add(this.btitle1);
            this.Controls.Add(this.ttitle4);
            this.Controls.Add(this.ttitle3);
            this.Controls.Add(this.ttitle2);
            this.Controls.Add(this.tpic4);
            this.Controls.Add(this.tpic3);
            this.Controls.Add(this.tpic2);
            this.Controls.Add(this.bpic1);
            this.Controls.Add(this.tdate);
            this.Controls.Add(this.tpub);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.tauthor);
            this.Controls.Add(this.ttitle1);
            this.Controls.Add(this.tpic1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1264, 822);
            ((System.ComponentModel.ISupportInitialize)(this.bpic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label tdate;
        private System.Windows.Forms.Label tpub;
        private System.Windows.Forms.Label tprice;
        private System.Windows.Forms.Label tauthor;
        private System.Windows.Forms.Label ttitle1;
        private System.Windows.Forms.PictureBox tpic1;
        private System.Windows.Forms.PictureBox bpic1;
        private System.Windows.Forms.PictureBox tpic2;
        private System.Windows.Forms.PictureBox tpic3;
        private System.Windows.Forms.PictureBox tpic4;
        private System.Windows.Forms.Label ttitle2;
        private System.Windows.Forms.Label ttitle3;
        private System.Windows.Forms.Label ttitle4;
        private System.Windows.Forms.Label btitle4;
        private System.Windows.Forms.Label btitle3;
        private System.Windows.Forms.Label btitle2;
        private System.Windows.Forms.PictureBox bpic4;
        private System.Windows.Forms.PictureBox bpic3;
        private System.Windows.Forms.PictureBox bpic2;
        private System.Windows.Forms.Label bdate;
        private System.Windows.Forms.Label bpub;
        private System.Windows.Forms.Label bprice;
        private System.Windows.Forms.Label bauthor;
        private System.Windows.Forms.Label btitle1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
