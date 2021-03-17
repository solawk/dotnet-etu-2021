using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.BLL.Declaration;
using TrackingStation.Domain;
using TrackingStation.Domain.Model;

namespace TrackingStation.BLL.Implementation
{
    class VesselUpdateService : IVesselUpdateService
    {
        public Task<Vessel> UpdateAsync(VesselUpdateModel vessel)
        {
            return null;
        }
    }
}
