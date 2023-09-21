using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Encapsulation
    {
    }
    public class Account
    {
        public int accountBalance;
        public void SetBalance (int amount)
        {
            this.accountBalance=amount;
        }
        public void GetBalance()
        {
            Console.WriteLine("Your account balance is: "+accountBalance);
        }
    }
}
