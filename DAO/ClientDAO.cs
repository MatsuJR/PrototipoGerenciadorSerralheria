using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Model;

namespace InMemory.DAO
{
    public class ClientDAO
    {
        private List<Client> clients = new List<Client>();


        private static ClientDAO unica;
        public static ClientDAO GetClientDAO()
        {
            if (unica == null)
            {
                unica = new ClientDAO();
            }
            return unica;
        }

        public void CreateClientDAO(Client client)
        {
            clients.Add(client);
            System.Console.WriteLine(clients.Count + " clients created");

        }

        public void DeleteClient(int id)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].IdClient == id)
                {
                    clients.Remove(clients[i]);
                }
            }

        }


        public void UpdateClient(Client client)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].IdClient == client.IdClient)
                {
                    clients[i] = client;
                }
            }

        }

        public List<Client> ListarClients()
        {
            return clients;
        }
    }
}