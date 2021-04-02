using AutoMapper;

namespace TrackingStation.WebAPI
{
    class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<DataAccess.Entity.VesselEntity, Domain.Vessel>();

            CreateMap<DataAccess.Entity.BodyEntity, Domain.Body>();
            CreateMap<Domain.Model.BodyModel, Domain.Body>();
            CreateMap<Domain.Model.BodyModel, DataAccess.Entity.BodyEntity>();

            CreateMap<Domain.Model.VesselModel, Domain.Vessel>();
            CreateMap<Domain.Model.VesselModel, DataAccess.Entity.VesselEntity>();

            CreateMap<Domain.Contract.IBodyContainer, DataAccess.Entity.BodyEntity>();
        }
    }
}
