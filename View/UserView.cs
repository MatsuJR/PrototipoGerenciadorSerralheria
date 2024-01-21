using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Controller;
using Microsoft.VisualBasic;
using InMemory.Model;
using System.Linq.Expressions;

namespace InMemory.View
{
    public class UserView
    {
        public int inputIdUser;
        public string? inputNameUser;
        public string? inputLoginUser;
        public string? inputPasswordUser;

        public string? nomeDePesquisa;

        private List<User> users = new List<User>();
        UserController controller = new UserController();


        public void OpcaoUsuario()
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
                        DadosCriarUsuario();
                        controller.CreateUser(inputIdUser, inputNameUser, inputLoginUser, inputPasswordUser);
                        break;
                    case 2:
                        DadosExcluirUsuario();
                        controller.DeleteUser(inputIdUser);
                        break;

                    case 3:
                        DadosAlterarUsuario();
                        controller.UpdateUser(inputIdUser, inputNameUser, inputLoginUser, inputPasswordUser);
                        break;
                    case 4:
                        users = controller.ListUsers();
                        foreach (User user in users)
                        {
                            System.Console.WriteLine("id do usuario: " + user.IdUser);
                            System.Console.WriteLine("usuario: " + user.NameUser);
                            System.Console.WriteLine("login: " + user.LoginUser);
                            System.Console.WriteLine("password: " + user.PasswordUser);
                        }
                        break;

                    default: Console.WriteLine("Opcao incorreta"); OpcaoUsuario(); break;
                }
            } while (op != 0);
            Program.Menu();

        }

        public void DadosAlterarUsuario()
        {
            System.Console.WriteLine("digite o id do usuario que quer mudar:");
            inputIdUser = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o novo nome do usuario");
            inputNameUser = Console.ReadLine();
            System.Console.WriteLine("digite o novo login do usuario");
            inputLoginUser = Console.ReadLine();
            System.Console.WriteLine("digite a nova senha do usuario");
            inputPasswordUser = Console.ReadLine();
        }
        public void DadosCriarUsuario()
        {
            System.Console.WriteLine("digite o id do usuario");
            inputIdUser = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o nome do usuario");
            inputNameUser = Console.ReadLine();
            System.Console.WriteLine("digite o login do usuario");
            inputLoginUser = Console.ReadLine();
            System.Console.WriteLine("digite a senha do usuario");
            inputPasswordUser = Console.ReadLine();
        }
        public void DadosExcluirUsuario()
        {
            System.Console.WriteLine("digite o id do usuario que quer excluir:");
            inputIdUser = int.Parse(Console.ReadLine());

        }


    }
}
