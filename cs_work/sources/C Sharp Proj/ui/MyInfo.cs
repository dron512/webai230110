using KBbooks.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui
{
    partial class MyInfo : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public MyInfo(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            showUserData();
            if(ora.checkManager(new Member(mf.sendID())) == 1)
            {
                getoff.Visible = false;
                getoffBtn.Visible = false;
                update.Visible = false;
                updateBtn.Visible = false;
                pass.Enabled = false;
                passok.Enabled = false;
                addr.Enabled = false;
                tel.Enabled = false;
            }
            else
            {
                getoff.Visible = true;
                getoffBtn.Visible = true;
                update.Visible = true;
                updateBtn.Visible = true;
                pass.Enabled = true;
                passok.Enabled = true;
                addr.Enabled = true;
                tel.Enabled = true;
            }
        }

        public void showUserData()
        {
            List<Member> memList = ora.getMemberData(mf.sendID());
            id.Text = memList[0].Id;
            name.Text = memList[0].Name;
            addr.Text = memList[0].Addr;
            tel.Text = memList[0].Phone;
        }
        private void orderlabel_MouseEnter(object sender, EventArgs e)
        {
            orderlabel.Font = new Font(orderlabel.Font.Name, orderlabel.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
        }
        private void orderlabel_MouseLeave(object sender, EventArgs e)
        {
            orderlabel.Font = new Font(orderlabel.Font.Name, orderlabel.Font.SizeInPoints, FontStyle.Bold);
        }

        private void orderlabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new MyOrder(ora, mf), "MyOrder");
        }

        private void infolabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new MyInfo(ora, mf), "MyInfo");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label1.Focus();
            int err = 0;
            if(pass.Text != passok.Text)
            {
                pass.Text = "비밀번호를 확인해주세요.";
                pass.PasswordChar = '\0';
                passok.Text = "";
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
            if (tel.Text == "")
            {
                tel.Text = "전화번호를 입력해주세요.";
                err++;
            }
            if(err == 0)
            {
                if (pass.Text == "")
                {
                    string query = $"update proj_member set mem_addr = '{addr.Text}', mem_tel = '{tel.Text}' where mem_id = '{id.Text}'";
                    ora.updateMember(query);
                    ora.commit();
                    updateok.Visible = true;
                }
                if (pass.Text != "" && pass.Text != "비밀번호를 확인해주세요.")
                {
                    string query = $"update proj_member set mem_pw = '{pass.Text}', mem_addr = '{addr.Text}', mem_tel = '{tel.Text}' where mem_id = '{id.Text}'";
                    ora.updateMember(query);
                    ora.commit();
                    updateok.Visible = true;
                }
            }
        }

        private void tel_Enter(object sender, EventArgs e)
        {
            if(tel.Text == "전화번호를 입력해주세요." || tel.Text == "전화번호를 올바르게 입력해주세요.")
            {
                tel.Text = "";
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if(pass.Text == "비밀번호를 확인해주세요.")
            {
                pass.Text = "";
                pass.PasswordChar = '*';
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pass.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            passok.Focus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            addr.Focus();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tel.Focus();
        }

        private void getoff_Click(object sender, EventArgs e)
        {
            mf.controlView(new MemberDelete(ora, mf), "MemberDelete");
        }
    }
}
