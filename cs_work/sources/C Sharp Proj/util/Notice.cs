using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBbooks.util
{
    internal class Notice
    {
        string code, title, content, date;
        public Notice(string code, string title, string content, string date)
        {
            this.code = code;
            this.title = title;
            this.content = content;
            this.date = date;
        }

        public string Code { get => code; set => code = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Date { get => date; set => date = value; }
    }
}
