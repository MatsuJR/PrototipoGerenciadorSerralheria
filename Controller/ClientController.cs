using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Model;
using InMemory.DAO;

namespace InMemory.Controller
{
    public class ClientController
    {
        private ClientDAO clientDAO = ClientDAO.GetClientDAO();


        public void CreateClient(int idClient, string clientname, string phoneClient)
        {
            if (idClient == null || clientname == null || phoneClient == null)
            {
                System.Console.WriteLine("nao pode ser vazio");
            }
            else
            {

                var client = new Client(idClient, clientname, phoneClient);// cria um client com atributos da ClientModel
                                                                           //verificar existencia do cliente
                clientDAO.CreateClientDAO(client);
                System.Console.WriteLine("id do cliente: " + client.IdClient);
                System.Console.WriteLine("cliente: " + client.NameClient);
                System.Console.WriteLine("numero de telefone: " + client.PhoneClient);
            }
        }

        public void DeleteClient(int id)
        {
            if (id == null)
            {
                System.Console.WriteLine("nao pode ser vazio");

            }
            else
            {
                clientDAO.DeleteClient(id);
            }
        }



        public void UpdateClient(int id, string clientnameNovo, string phoneClientNovo)
        {
            if (id == null || clientnameNovo == null || phoneClientNovo == null)
            {
                System.Console.WriteLine("nao pode ser vazio");
            }
            else
            {

                var client = new Client(id, clientnameNovo, phoneClientNovo);// cria um client com atributos da ClientModel
                                                                             //verificar existencia do cliente
                clientDAO.UpdateClient(client);
                System.Console.WriteLine("id do cliente: " + client.IdClient);
                System.Console.WriteLine("cliente: " + client.NameClient);
                System.Console.WriteLine("numero de telefone: " + client.PhoneClient);

            }
        }

        public List<Client> ListClients()
        {
            return clientDAO.ListarClients();
        }
    }
}