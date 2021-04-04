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
    public class BodyDataAccess : IBodyDataAccess
    {
        private DataContext Context { get; }
        private IMapper Mapper { get; }

        public BodyDataAccess(DataContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public void ValidateNullName(BodyModel body)
        {
            if (body.BodyName == null)
            {
                throw new Exception(nameof(body.BodyName) + " cannot be null!");
            }
        }

        public async Task ValidateNoVessels(IBodyContainer bodyContainer)
        {
            if (await Context.Vessel.FirstOrDefaultAsync(v => v.BodyName == bodyContainer.BodyName) != null)
            {
                throw new Exception($"Body {bodyContainer.BodyName} has vessels!");
            }
        }

        public async Task<Body> InsertAsync(BodyModel body)
        {
            ValidateNullName(body);

            var result = await Context.AddAsync(Mapper.Map<BodyEntity>(body));

            await Context.SaveChangesAsync();

            return Mapper.Map<Body>(result.Entity);
        }

        private async Task<BodyEntity> Get(IBodyContainer body)
        {
            if (body == null)
            {
                throw new ArgumentNullException("Body is null");
            }

            return await Context.Body.FirstOrDefaultAsync(b => b.BodyName == body.BodyName);
        }

        public async Task<IEnumerable<Body>> GetAsync()
        {
            return Mapper.Map<IEnumerable<Body>>(await Context.Body.ToListAsync());
        }

        public async Task<Body> GetAsync(IBodyContainer bodyContainer)
        {
            return bodyContainer.BodyName != null ? Mapper.Map<Body>(await Get(bodyContainer)) : null;
        }     

        public async Task<Body> UpdateAsync(BodyModel body)
        {
            var entity = await Get(new VesselModel { BodyName = body.BodyName });

            if (entity == null)
            {
                throw new ArgumentNullException("Body not found");
            }

            entity.Radius = body.Radius;
            entity.SMA = body.SMA;
            entity.Type = body.Type;
            entity.Color = body.Color;
            entity.V1 = body.V1;
            entity.V2 = body.V2;

            await Context.SaveChangesAsync();

            return Mapper.Map<Body>(entity);
        }

        public async Task<Body> DeleteAsync(IBodyContainer body)
        {
            await ValidateNoVessels(body);

            var entity = Context.Body.Remove(await Get(body)).Entity;

            await Context.SaveChangesAsync();

            return Mapper.Map<Body>(entity);
        }
    }
}
