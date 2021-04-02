using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Contract;
using TrackingStation.Domain.Model;

namespace TrackingStation.DataAccess.Declaration
{
    public interface IBodyDataAccess
    {
        public Task<Body> InsertAsync(BodyModel body);

        public Task<IEnumerable<Body>> GetAsync();

        public Task<Body> GetAsync(IBodyContainer bodyContainer);

        public Task<Body> UpdateAsync(IBodyContainer bodyContainer, BodyModel newBody);

        public Task<Body> DeleteAsync(IBodyContainer bodyContainer);
    }
}
