using System;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Contract;

namespace TrackingStation.BLL.Declaration
{
    public interface IVesselGetService
    {
        public Task<Vessel> GetAsync(IVesselIdentity vessel);
    }
}
