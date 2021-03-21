using System;
using System.Threading.Tasks;
using TrackingStation.Domain;
using TrackingStation.Domain.Contract;

namespace TrackingStation.BLL.Declaration
{
    public interface IBodyGetService
    {
        public Task ValidateAsync(IBodyContainer bodyContainer);
    }
}
