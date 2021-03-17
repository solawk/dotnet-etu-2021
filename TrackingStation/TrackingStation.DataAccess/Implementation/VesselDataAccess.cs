using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.DataAccess.Context;
using TrackingStation.DataAccess.Declaration;
using TrackingStation.Domain;
using TrackingStation.Domain.Model;

namespace TrackingStation.DataAccess.Implementation
{
    class VesselDataAccess : IVesselDataAccess
    {
        private VesselContext Context { get; }
        private IMapper Mapper {get;}

        public async Task<Vessel> InsertAsync(VesselUpdateModel vessel)
        {
            var result = await Context.AddAsync(Mapper.Map<Vessel>(vessel));

            await Context.SaveChangesAsync();

            return Mapper.Map<TrackingStation.Domain.Vessel>(result.Entity);
        }
    }
}
