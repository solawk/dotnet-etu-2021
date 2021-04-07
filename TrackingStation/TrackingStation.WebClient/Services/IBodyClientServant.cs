using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingStation.WebClient.Models;

namespace TrackingStation.WebClient.Services
{
    public interface IBodyClientServant
    {
        Task<IEnumerable<BodyModel>> GetAllBodies();

        public Task<BodyModel> GetSpecificBody(string bodyName);

        public Task<BodyModel> AddBody(InputBody newBody);

        public Task<BodyModel> EditBody(InputBody editedBody);

        public Task<BodyModel> DeleteBody(string bodyName);
    }
}
