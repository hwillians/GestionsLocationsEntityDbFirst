using Models;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface ILocationRepository
    {
        LOUE CreateLocation(LOUE location);
        List<LOUE> GetListLocations();
    }
}
