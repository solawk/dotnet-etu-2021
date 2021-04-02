using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackingStation.DataAccess.Context;
using TrackingStation.DataAccess.Declaration;
using TrackingStation.DataAccess.Entity;
using TrackingStation.Domain;
using TrackingStation.Domain.Contract;
using TrackingStation.Domain.Model;

namespace TrackingStation.DataAccess.Implementation
{
    public class VesselDataAccess : IVesselDataAccess
    {
        private DataContext Context { get; }
        private IMapper Mapper { get; }

        public VesselDataAccess(DataContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public async Task<Vessel> InsertAsync(VesselModel vessel)
        {
            var result = await Context.AddAsync(Mapper.Map<VesselEntity>(vessel));

            try
            {
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbUpdateE)
            {
                Console.WriteLine("Something was wrong with the update: " + dbUpdateE.InnerException.Message);
            }

            return Mapper.Map<Vessel>(result.Entity);
        }

        private async Task<VesselEntity> Get(IVesselIdentity vesselId)
        {
            if (vesselId == null)
            {
                throw new ArgumentNullException("Vessel is null");
            }

            return await Context.Vessel.Include(v => v.RefBody).FirstOrDefaultAsync(v => v.Name == vesselId.Name);
        }

        public async Task<IEnumerable<Vessel>> GetAsync()
        {
            return Mapper.Map<IEnumerable<Vessel>>(await Context.Vessel.Include(v => v.RefBody).ToListAsync());
        }

        public async Task<Vessel> GetAsync(IVesselIdentity vesselId)
        {
            return Mapper.Map<Vessel>(await Get(vesselId));
        }

        public async Task<Vessel> UpdateAsync(IVesselIdentity vesselId, VesselModel vessel)
        {
            VesselEntity entity = await Get(vesselId);

            entity.Name = vessel.Name;
            entity.Affiliation = vessel.Affiliation;
            entity.LaunchDate = vessel.LaunchDate;
            entity.BodyName = vessel.BodyName;

            Context.Update(entity);

            await Context.SaveChangesAsync();

            return Mapper.Map<Vessel>(entity);
        }

        public async Task<Vessel> DeleteAsync(IVesselIdentity vesselId)
        {
            VesselEntity entity = Context.Vessel.Remove(await Get(vesselId)).Entity;

            await Context.SaveChangesAsync();

            return Mapper.Map<Vessel>(entity);
        }
    }
}
