using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBbooks.util
{
    internal class Book
    {
        string rank, code, title, author, pub, date, price, genre, sale, imagename;
        public Book(string rank, string code, string title, string author, string pub, string date, string price, string genre, string sale)
        {
            this.rank = rank;
            this.code = code;
            this.title = title;
            this.author = author;
            this.pub = pub;
            this.date = date;
            this.price = price;
            this.genre = genre;
            this.sale = sale;
        }
        public Book(string code, string title, string author, string pub, string date, string price)
        {
            this.code = code;
            this.title = title;
            this.author = author;
            this.pub = pub;
            this.date = date;
            this.price = price;
        }
        public Book(string code, string title, string author, string pub, string date, string price, string genre, string imagename)
        {
            this.code = code;
            this.title = title;
            this.author = author;
            this.pub = pub;
            this.date = date;
            this.price = price;
            this.genre = genre;
            this.imagename = imagename;
        }
        public Book(string code, string title, string author, string pub, string price, string date, string genre)
        {
            this.code = code;
            this.title = title;
            this.author = author;
            this.pub = pub;
            this.price = price;
            this.date = date;
            this.genre = genre;
        }
        public Book(string imagename)
        {
            this.imagename = imagename;
        }


        public string Rank { get => rank; set => rank = value; }
        public string Code { get => code; set => code = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Pub { get => pub; set => pub = value; }
        public string Date { get => date; set => date = value; }
        public string Price { get => price; set => price = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Sale { get => sale; set => sale = value; }
        public string Imagename { get => imagename; set => imagename = value; }
    }
}
