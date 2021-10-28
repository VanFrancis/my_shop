using System.Collections.Generic;
using clients.model;
using Microsoft.AspNetCore.Mvc;
using clients.data;

namespace clients.controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase 
    {
        private readonly MockClientRepo _repository = new MockClientRepo();

        //GET api/clients
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAllClients()
        {
            var clients = _repository.GetAllClients();
            return Ok(clients);
        }

        //GET api/clients/{id}
        [HttpGet("{id}")]
        public ActionResult <Client> GetClientById(int id_client)
        {
            var client_by_id = _repository.GetClientById(id_client);
            return Ok(client_by_id);
        }
    }
}