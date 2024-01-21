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


        private static UserDAO unica;
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
