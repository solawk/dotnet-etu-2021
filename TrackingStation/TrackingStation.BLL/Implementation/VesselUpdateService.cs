using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Model;
using TrackingStation.BLL.Declaration;
using TrackingStation.DataAccess.Declaration;

namespace TrackingStation.BLL.Implementation
{
    class VesselUpdateService : IVesselUpdateService
    {
        private IVesselDataAccess VesselDataAccess { get; }
        private IBodyGetService BodyGetService { get; }

        public VesselUpdateService(IVesselDataAccess vesselDataAccess, IBodyGetService bodyGetService)
        {
            VesselDataAccess = vesselDataAccess;
            BodyGetService = bodyGetService;
        }

        public async Task<Vessel> UpdateAsync(VesselUpdateModel vessel)
        {
            await BodyGetService.ValidateAsync(vessel);

            return await VesselDataAccess.UpdateAsync(vessel);
        }
    }
}
