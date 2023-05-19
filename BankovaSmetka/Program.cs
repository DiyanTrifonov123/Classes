using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaSmetka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount();
            acc1.ID = 1;
            acc1.Balance = 15;
            Console.WriteLine($"Account {acc1.ID}, balance {acc1.Balance}");
        }
    }
}
