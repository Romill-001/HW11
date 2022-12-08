using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov11
{
    public class Bank
    {
        private Hashtable hashtable = new Hashtable();
        public ulong CreateAccount()
        {
            Account opened = new Account();
            hashtable[opened.Number] = opened;
            return opened.Number;
        }
        public ulong CreateAccount(TypeAccount type)
        {
            Account opened = new Account(type);
            hashtable[opened.Number] = opened;
            return opened.Number;
        }

        public void DeleteAccount(ulong number)
        {
            hashtable.Remove(number);
        }
        public List<Account> GetListAccount()
        {
            List<Account> accounts = new List<Account>();
            foreach (var item in hashtable.Values)
            {
                if (item is Account)
                {
                    accounts.Add((Account)item);
                }
            }
            return accounts;
        }
    }
}
