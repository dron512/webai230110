using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBbooks.util
{
    internal class Review
    {
        string code, title, score, content, id;
        public Review(string score, string content)
        {
            this.score = score;
            this.content = content;
        }

        public Review(string code, string title, string score, string content, string id)
        {
            this.id = id;
            this.score = score;
            this.content = content;
            this.code = code;
            this.title = title;
            this.id = id;
        }

        public string Score { get => score; set => score = value; }
        public string Content { get => content; set => content = value; }
        public string Code { get => code; set => code = value; }
        public string Title { get => title; set => title = value; }
        public string Id { get => id; set => id = value; }
    }
}
