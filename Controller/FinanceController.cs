using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.DAO;
using InMemory.Model;

namespace InMemory.Controller
{
    public class FinanceController
    {
        FinanceDAO financeDAO = FinanceDAO.GetFinanceDAO();

        public void CreateFinance(int financeId, double value, string financeDescription)
        {
            if (financeId == null || value == null || financeDescription == null)
            {
                System.Console.WriteLine("nao pode ser vazio");

            }
            else
            {
                var finance = new Finance(financeId, value, financeDescription);
                financeDAO.CreateFinance(finance);
                System.Console.WriteLine("id da financa: " + financeId);
                System.Console.WriteLine("valor da financa: " + value);
                System.Console.WriteLine("descricao da financa: " + financeDescription);
            }
        }

        public void UpdateFinance(int financeId, double value, string financeDescription)
        {
            if (financeId == null || value == null || financeDescription == null)
            {
                System.Console.WriteLine("nao pode ser vazio");

            }
            else
            {
                var finance = new Finance(financeId, value, financeDescription);
                financeDAO.UpdateFinance(finance);
                System.Console.WriteLine("id da financa: " + financeId);
                System.Console.WriteLine("valor da financa: " + value);
                System.Console.WriteLine("descricao da financa: " + financeDescription);
            }

        }


        public void DeleteFinance(int id)
        {
            if (id == null)
            {
                System.Console.WriteLine("nao pode ser vazio");
            }
            else
            {
                financeDAO.DeleteFinance(id);
            }
        }

        public List<Finance> ListFinance()
        {
            return financeDAO.ListFinance();
        }



    }
}