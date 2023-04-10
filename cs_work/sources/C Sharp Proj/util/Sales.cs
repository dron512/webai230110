using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBbooks.util
{
    internal class Sales
    {
        string scode, bcode, title, id, date;
        public Sales(string scode, string bcode, string title, string id, string date)
        {
            this.scode = scode;
            this.bcode = bcode;
            this.title = title;
            this.id = id;
            this.date = date;
        }
        public string Scode { get => scode; set => scode = value; }
        public string Bcode { get => bcode; set => bcode = value; }
        public string Title { get => title; set => title = value; }
        public string Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
    }
}
