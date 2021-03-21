using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Model;
using TrackingStation.BLL.Declaration;
using TrackingStation.DataAccess.Declaration;
using TrackingStation.Domain.Contract;

namespace TrackingStation.BLL.Implementation
{
    class VesselGetService : IVesselGetService
    {
        private IVesselDataAccess VesselDataAccess { get; }

        public VesselGetService(IVesselDataAccess vesselDataAccess)
        {
            VesselDataAccess = vesselDataAccess;
        }

        public Task<IEnumerable<Vessel>> GetAsync()
        {
            return VesselDataAccess.GetAsync();
        }

        public Task<Vessel> GetAsync(IVesselIdentity vessel)
        {
            return VesselDataAccess.GetAsync(vessel);
        }
    }
}
