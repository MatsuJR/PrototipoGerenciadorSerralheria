using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using InMemory.Model;

namespace InMemory.DAO
{
    public class UserDAO
    {
        private List<User> users = new List<User>();

        //cria uma variavel do tipo da classe
        private static UserDAO unica;
        //quando alguma coisa precisar usar algum metodo da classe DAO
        //ela instancia a classe e chama o metodo Get(nome da classe)DAO()
        //private UserDAO userDAO = UserDAO.GetUserDAO();
        //se o metodo nunca foi chamado ele cria uma nova instancia que
        //nao tera valores armazenados (unica = new UserDAO), se já foi chamado
        //unica nao será null pois usamos os metodos para fazer as operacoes crud,
        //entao se instanciassemos a propria classe novamente ela perderias o que 
        //está armazenado na memoria, entao se nao for null ela retorna a variavel
        //que está com os dados armazenados
        public static UserDAO GetUserDAO()
        {
            if (unica == null)
            {
                unica = new UserDAO();
            }
            return unica;
        }

        public void CreateUserDAO(User user)
        {
            users.Add(user);
            System.Console.WriteLine(users.Count + " users created");

        }

        public void DeleteUser(int id)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].IdUser == id)
                {
                    users.Remove(users[i]);
                }
            }

        }


        public void UpdateUser(User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].IdUser == user.IdUser)
                {
                    users[i] = user;
                }
            }

        }

        public List<User> ListarUsers()
        {
            return users;
        }


    }
}
