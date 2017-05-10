using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    class Program
    {
       public static void Main(string[] args)
        {
            Costomer Simon = new Costomer();
            Simon.CostName = "Simon Kirakosyan";
            Simon.freeMoneyForDep = 30000;
            Simon.totalActivs = 160000;
            Simon.needForCredit = 40000;
            Bank Convers = new Bank();
            Convers.GiveCredit(Simon);
            Convers.TakeDeposit(Simon);
            PrintState(Simon);
            Console.Read();
        }
        static void PrintState (Costomer Simon)
        {
            Console.WriteLine("Costomer {0} get your {1} credit and Thank You for {2} deposit", Simon.CostName, Simon.Credits, Simon.Deposits);

        }

    }
}
