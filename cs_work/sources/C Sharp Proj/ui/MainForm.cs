using KBbooks.Properties;
using KBbooks.ui;
using KBbooks.ui.admin;
using KBbooks.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks
{
    partial class MainForm : Form
    {
        DaoOra ora = null;
        const string UC_HOME = "Home";
        const string UC_BOOKINFO = "Bookinfo";
        const string UC_BEST = "Best";
        const string UC_SEARCH = "Search";
        const string UC_MEMBERADD = "MemberAdd";
        const string UC_LOGIN = "Login";
        const string UC_NEWBOOK = "Newbook";
        int logined = 0;
        string logined_id = "";
        List<string> incart;
        List<Book> today;
        MainForm mf;

        public MainForm()
        {
            InitializeComponent();
            ora = DaoOra.getInst();
            ora.initView();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);
            mf = this;
            incart = new List<string>();
            today = ora.homeToday();
            controlView(new Home(ora, mf, today), UC_HOME);
            showNotice();
        }
        public void controlView(UserControl uc, string viewName)
        {
            centerLayout.Controls.Clear();
            if (!centerLayout.Controls.ContainsKey(viewName))
            {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[viewName].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            controlView(new Home(ora, mf, mf.getToday()), UC_HOME);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controlView(new Home(ora, mf, mf.getToday()), UC_HOME);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                string find = textBox1.Text;
                textBox1.Text = "";
                controlView(new Search(ora, find, mf), UC_SEARCH);
            }
        }
        private void bestBtn_Click(object sender, EventArgs e)
        {
            controlView(new Best(ora, "all", mf), UC_BEST);
        }
        private void novelBtn_Click(object sender, EventArgs e)
        {
            controlView(new Newbook(ora, "all", mf), UC_NEWBOOK);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    string find = textBox1.Text;
                    textBox1.Text = "";
                    controlView(new Search(ora, find, mf), UC_SEARCH);
                }
            }
        }
        private void best_MouseLeave(object sender, EventArgs e)
        {
            best.Font = new Font(best.Font.Name, best.Font.SizeInPoints, FontStyle.Bold);
        }
        private void novel_MouseLeave(object sender, EventArgs e)
        {
            novel.Font = new Font(novel.Font.Name, novel.Font.SizeInPoints, FontStyle.Bold);
        }

        private void best_MouseEnter(object sender, EventArgs e)
        {
            best.Font = new Font(best.Font.Name, best.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void novel_MouseEnter(object sender, EventArgs e)
        {
            novel.Font = new Font(novel.Font.Name, novel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }

        private void recomBtn_MouseEnter(object sender, EventArgs e)
        {
            recomBtn.Font = new Font(recomBtn.Font.Name, recomBtn.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }

        private void recomBtn_MouseLeave(object sender, EventArgs e)
        {
            recomBtn.Font = new Font(recomBtn.Font.Name, recomBtn.Font.SizeInPoints, FontStyle.Bold);
        }
        private void myPageBtn_MouseEnter(object sender, EventArgs e)
        {
            myPageBtn.Image = Resources.마이페이지_호버;
        }

        private void myPageBtn_MouseLeave(object sender, EventArgs e)
        {
            myPageBtn.Image = Resources.마이페이지;
        }

        private void cartBtn_MouseEnter(object sender, EventArgs e)
        {
            cartBtn.Image = Resources.카트_호버;
        }

        private void cartBtn_MouseLeave(object sender, EventArgs e)
        {
            cartBtn.Image = Resources.카트;
        }

        private void memberAdd_Click(object sender, EventArgs e)
        {
            if(memberAdd.Text == "회원가입")
            {
                controlView(new MemberAdd(ora, mf), UC_MEMBERADD);
            }
            else if(memberAdd.Text == "관리메뉴")
            {
                controlView(new AdminAdd(ora, mf), "AdminAdd");
            }
        }
        public void setLogin(int logined, string id)
        {
            if(logined == 1) //로그인했을때
            {
                this.logined = 1;
                logined_id = id;
                memberAdd.Visible = false;
                label7.Visible = false;
                label6.Text = "로그아웃";
            }
            else if(logined == 2) //로그인 상태에서 탈퇴했을때
            {
                this.logined = 0;
                logined_id = id;
                memberAdd.Visible = true;
                label7.Visible = true;
                label6.Text = "로그인";
                incart.Clear();
            }
            else //로그아웃했을때
            {
                this.logined = 0;
                logined_id = id;
                setManager(0);
                memberAdd.Visible = true;
                label7.Visible = true;
                label6.Text = "로그인";
                incart.Clear();
                controlView(new Home(ora, mf, mf.getToday()), "Home");
            }
        }
        public void setManager(int onoff)
        {
            if(onoff == 1)
            {
                memberAdd.Visible = true;
                label7.Visible = true;
                memberAdd.Text = "관리메뉴";
            }
            else if(onoff == 0)
            {
                memberAdd.Visible = false;
                label7.Visible = false;
                memberAdd.Text = "회원가입";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if(logined == 0)
            {
                controlView(new Login(ora, mf), UC_LOGIN);
            }
            else
            {
                setLogin(0, "");
            }
        }

        private void myPageBtn_Click(object sender, EventArgs e)
        {
            if(logined == 1)
            {
                controlView(new MyOrder(ora, mf), "MyOrder");
            }
            else
            {
                controlView(new Login(ora, mf), UC_LOGIN);
            }
        }

        private void recomBtn_Click(object sender, EventArgs e)
        {
            if(logined == 1)
            {
                controlView(new Recom(ora, mf), "Recom");
            }
            else
            {
                controlView(new Login(ora, mf), "Login");
            }
        }
        public string sendID()
        {
            if(logined == 1)
            {
                return logined_id;
            }
            else
            {
                return null;
            }
        }

        public void getInCart(string code)
        {
            if (logined == 1)
            {
                if (incart.Count < 5)
                {
                    incart.Add(code);
                }
            }
            else
            {
                controlView(new Login(ora, mf), UC_LOGIN);
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if(logined == 1)
            {
                controlView(new Cart(ora, mf, incart), "Cart");
            }
            else
            {
                controlView(new Login(ora, mf), UC_LOGIN);
            }
        }
        public void getOutCart(int index)
        {
            incart.RemoveAt(index);
            controlView(new Cart(ora, mf, incart), "Cart");
        }
        public void cleanCart()
        {
            incart.Clear();
        }
        public List<string> getCart()
        {
            return incart;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        public void showNotice()
        {
            List<Notice> notice = ora.getNotice();
            if (notice.Count == 0)
            {
                noticeTitle.Text = "등록된 공지사항이 없습니다.";
                noticeTitle.Enabled = false;
            }
            else
            {
                noticeTitle.Text = notice[0].Title;
                noticeCode.Text = notice[0].Code;
                noticeTitle.Enabled = true;
            }
        }
        private void noticeTitle_Click(object sender, EventArgs e)
        {
            controlView(new NoticeContent(ora, mf, noticeCode.Text), "NoticeContent");
        }
        public List<Book> getToday()
        {
            return today;
        }
    }
}
