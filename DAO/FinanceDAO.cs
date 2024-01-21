using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Model;

namespace InMemory.DAO
{
    public class FinanceDAO
    {
        List<Finance> finances = new List<Finance>();

        private static FinanceDAO unica;
        public static FinanceDAO GetFinanceDAO()
        {
            if (unica == null)
            {
                unica = new FinanceDAO();
            }
            return unica;
        }


        public void CreateFinance(Finance finance)
        {
            finances.Add(finance);
        }

        public void UpdateFinance(Finance finance)
        {
            for (int i = 0; i < finances.Count; i++)
            {
                if (finances[i].FinanceId == finance.FinanceId)
                {
                    finances[i] = finance;
                }
            }
        }

        public void DeleteFinance(int id)
        {
            for (int i = 0; i < finances.Count; i++)
            {
                if (finances[i].FinanceId == id)
                {
                    finances.Remove(finances[i]);
                }
            }
        }

        public List<Finance> ListFinance()
        {
            return finances;
        }


    }
}