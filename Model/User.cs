using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemory.Model
{
    public class User
    {
        public int IdUser { get; set; }
        public string? NameUser { get; set; }
        public string? LoginUser { get; set; }
        public string? PasswordUser { get; set; }



        public User(int idUser, string nameUser, string loginUser, string passwordUser)
        {

            IdUser = idUser;
            NameUser = nameUser;
            LoginUser = loginUser;
            PasswordUser = passwordUser;
        }


    }
}