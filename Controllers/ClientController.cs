using Models;
using Repository.Contracts;
using System.Collections.Generic;

namespace Controllers
{
    public class ClientController
    {
        private IClientRepository ClientRepo { get; }
        public ClientController(IClientRepository clientRepo)
        {
            ClientRepo = clientRepo;
        }

        public CLIENT CreateClient(CLIENT client) => ClientRepo.CreateClient(client);

        public List<CLIENT> GetClients() => ClientRepo.GetClients();

        public CLIENT GetClientById(int id) => ClientRepo.GetClientById(id);

        public void UpdateClient(CLIENT client) => ClientRepo.UpdateClient(client);
    }
}
