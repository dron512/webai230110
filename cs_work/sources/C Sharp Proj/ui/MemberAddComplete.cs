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
    partial class MemberAddComplete : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public MemberAddComplete(DaoOra ora, MainForm mf, string name)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            label1.Text = name + " 님,";
        }

        private void MemberAddComplete_Load(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new Login(ora, mf), "Login");
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new Home(ora, mf, mf.getToday()), "Home");
        }
    }
}
