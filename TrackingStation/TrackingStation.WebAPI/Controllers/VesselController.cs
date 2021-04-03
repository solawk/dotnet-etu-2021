using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingStation.BLL.Declaration;
using TrackingStation.Domain.Contract;
using TrackingStation.Domain.Model;

namespace TrackingStation.WebAPI.Controllers
{
    [ApiController]
    [Route("api/vessels")]
    public class VesselController : ControllerBase
    {
        public ILogger<VesselController> Logger { get; }
        public IMapper Mapper { get; }
        public IVesselServant VesselBL { get; }

        public VesselController(ILogger<VesselController> logger, IMapper mapper, IVesselServant vesselBL)
        {
            Logger = logger;
            Mapper = mapper;
            VesselBL = vesselBL;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Domain.Vessel>> GetAll()
        {
            Logger.LogTrace("Get all invoked");

            IEnumerable<Domain.Vessel> Vessels = await VesselBL.Read();

            return Vessels;
        }

        [HttpGet]
        [Route("{vesselName}")]
        public async Task<Domain.Vessel> GetSpecific(string vesselName)
        {
            Logger.LogTrace($"Get {vesselName} invoked");

            Domain.Vessel Vessel = await VesselBL.Read(new VesselModel { Name = vesselName });

            return Vessel;
        }

        [HttpPut]
        [Route("")]
        public async Task<Domain.Vessel> Put(VesselModel putVessel)
        {
            Logger.LogTrace($"Put {putVessel.Name} invoked");

            Domain.Vessel Vessel = await VesselBL.Create(putVessel);

            return Vessel;
        }

        [HttpPatch]
        [Route("")]
        public async Task<Domain.Vessel> Patch(VesselModel vessel)
        {
            Logger.LogTrace($"Patch {vessel.Name} invoked");

            Domain.Vessel Vessel = await VesselBL.Update(vessel);

            return Vessel;
        }

        [HttpDelete]
        [Route("{vesselName}")]
        public async Task<Domain.Vessel> Delete(string vesselName)
        {
            Logger.LogTrace($"Delete {vesselName} invoked");

            Domain.Vessel Vessel = await VesselBL.Delete(new VesselModel { Name = vesselName });

            return Vessel;
        }
    }

}
