using System.Collections.Generic;
using clients.model;

namespace clients.data 
{
    public class MockClientRepo : IClientRepo
    {
        public IEnumerable<Client> GetAllClients()
        {
            var clients = new List<Client>
            {
                new Client {id_client= 1, name= "caio"},
                new Client {id_client= 2, name= "beatriz"}
            };

            return clients;
        }

        public Client GetClientById(int id_client)
        {
            return new Client {id_client= 54, name = "Judas"};
        }
    }
}