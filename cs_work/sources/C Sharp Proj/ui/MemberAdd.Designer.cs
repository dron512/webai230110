namespace KBbooks.ui
{
    partial class MemberAdd
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
            this.id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.passok = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.PictureBox();
            this.MemOkBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemOkBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(459, 105);
            this.id.MaxLength = 30;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(346, 18);
            this.id.TabIndex = 22;
            this.id.Click += new System.EventHandler(this.id_Click);
            this.id.Enter += new System.EventHandler(this.id_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(447, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "비밀번호 확인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(447, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(447, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(447, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(447, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(447, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "비밀번호";
            // 
            // underbar
            // 
            this.underbar.AutoSize = true;
            this.underbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.underbar.Location = new System.Drawing.Point(445, 49);
            this.underbar.Name = "underbar";
            this.underbar.Size = new System.Drawing.Size(377, 12);
            this.underbar.TabIndex = 26;
            this.underbar.Text = "                                                                                 " +
    "            ";
            this.underbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(445, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "회원가입";
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass.Location = new System.Drawing.Point(459, 184);
            this.pass.MaxLength = 30;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(346, 18);
            this.pass.TabIndex = 29;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            this.pass.Enter += new System.EventHandler(this.pass_Click);
            // 
            // passok
            // 
            this.passok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passok.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passok.Location = new System.Drawing.Point(459, 265);
            this.passok.MaxLength = 30;
            this.passok.Name = "passok";
            this.passok.PasswordChar = '*';
            this.passok.Size = new System.Drawing.Size(346, 18);
            this.passok.TabIndex = 32;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(458, 346);
            this.name.MaxLength = 30;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(346, 18);
            this.name.TabIndex = 34;
            this.name.Click += new System.EventHandler(this.name_Click);
            this.name.Enter += new System.EventHandler(this.name_Click);
            // 
            // addr
            // 
            this.addr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addr.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addr.Location = new System.Drawing.Point(458, 427);
            this.addr.MaxLength = 50;
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(346, 18);
            this.addr.TabIndex = 36;
            this.addr.Click += new System.EventHandler(this.addr_Click);
            this.addr.Enter += new System.EventHandler(this.addr_Click);
            // 
            // tel
            // 
            this.tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tel.Location = new System.Drawing.Point(458, 508);
            this.tel.MaxLength = 50;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(346, 18);
            this.tel.TabIndex = 38;
            this.tel.Click += new System.EventHandler(this.tel_Click);
            this.tel.Enter += new System.EventHandler(this.tel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(476, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 26);
            this.label7.TabIndex = 43;
            this.label7.Text = "회원가입";
            this.label7.Click += new System.EventHandler(this.MemOkBtn_Click_3);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.label9.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(709, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 26);
            this.label9.TabIndex = 44;
            this.label9.Text = "취소";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.cancelBtn.Location = new System.Drawing.Point(657, 579);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 43);
            this.cancelBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cancelBtn.TabIndex = 42;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // MemOkBtn
            // 
            this.MemOkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemOkBtn.Image = global::KBbooks.Properties.Resources.버튼;
            this.MemOkBtn.Location = new System.Drawing.Point(446, 579);
            this.MemOkBtn.Name = "MemOkBtn";
            this.MemOkBtn.Size = new System.Drawing.Size(160, 43);
            this.MemOkBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MemOkBtn.TabIndex = 41;
            this.MemOkBtn.TabStop = false;
            this.MemOkBtn.Click += new System.EventHandler(this.MemOkBtn_Click_3);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox8.Location = new System.Drawing.Point(446, 497);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(371, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 39;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox7.Location = new System.Drawing.Point(446, 416);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(371, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox6.Location = new System.Drawing.Point(446, 335);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(371, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox5.Location = new System.Drawing.Point(447, 254);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(371, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox3.Location = new System.Drawing.Point(447, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox2.Location = new System.Drawing.Point(447, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // MemberAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.MemOkBtn);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.passok);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.underbar);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MemberAdd";
            this.Size = new System.Drawing.Size(1264, 822);
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemOkBtn)).EndInit();
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
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label underbar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox passok;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox MemOkBtn;
        private System.Windows.Forms.PictureBox cancelBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}
