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

        public Task<Body> Update(BodyModel body)
        {
            return BodyDataAccess.UpdateAsync(body);
        }

        public Task<Body> Delete(IBodyContainer bodyId)
        {
            return BodyDataAccess.DeleteAsync(bodyId);
        }
    }
}
