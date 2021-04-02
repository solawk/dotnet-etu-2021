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

        public async Task<Body> InsertAsync(BodyModel body)
        {
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

            return await Context.Body.FirstOrDefaultAsync(b => b.Name == body.BodyName);
        }

        public async Task<IEnumerable<Body>> GetAsync()
        {
            return Mapper.Map<IEnumerable<Body>>(await Context.Body.ToListAsync());
        }

        public async Task<Body> GetAsync(IBodyContainer bodyContainer)
        {
            return bodyContainer.BodyName != null ? Mapper.Map<Body>(await Get(bodyContainer)) : null;
        }     

        public async Task<Body> UpdateAsync(IBodyContainer body, BodyModel newBody)
        {
            var entity = await Get(body);

            if (entity == null)
            {
                throw new ArgumentNullException("Body not found");
            }

            entity.Name = newBody.Name;
            entity.Radius = newBody.Radius;
            entity.SMA = newBody.SMA;

            await Context.SaveChangesAsync();

            return Mapper.Map<Body>(entity);
        }

        public async Task<Body> DeleteAsync(IBodyContainer body)
        {
            var entity = Context.Body.Remove(await Get(body)).Entity;

            await Context.SaveChangesAsync();

            return Mapper.Map<Body>(entity);
        }
    }
}
