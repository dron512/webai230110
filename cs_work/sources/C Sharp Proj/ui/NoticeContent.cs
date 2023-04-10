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

namespace KBbooks.ui
{
    partial class NoticeContent : UserControl
    {
        DaoOra ora;
        MainForm mf;
        public NoticeContent(DaoOra ora, MainForm mf, string code)
        {
            InitializeComponent();
            this.ora = ora;
            this.mf = mf;
            List<Notice> notice = ora.getNoticeContent(code);
            title.Text = notice[0].Title;
            date.Text = notice[0].Date;
            content.Text = " " + notice[0].Content;
            this.code.Text = notice[0].Code;
            List<Notice> prev = ora.getPrevNotice(code);
            if(prev.Count == 0)
            {
                prevtitle.Text = "이전 글이 없습니다.";
                prevtitle.Enabled = false;
            }
            else
            {
                prevtitle.Text = prev[0].Title;
                prevcode.Text = prev[0].Code;
            }
            List<Notice> next = ora.getNextNotice(code);
            if (next.Count == 0)
            {
                nexttitle.Text = "다음 글이 없습니다.";
                nexttitle.Enabled = false;
            }
            else
            {
                nexttitle.Text = next[0].Title;
                nextcode.Text = next[0].Code;
            }
        }

        private void prevtitle_Click(object sender, EventArgs e)
        {
            mf.controlView(new NoticeContent(ora, mf, prevcode.Text), "NoticeContent");
        }

        private void nexttitle_Click(object sender, EventArgs e)
        {
            mf.controlView(new NoticeContent(ora, mf, nextcode.Text), "NoticeContent");
        }
    }
}
