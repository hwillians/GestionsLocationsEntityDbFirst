using Models;
using Repository.Contracts;
using System.Collections.Generic;

namespace Repository
{
    public class LocationRepository : ILocationRepository
    {
        static LocationEntities context = new LocationEntities();
        public LOUE CreateLocation(LOUE location)
        {
            context.LOUE.Add(location);
            context.SaveChanges();
            return location;
        }

        public List<LOUE> GetListLocations()
        {
            var locations = new List<LOUE>(context.LOUE);

            return locations;
        }
    }
}
