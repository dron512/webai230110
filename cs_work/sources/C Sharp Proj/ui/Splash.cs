using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBbooks.ui
{
    public partial class Splash : Form
    {
        delegate void dele();
        public Splash()
        {
            AllowTransparency= true;
            this.BackColor= Color.White;
            this.TransparencyKey = Color.White;
            InitializeComponent();
            System.Threading.Thread th1 = new System.Threading.Thread(run);
            th1.Start();
        }
        private void formClose()
        {
            this.Close();
        }
        private void run()
        {
            Thread.Sleep(2000);
            this.Invoke(new dele(formClose));
        }
    }
}
