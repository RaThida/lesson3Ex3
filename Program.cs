using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3Ex3
{//a) wtie a class accont with the following members
    class Account
    {
        private string strType;
        private string strName;
        private float fltBalance;

        public float Balance  // b) write a read only property balance that return fltbalance
        {
            get { return fltBalance; }
        }

        public Account(string x, float GiveMeTheBalance)
        { 
            strName = (x);
          
            fltBalance = GiveMeTheBalance;
        }
        public string CalInterest()
        {
            string ToReturn;
            ToReturn = "the Name and balance of account is"
                 + strName.ToString() + "and" + fltBalance.ToString();
            return ToReturn;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account x1, x2;
           
            Console.Write("Give me the Name for 1st Account obj please: ");
            string strName = Console.ReadLine();
            Console.Write("Give me the balance for 1st Account obj please: ");
            float fltBalance = float.Parse(Console.ReadLine());
            x1 = new Account(strName, fltBalance);
            
            Console.Write("Give me the Name for 2nd Account obj please: ");
            String Name = Console.ReadLine();
            Console.Write("Give me the balance for 2nd Account obj please: ");
            float Balance = float.Parse(Console.ReadLine());
            x2 = new Account(Name, Balance);

            Console.WriteLine("x1: " + x1.CalInterest());
            Console.WriteLine("x2: " + x2.CalInterest());
            Console.Write("Total balance of the 2 Account is: ");
            Console.WriteLine((x1.Balance + x2.Balance).ToString());

        }
    }
}
