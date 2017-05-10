using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    public class Costomer
    {
        public string CostName;
        public int freeMoneyForDep=0;
        public int totalActivs;
        public int needForCredit=0;
        public int Credits;
        public int Deposits;
        public bool PayingCapacity {
            get {
                if (this.totalActivs>this.needForCredit) { return true; }
                else { return false; }

            }
               }



    }
}
