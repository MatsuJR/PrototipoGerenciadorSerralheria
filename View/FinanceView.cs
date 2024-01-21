using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using InMemory.Controller;
using InMemory.Model;

namespace InMemory.View
{
    public class FinanceView
    {
        public int inputFinanceId;
        public double inputValue;
        public string? inputFinanceDescription;

        List<Service> services = new List<Service>();
        ServiceController controllerService = new ServiceController();
        List<Finance> finances = new List<Finance>();
        FinanceController controller = new FinanceController();


        public void OpcaoFinanca()
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
                        DadosCriarFinanca();
                        controller.CreateFinance(inputFinanceId, inputValue, inputFinanceDescription);
                        break;
                    case 2:
                        DadosExcluirFinanca();
                        controller.DeleteFinance(inputFinanceId);
                        break;
                    case 3:
                        DadosAlterarFinanca();
                        controller.UpdateFinance(inputFinanceId, inputValue, inputFinanceDescription);
                        break;
                    case 4:
                        finances = controller.ListFinance();
                        foreach (Finance finance in finances)
                        {
                            System.Console.WriteLine("id da financa: " + finance.FinanceId);
                            System.Console.WriteLine("valor da financa: " + finance.Value);
                            System.Console.WriteLine("descricao da financa: " + finance.FinanceDescription);
                        }
                        services = controllerService.ListServices();
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
                    default: Console.WriteLine("Opcao incorreta"); OpcaoFinanca(); break;
                }
            } while (op != 0);
            Program.Menu();

        }

        public void DadosCriarFinanca()
        {
            System.Console.WriteLine("digite o id da financa");
            inputFinanceId = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o valor (negativo se foi compra)");
            inputValue = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a descrição da compra ou do pagamento recebido");
            inputFinanceDescription = Console.ReadLine();
        }

        public void DadosAlterarFinanca()
        {
            System.Console.WriteLine("digite o id da financa que quer mudar: ");
            inputFinanceId = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o novo valor (negativo se foi compra)");
            inputValue = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a nova descrição da compra ou do pagamento recebido");
            inputFinanceDescription = Console.ReadLine();
        }

        public void DadosExcluirFinanca()
        {
            System.Console.WriteLine("digite o id da financa que quer excluir: ");
            inputFinanceId = int.Parse(Console.ReadLine());
        }


    }
}