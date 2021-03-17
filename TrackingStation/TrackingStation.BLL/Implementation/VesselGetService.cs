using System;
using System.Threading.Tasks;
using TrackingStation.Domain.Contract;
using TrackingStation.Domain;
using TrackingStation.BLL.Declaration;

namespace TrackingStation.BLL.Implementation
{
    class VesselGetService : IVesselGetService
    {
        public Task<Vessel> GetAsync(IVesselIdentity vessel)
        {
            return null;
        }
    }
}
