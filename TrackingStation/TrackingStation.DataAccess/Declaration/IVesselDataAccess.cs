using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Contract;
using TrackingStation.Domain.Model;

namespace TrackingStation.DataAccess.Declaration
{
    public interface IVesselDataAccess
    {
        public Task<Vessel> InsertAsync(VesselModel vessel);

        public Task ValidateBody(VesselModel vessel);

        public Task<IEnumerable<Vessel>> GetAsync();

        public Task<Vessel> GetAsync(IVesselIdentity vesselId);

        public Task<Vessel> UpdateAsync(VesselModel vessel);

        public Task<Vessel> DeleteAsync(IVesselIdentity vesselId);
    }
}
