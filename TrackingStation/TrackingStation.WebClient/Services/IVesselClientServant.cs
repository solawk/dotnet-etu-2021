using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingStation.WebClient.Models;

namespace TrackingStation.WebClient.Services
{
    public interface IVesselClientServant
    {
        Task<IEnumerable<VesselModel>> GetAllVessels();

        public Task<VesselModel> GetSpecificVessel(string vesselName);

        public Task<VesselModel> AddVessel(InputVessel newVessel);

        public Task<VesselModel> EditVessel(InputVessel editedVessel);

        public Task<VesselModel> DeleteVessel(string vesselName);
    }
}
