using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace KBbooks.util
{
    internal class Order
    {
        string no, title, date, price, code;
        public Order(string no, string title, string date, string price, string code)
        {
            this.no = no;
            this.title = title;
            this.date = date;
            this.price = price;
            this.code = code;
        }

        public string No { get => no; set => no = value; }
        public string Title { get => title; set => title = value; }
        public string Date { get => date; set => date = value; }
        public string Price { get => price; set => price = value; }
        public string Code { get => code; set => code = value; }
    }
}
