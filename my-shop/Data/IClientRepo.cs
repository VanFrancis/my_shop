using System.Collections.Generic;
using clients.model;

namespace clients.data
{
    public interface IClientRepo
    {
        IEnumerable<Client> GetAllClients();
        Client GetClientById(int id_client);
    }
}