using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Controller;
using InMemory.Model;


namespace InMemory.View
{
    public class ClientView
    {
        public int inputIdClient;
        public string? inputNameClient;
        public string? inputPhoneClient;

        List<Client> clients = new List<Client>();

        ClientController controller = new ClientController();

        public void OpcaoCliente()
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
                        DadosCriarCliente();
                        controller.CreateClient(inputIdClient, inputNameClient, inputPhoneClient);
                        break;
                    case 2:
                        DadosExcluirCliente();
                        controller.DeleteClient(inputIdClient);
                        break;
                    case 3:
                        DadosAlterarCliente();
                        controller.UpdateClient(inputIdClient, inputNameClient, inputPhoneClient);
                        break;
                    case 4:
                        clients = controller.ListClients();
                        foreach (Client client in clients)
                        {
                            System.Console.WriteLine("id do cliente: " + client.IdClient);
                            System.Console.WriteLine("cliente: " + client.NameClient);
                            System.Console.WriteLine("numero de telefone: " + client.PhoneClient);
                        }
                        break;
                    default: Console.WriteLine("Opcao incorreta"); OpcaoCliente(); break;
                }
            } while (op != 0);
            Program.Menu();
        }



        public void DadosAlterarCliente()
        {
            System.Console.WriteLine("digite o id do cliente que quer mudar:");
            inputIdClient = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o novo nome do cliente");
            inputNameClient = Console.ReadLine();
            System.Console.WriteLine("digite o novo telefone do cliente");
            inputPhoneClient = Console.ReadLine();
        }
        public void DadosCriarCliente()
        {
            System.Console.WriteLine("digite o id do cliente :");
            inputIdClient = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite nome do cliente");
            inputNameClient = Console.ReadLine();
            System.Console.WriteLine("digite telefone do cliente");
            inputPhoneClient = Console.ReadLine();
        }
        public void DadosExcluirCliente()
        {
            System.Console.WriteLine("digite o id do cliente que quer excluir:");
            inputIdClient = int.Parse(Console.ReadLine());

        }



    }
}