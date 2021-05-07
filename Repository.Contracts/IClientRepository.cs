using Models;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IClientRepository
    {
        CLIENT CreateClient(CLIENT client);
        CLIENT GetClientById(int id);
        void UpdateClient(CLIENT client);
        List<CLIENT> GetClients();
    }
}
