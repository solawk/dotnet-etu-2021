using System;
using System.Threading.Tasks;
using TrackingStation.Domain;

namespace TrackingStation.BLL.Declaration
{
    interface IBodyGetService
    {
        Task ValidateAsync();
    }
}
