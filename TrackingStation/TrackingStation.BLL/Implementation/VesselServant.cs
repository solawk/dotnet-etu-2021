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
    public class VesselServant : IVesselServant
    {
        private IVesselDataAccess VesselDataAccess { get; }

        public VesselServant(IVesselDataAccess vesselDataAccess)
        {
            VesselDataAccess = vesselDataAccess;
        }

        public async Task Validate(IVesselIdentity vesselId)
        {
            if (vesselId == null)
            {
                throw new ArgumentNullException("Vessel Identity is null");
            }

            Vessel vessel = await Read(vesselId);

            if (vesselId.Name != null && vessel == null)
            {
                throw new InvalidOperationException("No vessel with name " + vesselId.Name);
            }
        }

        public Task<Vessel> Create(VesselModel vessel)
        {
            return VesselDataAccess.InsertAsync(vessel);
        }

        public Task<IEnumerable<Vessel>> Read()
        {
            return VesselDataAccess.GetAsync();
        }

        public Task<Vessel> Read(IVesselIdentity vesselId)
        {
            return VesselDataAccess.GetAsync(vesselId);
        }

        public Task<Vessel> Update(VesselModel vessel)
        {
            return VesselDataAccess.UpdateAsync(vessel);
        }

        public Task<Vessel> Delete(IVesselIdentity vesselId)
        {
            return VesselDataAccess.DeleteAsync(vesselId);
        }
    }
}
