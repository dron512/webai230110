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
    partial class BuyComplete : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public BuyComplete (DaoOra ora, MainForm mf)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
        }
        private void homeLabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new Home(ora, mf, mf.getToday()), "Home");
        }

        private void mypageLabel_Click(object sender, EventArgs e)
        {
            mf.controlView(new MyOrder(ora, mf), "MyOrder");
        }
    }
}
