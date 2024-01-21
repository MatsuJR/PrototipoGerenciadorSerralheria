using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Controller;
using InMemory.DAO;
using InMemory.Model;

namespace InMemory.View
{
    public class ServiceView
    {
        public int inputIdService;
        public string? inputServiceDescription;
        public string? inputSpentMaterial;
        public string? inputStartDate;
        public string? inputFinalDate;
        public double inputGrossProfit;
        public double inputNetProfit;
        public double inputTotalBudget;
        public int inputIdClient;

        List<Service> services = new List<Service>();
        ServiceController controller = new ServiceController();


        public void OpcaoServico()
        {
            int op;
            do
            {

                System.Console.WriteLine("escolha um opcao:");
                System.Console.WriteLine("0- sair");
                System.Console.WriteLine("1- criar");
                System.Console.WriteLine("2- excluir");
                System.Console.WriteLine("3- alterar");
                System.Console.WriteLine("4- listar");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        DadosCriarServico();
                        controller.CreateService(inputIdService, inputServiceDescription, inputSpentMaterial, inputStartDate, inputFinalDate, inputGrossProfit, inputNetProfit, inputTotalBudget, inputIdClient);
                        break;
                    case 2:
                        DadosDeletarServico();
                        controller.DeleteService(inputIdService);
                        break;
                    case 3:
                        DadosAlterarServico();
                        controller.UpdateService(inputIdService, inputServiceDescription, inputSpentMaterial, inputStartDate, inputFinalDate, inputGrossProfit, inputNetProfit, inputTotalBudget, inputIdClient);
                        break;
                    case 4:
                        services = controller.ListServices();
                        foreach (Service service in services)
                        {
                            System.Console.WriteLine("id do serviço: " + service.IdService);
                            System.Console.WriteLine("descricao do serviço: " + service.ServiceDescription);
                            System.Console.WriteLine("materiais gastos: " + service.SpentMaterial);
                            System.Console.WriteLine("data de inicio: " + service.StartDate);
                            System.Console.WriteLine("data de conclusão: " + service.FinalDate);
                            System.Console.WriteLine("lucro bruto: " + service.GrossProfit);
                            System.Console.WriteLine("lucro líquido: " + service.NetProfit);
                            System.Console.WriteLine("total recebido: " + service.TotalBudget);
                            System.Console.WriteLine("id do cliente: " + service.IdClient);

                        }
                        break;

                    default: Console.WriteLine("Opcao incorreta"); OpcaoServico(); break;
                }
            } while (op != 0);
            Program.Menu();

        }


        public void DadosCriarServico()
        {
            System.Console.WriteLine("digite o id do serviço: ");
            inputIdService = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a descricao do serviço");
            inputServiceDescription = Console.ReadLine();
            System.Console.WriteLine("digite os materiais gastos");
            inputSpentMaterial = Console.ReadLine();
            System.Console.WriteLine("digite a data de inicio");
            inputStartDate = Console.ReadLine();
            System.Console.WriteLine("digite a data de conclusão");
            inputFinalDate = Console.ReadLine();
            System.Console.WriteLine("digite o lucro bruto");
            inputGrossProfit = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o lucro líquido");
            inputNetProfit = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o total recebido");
            inputTotalBudget = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite id do cliente");
            inputIdClient = int.Parse(Console.ReadLine());
        }

        public void DadosDeletarServico()
        {
            System.Console.WriteLine("digite o id do serviço que quer deletar: ");
            inputIdService = int.Parse(Console.ReadLine());
        }
        public void DadosAlterarServico()
        {
            System.Console.WriteLine("digite o id do serviço que vai ser alterado: ");
            inputIdService = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a nova descricao do serviço");
            inputServiceDescription = Console.ReadLine();
            System.Console.WriteLine("digite os novos  materiais gastos");
            inputSpentMaterial = Console.ReadLine();
            System.Console.WriteLine("digite a nova data de inicio");
            inputStartDate = Console.ReadLine();
            System.Console.WriteLine("digite a nova data de conclusão");
            inputFinalDate = Console.ReadLine();
            System.Console.WriteLine("digite o novo lucro bruto");
            inputGrossProfit = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o novo lucro líquido");
            inputNetProfit = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o novo total recebido");
            inputTotalBudget = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o id do novo  do cliente");
            inputIdClient = int.Parse(Console.ReadLine());
        }

    }
}