using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using InMemory.View;

namespace InMemory
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            int op;

            do
            {
                System.Console.WriteLine("escolha um opcao:");
                System.Console.WriteLine("0- sair");
                System.Console.WriteLine("1- usuario");
                System.Console.WriteLine("2- cliente");
                System.Console.WriteLine("3- material");
                System.Console.WriteLine("4- serviço");
                System.Console.WriteLine("5- finança");
                System.Console.WriteLine("6- calculadora");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {


                    case 0: break;
                    case 1:
                        var userView = new UserView();
                        userView.OpcaoUsuario(); break;
                    case 2:
                        var clientView = new ClientView();
                        clientView.OpcaoCliente(); break;
                    case 3:
                        var materialView = new MaterialView();
                        materialView.OpcaoMaterial(); break;
                    case 4:
                        var serviceView = new ServiceView();
                        serviceView.OpcaoServico(); break;
                    case 5:
                        var financeView = new FinanceView();
                        financeView.OpcaoFinanca(); break;
                    case 6:
                        var calculadoraView = new CalculadoraView();
                        calculadoraView.MenuCalculadora();
                        break;
                    default: Console.WriteLine("Opcao incorreta"); break;
                }
            } while (op != 0);




        }


    }
}