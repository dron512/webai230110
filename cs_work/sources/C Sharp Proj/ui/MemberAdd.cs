using KBbooks.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui
{
    partial class MemberAdd : UserControl
    {
        DaoOra ora = null;
        MainForm mf;
        const string UC_HOME = "Home";
        public MemberAdd(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
        }
               

        private void MemOkBtn_Click_3(object sender, EventArgs e)
        {
            int check = ora.idDupCheck(id.Text);
            int err = 0;
            if(check == 1)
            {
                id.Text = "이미 존재하는 ID입니다.";
                err++;
            }
            if(id.Text == "")
            {
                id.Text = "ID를 입력해주세요.";
                err++;
            }
            if(pass.Text != passok.Text)
            {
                pass.Text = "비밀번호가 일치하지 않습니다.";
                pass.PasswordChar = '\0';
                passok.Text = "";
                err++;
            }
            if(pass.Text == "" && passok.Text == "")
            {
                pass.Text = "비밀번호를 입력해주세요.";
                pass.PasswordChar = '\0';
            }
            if(name.Text == "")
            {
                name.Text = "이름을 입력해주세요.";
                err++;
            }
            if(addr.Text == "")
            {
                addr.Text = "주소를 입력해주세요.";
                err++;
            }
            Regex reg = new Regex(@"^01[0169]-[0-9]{4}-[0-9]{4}$");
            if (!reg.IsMatch(tel.Text))
            {
                tel.Text = "전화번호를 올바르게 입력해주세요.";
                err++;
            }
            int check2 = ora.telDupCheck(tel.Text);
            if(check2 == 1)
            {
                tel.Text = "이미 등록된 전화번호입니다.";
                err++;
            }
            if (err > 0)
            {
                return;
            }
            else
            {
                ora.newMember(new Member(id.Text, pass.Text, name.Text, addr.Text, tel.Text));
                ora.commit();
                mf.controlView(new MemberAddComplete(ora, mf, name.Text), "MemberAddComplete");
            }
        }

        private void id_Click(object sender, EventArgs e)
        {
            if(id.Text == "이미 존재하는 ID입니다." || id.Text == "ID를 입력해주세요.")
            {
                id.Text = "";
            }
        }

        private void pass_Click(object sender, EventArgs e)
        {
            if(pass.Text == "비밀번호가 일치하지 않습니다." || pass.Text == "비밀번호를 입력해주세요.")
            {
                pass.Text = "";
                pass.PasswordChar = '*';
            }
        }

        private void tel_Click(object sender, EventArgs e)
        {
            if(tel.Text == "전화번호를 올바르게 입력해주세요." || tel.Text == "이미 등록된 전화번호입니다.")
            {
                tel.Text = "";
            }
        }

        private void name_Click(object sender, EventArgs e)
        {
            if(name.Text == "이름을 입력해주세요.")
            {
                name.Text = "";
            }
        }

        private void addr_Click(object sender, EventArgs e)
        {
            if(addr.Text == "주소를 입력해주세요.")
            {
                addr.Text = "";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("회원가입을 취소하고 되돌아가시겠습니까?", "회원가입 취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mf.controlView(new Home(ora, mf, mf.getToday()), UC_HOME);
            }
        }
    }
}
