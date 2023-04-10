using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBbooks.util
{
    internal class Member
    {
        string id, pw, name, addr, phone;
        int buy;
        public Member(string id, string pw, string name, string addr, string phone)
        {
            this.id = id;
            this.pw = pw;
            this.name = name;
            this.addr = addr;
            this.phone = phone;
        }
        public Member (string id, string name, string addr, string phone, int buy)
        {
            this.id = id;
            this.name = name;
            this.addr = addr;
            this.phone = phone;
            this.buy = buy;
        }
        public Member(string id, string pw)
        {
            this.id = id;
            this.pw = pw;
        }
        public Member(string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
        public string Pw { get => pw; set => pw = value; }
        public string Name { get => name; set => name = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Buy { get => buy; set => buy = value; }
    }
}
