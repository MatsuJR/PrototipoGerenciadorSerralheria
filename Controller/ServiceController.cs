using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Model;
using InMemory.DAO;

namespace InMemory.Controller
{
    public class ServiceController
    {
        private ServiceDAO serviceDAO = ServiceDAO.GetServiceDAO();


        public void CreateService(int idService, string serviceDescription, string spentMaterial, string startDate, string finalDate, double grossProfit, double netProfit, double totalBudget, int idClient)
        {
            if (idService == null || serviceDescription == null || idClient == null)
            {
                System.Console.WriteLine("nao pode ser vazio");
            }
            else
            {
                var service = new Service(idService, serviceDescription, spentMaterial, startDate, finalDate, grossProfit, netProfit, totalBudget, idClient);
                System.Console.WriteLine("id do serviço: " + idService);
                System.Console.WriteLine("descricao do serviço: " + serviceDescription);
                System.Console.WriteLine("materiais gastos: " + spentMaterial);
                System.Console.WriteLine("data de inicio: " + startDate);
                System.Console.WriteLine("data de conclusão: " + finalDate);
                System.Console.WriteLine("lucro bruto: " + grossProfit);
                System.Console.WriteLine("lucro líquido: " + netProfit);
                System.Console.WriteLine("total recebido: " + totalBudget);
                System.Console.WriteLine("id do cliente: " + idClient);


            }
        }

        public void DeleteService(int id)
        {
            if (id == null)
            {
                System.Console.WriteLine("nao pode ser vazio");

            }
            else
            {
                serviceDAO.DeleteService(id);
            }
        }

        public void UpdateService(int idService, string serviceDescription, string spentMaterial, string startDate, string finalDate, double grossProfit, double netProfit, double totalBudget, int idClient)
        {
            if (idService == null || serviceDescription == null || idClient == null)
            {
                var service = new Service(idService, serviceDescription, spentMaterial, startDate, finalDate, grossProfit, netProfit, totalBudget, idClient);
                serviceDAO.UpdateService(service);
                System.Console.WriteLine("id do serviço: " + idService);
                System.Console.WriteLine("descricao do serviço: " + serviceDescription);
                System.Console.WriteLine("materiais gastos: " + spentMaterial);
                System.Console.WriteLine("data de inicio: " + startDate);
                System.Console.WriteLine("data de conclusão: " + finalDate);
                System.Console.WriteLine("lucro bruto: " + grossProfit);
                System.Console.WriteLine("lucro líquido: " + netProfit);
                System.Console.WriteLine("total recebido: " + totalBudget);
                System.Console.WriteLine("id do cliente: " + idClient);

            }
        }

        public List<Service> ListServices()
        {
            return serviceDAO.ListServices();
        }


    }
}