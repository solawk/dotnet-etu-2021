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
    public class VesselCreateService : IVesselCreateService
    {
        private IVesselDataAccess VesselDataAccess { get; }
        private IBodyGetService BodyGetService { get; }

        public VesselCreateService(IVesselDataAccess vesselDataAccess, IBodyGetService bodyGetService)
        {
            VesselDataAccess = vesselDataAccess;
            BodyGetService = bodyGetService;
        }

        public async Task<Vessel> CreateAsync(VesselUpdateModel vessel)
        {
            await BodyGetService.ValidateAsync(vessel);

            return await VesselDataAccess.InsertAsync(vessel);
        }
    }
}
