using KBbooks.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui
{
    partial class Login : UserControl
    {
        DaoOra ora = null;
        string mem_id;
        string mem_pw;
        MainForm mf;
        const string UC_HOME = "Home";
        public Login(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void AloginBtn_Click(object sender, EventArgs e)
        {
            tryLogin();
        }

        private void id_Click(object sender, EventArgs e)
        {
            if(id.Text == "ID가 존재하지 않거나, 비밀번호가 틀렸습니다.")
            {
                id.Text = "";
            }
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tryLogin();
            }
        }

        private void tryLogin()
        {
            mem_id = id.Text.ToString();
            mem_pw = pass.Text.ToString();
            int logined = ora.Login(new Member(mem_id, mem_pw));
            if (logined == 1)
            {
                mf.setLogin(logined, mem_id);
                mf.setManager(ora.checkManager(new Member(mem_id, mem_pw)));
                mf.controlView(new Home(ora, mf, mf.getToday()), UC_HOME);
            }
            else
            {
                id.Text = "ID가 존재하지 않거나, 비밀번호가 틀렸습니다.";
                pass.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            id.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pass.Focus();
        }
    }
}
