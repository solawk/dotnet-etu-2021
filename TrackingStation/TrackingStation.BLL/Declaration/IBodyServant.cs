using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Contract;
using TrackingStation.Domain.Model;

namespace TrackingStation.BLL.Declaration
{
    public interface IBodyServant
    {
        public Task<Body> Create(BodyModel body);

        public Task<IEnumerable<Body>> Read();

        public Task<Body> Read(IBodyContainer bodyId);

        public Task<Body> Update(BodyModel body);

        public Task<Body> Delete(IBodyContainer bodyId);
    }
}
