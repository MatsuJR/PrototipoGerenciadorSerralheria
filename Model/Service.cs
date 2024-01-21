using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemory.Model
{
    public class Service
    {
        public int IdService { get; set; }
        public string? ServiceDescription { get; set; }
        public string? SpentMaterial { get; set; }
        public string? StartDate { get; set; }
        public string? FinalDate { get; set; }
        public double GrossProfit { get; set; }
        public double NetProfit { get; set; }
        public double TotalBudget { get; set; }
        public int IdClient { get; set; }

        static int cont = 0;

        public Service(int idService, string serviceDescription, string spentMaterial, string startDate, string finalDate, double grossProfit, double netProfit, double totalBudget, int idClient)
        {
            IdService = idService;
            ServiceDescription = serviceDescription;
            SpentMaterial = spentMaterial;
            StartDate = startDate;
            FinalDate = finalDate;
            GrossProfit = grossProfit;
            NetProfit = netProfit;
            TotalBudget = totalBudget;
            IdClient = idClient;

        }
    }


}