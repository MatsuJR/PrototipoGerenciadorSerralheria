using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using InMemory.DAO;
using InMemory.Model;

namespace InMemory.Controller
{
    public class UserController
    {
        private UserDAO userDAO = UserDAO.GetUserDAO();


        public void CreateUser(int idUser, string username, string login, string password)
        {
            if (idUser == null || username == null || login == null || password == null)
            {
                System.Console.WriteLine("nao pode ser vazio");
            }
            else
            {

                var user = new User(idUser, username, login, password);// cria um user com atributos da UserModel
                                                                       //verificar existencia do usuario
                userDAO.CreateUserDAO(user);
                System.Console.WriteLine("id do usuario: " + user.IdUser);
                System.Console.WriteLine("usuario: " + user.NameUser);
                System.Console.WriteLine("login: " + user.LoginUser);
                System.Console.WriteLine("password: " + user.PasswordUser);
            }
        }

        public void DeleteUser(int id)
        {
            if (id == null)
            {
                System.Console.WriteLine("nao pode ser vazio");

            }
            else
            {
                userDAO.DeleteUser(id);
            }
        }



        public void UpdateUser(int id, string usernameNovo, string loginNovo, string passwordNovo)
        {
            if (id == null || usernameNovo == null || loginNovo == null || passwordNovo == null)
            {
                System.Console.WriteLine("nao pode ser vazio");
            }
            else
            {

                var user = new User(id, usernameNovo, loginNovo, passwordNovo);// cria um user com atributos da UserModel
                                                                               //verificar existencia do usuario
                userDAO.UpdateUser(user);
                System.Console.WriteLine("id do usuario: " + user.IdUser);
                System.Console.WriteLine("usuario: " + user.NameUser);
                System.Console.WriteLine("login: " + user.LoginUser);
                System.Console.WriteLine("password: " + user.PasswordUser);

            }
        }

        public List<User> ListUsers()
        {
            return userDAO.ListarUsers();
        }











    }

}