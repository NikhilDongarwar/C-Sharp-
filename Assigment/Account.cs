using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Account
    {
        static int getid=1941000;
        int id;
        string name;
        double balance;
        
        readonly double roi;

        public Account(string name, double balance)
        {
            roi = 0.07;
            
                id = ++getid;
                Name = name;
                Bal = balance;
            
            
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Bal
        {
            get { return balance; }
            set
            {
                if (value < 1)
                    Console.WriteLine("error");
                else
                    balance = value;

            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance+=amount;
            }
        }
        
        public static double payint(Account obj)
        {
            double intrest = obj.balance *0.1;
            obj.balance = obj.balance + intrest;
            return intrest;
        }

        public int ID
        {
            get { return getid; }
        }
        public void wdraw(double amt)
        {
            const double minamt= 1000.0;
            while (amt > 0)
            {
                if (balance - amt < minamt)
                {
                    Console.WriteLine("Issufficient balance");
                }
                else
                {
                    balance -= amt;
                }
            }
        }
        public string Disp()
        {
            return string.Format("id={0} name={1} balance={2} roi={3}", id, name, balance,roi);

        }

    }

      internal class Program
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account("sam", 10000);
            Console.WriteLine(a1.Disp());
             Console.WriteLine("Intrest="+Account.payint(a1));            
        }

    }
 }
