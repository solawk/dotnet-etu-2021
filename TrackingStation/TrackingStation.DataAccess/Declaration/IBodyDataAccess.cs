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
        public void ValidateNullName(BodyModel body);

        public Task ValidateNoVessels(IBodyContainer bodyContainer);

        public Task<Body> InsertAsync(BodyModel body);

        public Task<IEnumerable<Body>> GetAsync();

        public Task<Body> GetAsync(IBodyContainer bodyContainer);

        public Task<Body> UpdateAsync(BodyModel body);

        public Task<Body> DeleteAsync(IBodyContainer bodyContainer);
    }
}
