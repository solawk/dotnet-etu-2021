using System;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Model;

namespace TrackingStation.BLL.Declaration
{
    public interface IVesselUpdateService
    {
        public Task<Vessel> UpdateAsync(VesselUpdateModel vessel);
    }
}
