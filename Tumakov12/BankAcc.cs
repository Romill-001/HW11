using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12
{
    public class BankAcc
    {
        public int Acc { get; set; }
        public int Id { get; set; }
        public BankAcc(int acc, int id)
        {
            Acc = acc;
            Id = id;
        }

        public static bool operator ==(BankAcc a,BankAcc b)
        {
            return a.Acc == b.Acc && a.Id == b.Id;
        }
        public static bool operator !=(BankAcc a, BankAcc b)
        {
            return a.Acc == b.Acc && a.Id == b.Id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            string res = $"{Acc} {Id}";
            return res;
        }
        public override bool Equals(object obj)
        {
            if (obj is BankAcc acc) 
                return Acc == acc.Acc && Id == acc.Id;
            return false;
        }
    }
}
