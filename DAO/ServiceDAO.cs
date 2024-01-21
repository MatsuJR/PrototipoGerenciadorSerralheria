using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Model;

namespace InMemory.DAO
{
    public class ServiceDAO
    {
        private List<Service> services = new List<Service>();

        private static ServiceDAO unica;
        public static ServiceDAO GetServiceDAO()
        {
            if (unica == null)
            {
                unica = new ServiceDAO();
            }
            return unica;
        }

        public void CreateService(Service service)
        {
            services.Add(service);
        }

        public void DeleteService(int id)
        {
            for (int i = 0; i < services.Count; i++)
            {
                if (services[i].IdService == id)
                {
                    services.Remove(services[i]);
                }
            }
        }

        public void UpdateService(Service service)
        {
            for (int i = 0; i < services.Count; i++)
            {
                if (services[i].IdService == service.IdService)
                {
                    services[i] = service;
                }
            }
        }

        public List<Service> ListServices()
        {
            return services;
        }


    }
}