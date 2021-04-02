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
    public class BodyServant : IBodyServant
    {
        private IBodyDataAccess BodyDataAccess { get; }

        public BodyServant(IBodyDataAccess bodyDataAccess)
        {
            BodyDataAccess = bodyDataAccess;
        }

        public async Task Validate(IBodyContainer bodyContainer)
        {
            if (bodyContainer == null)
            {
                throw new ArgumentNullException("Body Container is null");
            }

            Body body = await Read(bodyContainer);

            if (bodyContainer.BodyName != null && body == null)
            {
                throw new InvalidOperationException("No body with name " + bodyContainer.BodyName);
            }
        }

        public Task<Body> Create(BodyModel body)
        {
            return BodyDataAccess.InsertAsync(body);
        }

        public Task<IEnumerable<Body>> Read()
        {
            return BodyDataAccess.GetAsync();
        }

        public Task<Body> Read(IBodyContainer bodyId)
        {
            return BodyDataAccess.GetAsync(bodyId);
        }

        public Task<Body> Update(IBodyContainer bodyId, BodyModel newBody)
        {
            return BodyDataAccess.UpdateAsync(bodyId, newBody);
        }

        public Task<Body> Delete(IBodyContainer bodyId)
        {
            return BodyDataAccess.DeleteAsync(bodyId);
        }
    }
}
