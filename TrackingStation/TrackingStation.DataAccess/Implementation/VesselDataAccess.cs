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

        public async Task ValidateBody(VesselModel vessel)
        {
            if (await Context.Body.FirstOrDefaultAsync(b => b.BodyName == vessel.BodyName) == null)
            {
                throw new Exception($"Body {vessel.BodyName} of {vessel.Name} doesn't exist!");
            }
        }

        public async Task<Vessel> InsertAsync(VesselModel vessel)
        {
            await ValidateBody(vessel);
           
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

        public async Task<Vessel> UpdateAsync(VesselModel vessel)
        {
            VesselEntity entity = await Get(vessel);

            if (entity == null)
            {
                throw new Exception("This vessel doesn't exist!");
            }

            await ValidateBody(vessel);

            entity.Affiliation = vessel.Affiliation;
            entity.BodyName = vessel.BodyName;
            entity.DV = vessel.DV;
            entity.FlightState = vessel.FlightState;

            Context.Update(entity);

            await Context.SaveChangesAsync();

            return Mapper.Map<Vessel>(entity);
        }

        public async Task<Vessel> DeleteAsync(IVesselIdentity vesselId)
        {
            VesselEntity removing = await Get(vesselId);

            if (removing == null)
            {
                throw new Exception("This vessel doesn't exist!");
            }

            VesselEntity entity = Context.Vessel.Remove(removing).Entity;          

            await Context.SaveChangesAsync();

            return Mapper.Map<Vessel>(entity);
        }
    }
}
