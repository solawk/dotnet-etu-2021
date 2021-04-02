using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Contract;
using TrackingStation.Domain.Model;

namespace TrackingStation.BLL.Declaration
{
    public interface IVesselServant
    {
        public Task Validate(IVesselIdentity vesselContainer);

        public Task<Vessel> Create(VesselModel vessel);

        public Task<IEnumerable<Vessel>> Read();

        public Task<Vessel> Read(IVesselIdentity vesselId);

        public Task<Vessel> Update(IVesselIdentity vesselId, VesselModel newVessel);

        public Task<Vessel> Delete(IVesselIdentity vesselId);
    }
}
