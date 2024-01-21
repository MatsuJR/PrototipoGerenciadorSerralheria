using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemory.Model
{
    public class Client
    {
        public int IdClient { get; set; }
        public string? NameClient { get; set; }
        public string? PhoneClient { get; set; }

        static int cont = 0;

        public Client(int idClient, string nameClient, string phoneClient)
        {
            IdClient = idClient;
            NameClient = nameClient;
            PhoneClient = phoneClient;
        }
    }
}