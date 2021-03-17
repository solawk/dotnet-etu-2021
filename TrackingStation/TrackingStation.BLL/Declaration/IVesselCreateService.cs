using System;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Model;

namespace TrackingStation.BLL.Declaration
{
    public interface IVesselCreateService
    {
        public Task<Vessel> CreateAsync(VesselUpdateModel vessel);
    }
}
