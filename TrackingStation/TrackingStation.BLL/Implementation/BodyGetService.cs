using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Model;
using TrackingStation.BLL.Declaration;
using TrackingStation.DataAccess.Declaration;
using TrackingStation.Domain.Contract;

namespace TrackingStation.BLL.Implementation
{
    public class BodyGetService : IBodyGetService
    {
        private IBodyDataAccess BodyDataAccess { get; }

        public BodyGetService(IBodyDataAccess bodyDataAccess)
        {
            BodyDataAccess = bodyDataAccess;
        }

        public async Task ValidateAsync(IBodyContainer bodyContainer)
        {
            if (bodyContainer == null)
            {
                throw new ArgumentNullException("Body Container is null");
            }

            Body body = await Get(bodyContainer);

            if (bodyContainer.BodyName != null && body == null)
            {
                throw new InvalidOperationException("No body with name " + bodyContainer.BodyName);
            }
        }

        private async Task<Body> Get(IBodyContainer bodyContainer)
        {
            return await BodyDataAccess.GetAsync(bodyContainer);
        }
    }
}
