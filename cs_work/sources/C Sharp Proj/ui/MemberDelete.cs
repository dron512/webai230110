using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui
{
    partial class MemberDelete : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public MemberDelete(DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
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
        private void homeLabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new Home(ora, mf, mf.getToday()), "Home");
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            ora.revChangeId(mf.sendID());
            if(ora.deleteMember(mf.sendID()) == 1)
            {
                ora.commit();
                label4.Text = "회원 탈퇴 완료";
                label3.Text = "회원 탈퇴가 완료되었습니다.";
                label1.Text = "지금까지 경북문고를 이용해주셔서";
                label5.Text = "대단히 감사합니다.";
                label7.Text = "";
                label2.Visible = false;
                label6.Visible = false;
                orderlabel.Visible = false;
                infolabel.Visible = false;
                exitLabel.Visible = false;
                exitBtn.Visible = false;
                homeLabel.Text = "처음 화면으로";
                mf.setLogin(2, "");
            }
        }
    }
}
