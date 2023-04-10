namespace KBbooks.ui
{
    partial class MyInfo
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
            this.infolabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderlabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.passok = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.updateok = new System.Windows.Forms.Label();
            this.getoff = new System.Windows.Forms.Label();
            this.getoffBtn = new System.Windows.Forms.PictureBox();
            this.updateBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.getoffBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(18, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 30);
            this.label6.TabIndex = 150;
            this.label6.Text = "마이 페이지";
            // 
            // infolabel
            // 
            this.infolabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infolabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infolabel.Location = new System.Drawing.Point(288, 25);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(66, 23);
            this.infolabel.TabIndex = 149;
            this.infolabel.Text = "내 정보";
            this.infolabel.Click += new System.EventHandler(this.infolabel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 23);
            this.label2.TabIndex = 148;
            this.label2.Text = "・";
            // 
            // orderlabel
            // 
            this.orderlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderlabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderlabel.Location = new System.Drawing.Point(176, 25);
            this.orderlabel.Name = "orderlabel";
            this.orderlabel.Size = new System.Drawing.Size(84, 23);
            this.orderlabel.TabIndex = 147;
            this.orderlabel.Text = "주문 확인";
            this.orderlabel.Click += new System.EventHandler(this.orderlabel_Click);
            this.orderlabel.MouseEnter += new System.EventHandler(this.orderlabel_MouseEnter);
            this.orderlabel.MouseLeave += new System.EventHandler(this.orderlabel_MouseLeave);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(580, 688);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 26);
            this.update.TabIndex = 173;
            this.update.Text = "수정하기";
            this.update.Click += new System.EventHandler(this.label7_Click);
            // 
            // tel
            // 
            this.tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tel.Location = new System.Drawing.Point(457, 594);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(346, 18);
            this.tel.TabIndex = 169;
            this.tel.Enter += new System.EventHandler(this.tel_Enter);
            // 
            // addr
            // 
            this.addr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addr.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addr.Location = new System.Drawing.Point(457, 513);
            this.addr.MaxLength = 50;
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(346, 18);
            this.addr.TabIndex = 167;
            // 
            // passok
            // 
            this.passok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passok.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passok.Location = new System.Drawing.Point(458, 351);
            this.passok.MaxLength = 30;
            this.passok.Name = "passok";
            this.passok.PasswordChar = '*';
            this.passok.Size = new System.Drawing.Size(346, 18);
            this.passok.TabIndex = 163;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass.Location = new System.Drawing.Point(458, 270);
            this.pass.MaxLength = 30;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(346, 18);
            this.pass.TabIndex = 161;
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(444, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 159;
            this.label1.Text = "개인정보 수정";
            // 
            // underbar
            // 
            this.underbar.AutoSize = true;
            this.underbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.underbar.Location = new System.Drawing.Point(444, 135);
            this.underbar.Name = "underbar";
            this.underbar.Size = new System.Drawing.Size(377, 12);
            this.underbar.TabIndex = 158;
            this.underbar.Text = "                                                                                 " +
    "            ";
            this.underbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(446, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 156;
            this.label8.Text = "비밀번호 확인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(446, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 155;
            this.label5.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(446, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 154;
            this.label4.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(446, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 153;
            this.label3.Text = "주소";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(446, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 19);
            this.label10.TabIndex = 151;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(446, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 152;
            this.label11.Text = "비밀번호";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.id.Location = new System.Drawing.Point(455, 190);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(348, 18);
            this.id.TabIndex = 174;
            this.id.Text = "id";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.name.Location = new System.Drawing.Point(455, 431);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(348, 18);
            this.name.TabIndex = 175;
            this.name.Text = "name";
            // 
            // updateok
            // 
            this.updateok.AutoSize = true;
            this.updateok.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updateok.Location = new System.Drawing.Point(530, 643);
            this.updateok.Name = "updateok";
            this.updateok.Size = new System.Drawing.Size(200, 19);
            this.updateok.TabIndex = 176;
            this.updateok.Text = "개인정보가 수정되었습니다!";
            this.updateok.Visible = false;
            // 
            // getoff
            // 
            this.getoff.AutoSize = true;
            this.getoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(120)))));
            this.getoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getoff.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.getoff.ForeColor = System.Drawing.Color.White;
            this.getoff.Location = new System.Drawing.Point(740, 753);
            this.getoff.Name = "getoff";
            this.getoff.Size = new System.Drawing.Size(68, 17);
            this.getoff.TabIndex = 203;
            this.getoff.Text = "회원 탈퇴";
            this.getoff.Click += new System.EventHandler(this.getoff_Click);
            // 
            // getoffBtn
            // 
            this.getoffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getoffBtn.Image = global::KBbooks.Properties.Resources.버튼비활성;
            this.getoffBtn.Location = new System.Drawing.Point(732, 748);
            this.getoffBtn.Name = "getoffBtn";
            this.getoffBtn.Size = new System.Drawing.Size(85, 27);
            this.getoffBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.getoffBtn.TabIndex = 202;
            this.getoffBtn.TabStop = false;
            this.getoffBtn.Click += new System.EventHandler(this.getoff_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.updateBtn.Location = new System.Drawing.Point(445, 680);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(371, 43);
            this.updateBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateBtn.TabIndex = 171;
            this.updateBtn.TabStop = false;
            this.updateBtn.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox8.Location = new System.Drawing.Point(445, 583);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(371, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 170;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox7.Location = new System.Drawing.Point(445, 502);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(371, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 168;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox6.Location = new System.Drawing.Point(445, 421);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(371, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 166;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox5.Location = new System.Drawing.Point(446, 340);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(371, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 164;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox3.Location = new System.Drawing.Point(446, 259);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 162;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox2.Location = new System.Drawing.Point(446, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 160;
            this.pictureBox2.TabStop = false;
            // 
            // MyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.getoff);
            this.Controls.Add(this.getoffBtn);
            this.Controls.Add(this.updateok);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.update);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.passok);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.underbar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderlabel);
            this.Name = "MyInfo";
            this.Size = new System.Drawing.Size(1264, 822);
            ((System.ComponentModel.ISupportInitialize)(this.getoffBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orderlabel;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.PictureBox updateBtn;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox passok;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label underbar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label updateok;
        private System.Windows.Forms.Label getoff;
        private System.Windows.Forms.PictureBox getoffBtn;
    }
}
