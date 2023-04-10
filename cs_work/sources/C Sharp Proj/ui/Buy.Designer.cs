namespace KBbooks.ui
{
    partial class Buy
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
            this.buyText = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.PictureBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.underbar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.many = new System.Windows.Forms.Label();
            this.sumprice = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.pub1 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.author1 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.date2 = new System.Windows.Forms.Label();
            this.pub2 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.author2 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.pub3 = new System.Windows.Forms.Label();
            this.price3 = new System.Windows.Forms.Label();
            this.author3 = new System.Windows.Forms.Label();
            this.title3 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.pub4 = new System.Windows.Forms.Label();
            this.price4 = new System.Windows.Forms.Label();
            this.author4 = new System.Windows.Forms.Label();
            this.title4 = new System.Windows.Forms.Label();
            this.date5 = new System.Windows.Forms.Label();
            this.pub5 = new System.Windows.Forms.Label();
            this.price5 = new System.Windows.Forms.Label();
            this.author5 = new System.Windows.Forms.Label();
            this.title5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.buyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            this.SuspendLayout();
            // 
            // buyText
            // 
            this.buyText.AutoSize = true;
            this.buyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(120)))));
            this.buyText.Cursor = System.Windows.Forms.Cursors.Default;
            this.buyText.Enabled = false;
            this.buyText.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold);
            this.buyText.ForeColor = System.Drawing.Color.White;
            this.buyText.Location = new System.Drawing.Point(898, 663);
            this.buyText.Name = "buyText";
            this.buyText.Size = new System.Drawing.Size(100, 26);
            this.buyText.TabIndex = 55;
            this.buyText.Text = "주문하기";
            this.buyText.Click += new System.EventHandler(this.label7_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.buyBtn.Enabled = false;
            this.buyBtn.Image = global::KBbooks.Properties.Resources.버튼비활성;
            this.buyBtn.Location = new System.Drawing.Point(690, 655);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(516, 43);
            this.buyBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buyBtn.TabIndex = 54;
            this.buyBtn.TabStop = false;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // addr
            // 
            this.addr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addr.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addr.Location = new System.Drawing.Point(702, 184);
            this.addr.MaxLength = 50;
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(491, 18);
            this.addr.TabIndex = 52;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox3.Location = new System.Drawing.Point(690, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(516, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(688, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 26);
            this.label6.TabIndex = 50;
            this.label6.Text = "배송 정보";
            // 
            // underbar
            // 
            this.underbar.AutoSize = true;
            this.underbar.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.underbar.Location = new System.Drawing.Point(688, 49);
            this.underbar.Name = "underbar";
            this.underbar.Size = new System.Drawing.Size(521, 12);
            this.underbar.TabIndex = 49;
            this.underbar.Text = "                                                                                 " +
    "                                                ";
            this.underbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(690, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "주문인";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(690, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "배송지";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox2.Location = new System.Drawing.Point(690, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(516, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(44, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "주문 도서 정보";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(44, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(521, 12);
            this.label4.TabIndex = 56;
            this.label4.Text = "                                                                                 " +
    "                                                ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KBbooks.Properties.Resources.상자;
            this.pictureBox1.Location = new System.Drawing.Point(690, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(690, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "연락처";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(688, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 62;
            this.label8.Text = "결제 정보";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(688, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(521, 12);
            this.label9.TabIndex = 61;
            this.label9.Text = "                                                                                 " +
    "                                                ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(690, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 19);
            this.label10.TabIndex = 63;
            this.label10.Text = "결제하실 금액";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("나눔고딕", 11.25F);
            this.name.Location = new System.Drawing.Point(704, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(489, 21);
            this.name.TabIndex = 66;
            this.name.Text = "이름";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tel
            // 
            this.tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tel.Location = new System.Drawing.Point(702, 266);
            this.tel.MaxLength = 50;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(491, 18);
            this.tel.TabIndex = 59;
            // 
            // many
            // 
            this.many.BackColor = System.Drawing.Color.White;
            this.many.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.many.Location = new System.Drawing.Point(1012, 519);
            this.many.Name = "many";
            this.many.Size = new System.Drawing.Size(194, 21);
            this.many.TabIndex = 67;
            this.many.Text = "총 몇 권";
            this.many.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sumprice
            // 
            this.sumprice.BackColor = System.Drawing.Color.White;
            this.sumprice.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sumprice.Location = new System.Drawing.Point(874, 550);
            this.sumprice.Name = "sumprice";
            this.sumprice.Size = new System.Drawing.Size(332, 37);
            this.sumprice.TabIndex = 68;
            this.sumprice.Text = "가격";
            this.sumprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Cursor = System.Windows.Forms.Cursors.Default;
            this.date1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date1.Location = new System.Drawing.Point(154, 174);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(43, 15);
            this.date1.TabIndex = 143;
            this.date1.Text = "발행일";
            // 
            // pub1
            // 
            this.pub1.AutoSize = true;
            this.pub1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pub1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pub1.Location = new System.Drawing.Point(154, 154);
            this.pub1.Name = "pub1";
            this.pub1.Size = new System.Drawing.Size(43, 15);
            this.pub1.TabIndex = 142;
            this.pub1.Text = "출판사";
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.Cursor = System.Windows.Forms.Cursors.Default;
            this.price1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price1.Location = new System.Drawing.Point(154, 194);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(31, 15);
            this.price1.TabIndex = 140;
            this.price1.Text = "가격";
            // 
            // author1
            // 
            this.author1.AutoSize = true;
            this.author1.Cursor = System.Windows.Forms.Cursors.Default;
            this.author1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.author1.Location = new System.Drawing.Point(154, 134);
            this.author1.Name = "author1";
            this.author1.Size = new System.Drawing.Size(31, 15);
            this.author1.TabIndex = 139;
            this.author1.Text = "저자";
            // 
            // title1
            // 
            this.title1.Cursor = System.Windows.Forms.Cursors.Default;
            this.title1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title1.Location = new System.Drawing.Point(153, 82);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(412, 46);
            this.title1.TabIndex = 138;
            this.title1.Text = "제목";
            this.title1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic1
            // 
            this.pic1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic1.Location = new System.Drawing.Point(46, 82);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(101, 129);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 136;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic2.Location = new System.Drawing.Point(46, 217);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(101, 129);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 144;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic3.Location = new System.Drawing.Point(46, 352);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(101, 129);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 145;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic4.Location = new System.Drawing.Point(46, 487);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(101, 129);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 146;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic5.Location = new System.Drawing.Point(46, 622);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(101, 129);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5.TabIndex = 147;
            this.pic5.TabStop = false;
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Cursor = System.Windows.Forms.Cursors.Default;
            this.date2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date2.Location = new System.Drawing.Point(154, 311);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(43, 15);
            this.date2.TabIndex = 152;
            this.date2.Text = "발행일";
            // 
            // pub2
            // 
            this.pub2.AutoSize = true;
            this.pub2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pub2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pub2.Location = new System.Drawing.Point(154, 291);
            this.pub2.Name = "pub2";
            this.pub2.Size = new System.Drawing.Size(43, 15);
            this.pub2.TabIndex = 151;
            this.pub2.Text = "출판사";
            // 
            // price2
            // 
            this.price2.AutoSize = true;
            this.price2.Cursor = System.Windows.Forms.Cursors.Default;
            this.price2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price2.Location = new System.Drawing.Point(154, 331);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(31, 15);
            this.price2.TabIndex = 150;
            this.price2.Text = "가격";
            // 
            // author2
            // 
            this.author2.AutoSize = true;
            this.author2.Cursor = System.Windows.Forms.Cursors.Default;
            this.author2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.author2.Location = new System.Drawing.Point(154, 271);
            this.author2.Name = "author2";
            this.author2.Size = new System.Drawing.Size(31, 15);
            this.author2.TabIndex = 149;
            this.author2.Text = "저자";
            // 
            // title2
            // 
            this.title2.Cursor = System.Windows.Forms.Cursors.Default;
            this.title2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title2.Location = new System.Drawing.Point(153, 219);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(412, 46);
            this.title2.TabIndex = 148;
            this.title2.Text = "제목";
            this.title2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Cursor = System.Windows.Forms.Cursors.Default;
            this.date3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date3.Location = new System.Drawing.Point(154, 446);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(43, 15);
            this.date3.TabIndex = 157;
            this.date3.Text = "발행일";
            // 
            // pub3
            // 
            this.pub3.AutoSize = true;
            this.pub3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pub3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pub3.Location = new System.Drawing.Point(154, 426);
            this.pub3.Name = "pub3";
            this.pub3.Size = new System.Drawing.Size(43, 15);
            this.pub3.TabIndex = 156;
            this.pub3.Text = "출판사";
            // 
            // price3
            // 
            this.price3.AutoSize = true;
            this.price3.Cursor = System.Windows.Forms.Cursors.Default;
            this.price3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price3.Location = new System.Drawing.Point(154, 466);
            this.price3.Name = "price3";
            this.price3.Size = new System.Drawing.Size(31, 15);
            this.price3.TabIndex = 155;
            this.price3.Text = "가격";
            // 
            // author3
            // 
            this.author3.AutoSize = true;
            this.author3.Cursor = System.Windows.Forms.Cursors.Default;
            this.author3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.author3.Location = new System.Drawing.Point(154, 406);
            this.author3.Name = "author3";
            this.author3.Size = new System.Drawing.Size(31, 15);
            this.author3.TabIndex = 154;
            this.author3.Text = "저자";
            // 
            // title3
            // 
            this.title3.Cursor = System.Windows.Forms.Cursors.Default;
            this.title3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title3.Location = new System.Drawing.Point(153, 354);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(412, 46);
            this.title3.TabIndex = 153;
            this.title3.Text = "제목";
            this.title3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date4
            // 
            this.date4.AutoSize = true;
            this.date4.Cursor = System.Windows.Forms.Cursors.Default;
            this.date4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date4.Location = new System.Drawing.Point(154, 581);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(43, 15);
            this.date4.TabIndex = 162;
            this.date4.Text = "발행일";
            // 
            // pub4
            // 
            this.pub4.AutoSize = true;
            this.pub4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pub4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pub4.Location = new System.Drawing.Point(154, 561);
            this.pub4.Name = "pub4";
            this.pub4.Size = new System.Drawing.Size(43, 15);
            this.pub4.TabIndex = 161;
            this.pub4.Text = "출판사";
            // 
            // price4
            // 
            this.price4.AutoSize = true;
            this.price4.Cursor = System.Windows.Forms.Cursors.Default;
            this.price4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price4.Location = new System.Drawing.Point(154, 601);
            this.price4.Name = "price4";
            this.price4.Size = new System.Drawing.Size(31, 15);
            this.price4.TabIndex = 160;
            this.price4.Text = "가격";
            // 
            // author4
            // 
            this.author4.AutoSize = true;
            this.author4.Cursor = System.Windows.Forms.Cursors.Default;
            this.author4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.author4.Location = new System.Drawing.Point(154, 541);
            this.author4.Name = "author4";
            this.author4.Size = new System.Drawing.Size(31, 15);
            this.author4.TabIndex = 159;
            this.author4.Text = "저자";
            // 
            // title4
            // 
            this.title4.Cursor = System.Windows.Forms.Cursors.Default;
            this.title4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title4.Location = new System.Drawing.Point(153, 489);
            this.title4.Name = "title4";
            this.title4.Size = new System.Drawing.Size(412, 46);
            this.title4.TabIndex = 158;
            this.title4.Text = "제목";
            this.title4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date5
            // 
            this.date5.AutoSize = true;
            this.date5.Cursor = System.Windows.Forms.Cursors.Default;
            this.date5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date5.Location = new System.Drawing.Point(154, 716);
            this.date5.Name = "date5";
            this.date5.Size = new System.Drawing.Size(43, 15);
            this.date5.TabIndex = 167;
            this.date5.Text = "발행일";
            // 
            // pub5
            // 
            this.pub5.AutoSize = true;
            this.pub5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pub5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pub5.Location = new System.Drawing.Point(154, 696);
            this.pub5.Name = "pub5";
            this.pub5.Size = new System.Drawing.Size(43, 15);
            this.pub5.TabIndex = 166;
            this.pub5.Text = "출판사";
            // 
            // price5
            // 
            this.price5.AutoSize = true;
            this.price5.Cursor = System.Windows.Forms.Cursors.Default;
            this.price5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price5.Location = new System.Drawing.Point(154, 736);
            this.price5.Name = "price5";
            this.price5.Size = new System.Drawing.Size(31, 15);
            this.price5.TabIndex = 165;
            this.price5.Text = "가격";
            // 
            // author5
            // 
            this.author5.AutoSize = true;
            this.author5.Cursor = System.Windows.Forms.Cursors.Default;
            this.author5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.author5.Location = new System.Drawing.Point(154, 676);
            this.author5.Name = "author5";
            this.author5.Size = new System.Drawing.Size(31, 15);
            this.author5.TabIndex = 164;
            this.author5.Text = "저자";
            // 
            // title5
            // 
            this.title5.Cursor = System.Windows.Forms.Cursors.Default;
            this.title5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title5.Location = new System.Drawing.Point(153, 624);
            this.title5.Name = "title5";
            this.title5.Size = new System.Drawing.Size(412, 46);
            this.title5.TabIndex = 163;
            this.title5.Text = "제목";
            this.title5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.Location = new System.Drawing.Point(690, 624);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(386, 19);
            this.checkBox1.TabIndex = 168;
            this.checkBox1.Text = "결제 정보 및 개인정보 이용 약관을 확인하였으며 이에 동의합니다.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.date5);
            this.Controls.Add(this.pub5);
            this.Controls.Add(this.price5);
            this.Controls.Add(this.author5);
            this.Controls.Add(this.title5);
            this.Controls.Add(this.date4);
            this.Controls.Add(this.pub4);
            this.Controls.Add(this.price4);
            this.Controls.Add(this.author4);
            this.Controls.Add(this.title4);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.pub3);
            this.Controls.Add(this.price3);
            this.Controls.Add(this.author3);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.pub2);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.author2);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.pub1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.author1);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.sumprice);
            this.Controls.Add(this.many);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buyText);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.underbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Buy";
            this.Size = new System.Drawing.Size(1264, 822);
            ((System.ComponentModel.ISupportInitialize)(this.buyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buyText;
        private System.Windows.Forms.PictureBox buyBtn;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label underbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label many;
        private System.Windows.Forms.Label sumprice;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label pub1;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label author1;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label pub2;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label author2;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label pub3;
        private System.Windows.Forms.Label price3;
        private System.Windows.Forms.Label author3;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label pub4;
        private System.Windows.Forms.Label price4;
        private System.Windows.Forms.Label author4;
        private System.Windows.Forms.Label title4;
        private System.Windows.Forms.Label date5;
        private System.Windows.Forms.Label pub5;
        private System.Windows.Forms.Label price5;
        private System.Windows.Forms.Label author5;
        private System.Windows.Forms.Label title5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
