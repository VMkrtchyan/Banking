using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    class Bank
    {
        
        public int AllCredits;
        public int AllDeposits;
        public void  GiveCredit(Costomer costomer) {
            if (costomer.PayingCapacity==true)
            { costomer.Credits = costomer.needForCredit;
                this.AllCredits += costomer.Credits;
                costomer.needForCredit = 0;

            }
        }
        public void TakeDeposit(Costomer costomer) {
            if (costomer.freeMoneyForDep>0)
            {
                this.AllDeposits += costomer.freeMoneyForDep;
                costomer.Deposits = costomer.freeMoneyForDep;
                costomer.freeMoneyForDep = 0;

            }

        }
    }
}
