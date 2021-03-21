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
        public Task<Body> GetAsync(IBodyContainer vessel);
    }
}
