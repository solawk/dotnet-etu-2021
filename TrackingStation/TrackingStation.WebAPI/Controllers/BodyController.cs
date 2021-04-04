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
    [Route("api/bodies")]
    public class BodyController : ControllerBase
    {
        public ILogger<BodyController> Logger { get; }
        public IMapper Mapper { get; }
        public IBodyServant BodyBL { get; }

        public BodyController(ILogger<BodyController> logger, IMapper mapper, IBodyServant bodyBL)
        {
            Logger = logger;
            Mapper = mapper;
            BodyBL = bodyBL;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Domain.Body>> GetAll()
        {
            Logger.LogTrace("Get all invoked");

            IEnumerable<Domain.Body> Bodies = await BodyBL.Read();

            return Bodies;
        }

        [HttpGet]
        [Route("{bodyName}")]
        public async Task<Domain.Body> GetSpecific(string bodyName)
        {
            Logger.LogTrace($"Get {bodyName} invoked");

            Domain.Body Body = await BodyBL.Read(new BodyModel { BodyName = bodyName });

            return Body;
        }

        [HttpPut]
        [Route("")]
        public async Task<Domain.Body> Put(BodyModel putBody)
        {
            Logger.LogTrace($"Put {putBody.BodyName} invoked");

            Domain.Body Body = await BodyBL.Create(putBody);

            return Body;
        }

        [HttpPatch]
        [Route("")]
        public async Task<Domain.Body> Patch(BodyModel putBody)
        {
            Logger.LogTrace($"Patch {putBody.BodyName} invoked");

            Domain.Body Body = await BodyBL.Update(putBody);

            return Body;
        }

        [HttpDelete]
        [Route("{bodyName}")]
        public async Task<Domain.Body> Delete(string bodyName)
        {
            Logger.LogTrace($"Delete {bodyName} invoked");

            Domain.Body Body = await BodyBL.Delete(new BodyModel { BodyName = bodyName });

            return Body;
        }
    }

}
