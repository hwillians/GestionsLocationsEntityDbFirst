using Models;
using Repository.Contracts;
using System.Collections.Generic;

namespace Repository
{
    public class ClientRepository : IClientRepository
    {
        private static LocationEntities context = new LocationEntities();

        public CLIENT CreateClient(CLIENT client)
        {
            context.CLIENT.Add(client);
            context.SaveChanges();
            return client;
        }

        public CLIENT GetClientById(int id)=> context.CLIENT.Find(id);

        public List<CLIENT> GetClients()=> new List<CLIENT>(context.CLIENT);
        
        public void UpdateClient(CLIENT client)
        {
            CLIENT clt = context.CLIENT.Find(client.ID);
            
            clt.NOM = client.NOM;
            clt.PRENOM = client.PRENOM;
            clt.DATE_NAISSANCE = client.DATE_NAISSANCE;
            clt.ADRESSE = client.ADRESSE;
            clt.CODE_POSTAL = client.CODE_POSTAL;
            clt.VILLE = client.VILLE;

            context.SaveChanges();


        }
    }
}
