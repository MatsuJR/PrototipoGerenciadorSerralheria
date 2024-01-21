using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemory.Model
{
    public class Finance
    {
        public int FinanceId { get; }
        public double Value { get; set; }
        public string FinanceDescription { get; set; }

        static int cont = 0;

        public Finance(int financeId, double value, string financeDescription)
        {
            FinanceId = financeId;
            Value = value;
            FinanceDescription = financeDescription;
        }
    }
}