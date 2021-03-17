using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Model;

namespace TrackingStation.DataAccess.Declaration
{
    public interface IVesselDataAccess
    {
        public Task<Vessel> InsertAsync(VesselUpdateModel vessel);
    }
}
