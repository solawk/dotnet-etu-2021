using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingStation.WebClient.Models;

namespace TrackingStation.WebClient.Services
{
    public interface IBodyClientServant
    {
        Task<IEnumerable<BodyModel>> GetAllBodies();
    }
}
