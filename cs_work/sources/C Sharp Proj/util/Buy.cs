using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBbooks.Buy
{
    internal class Buy
    {
        //id, title1.Text, pub1.Text
        private string id;
        private string title;
        private string pub;

        public Buy(string id, string title, string pub)
        {
            this.id = id;
            this.title = title;
            this.pub = pub;
        }

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Pub { get => pub; set => pub = value; }
    }
}
