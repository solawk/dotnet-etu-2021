using System;
using TrackingStation.Domain.Contract;

namespace TrackingStation.Domain
{
    public class Vessel : IBodyContainer
    {
        public string Name { get; set; }

        public string Affiliation { get; set; }

        public Body RefBody { get; set; }

        public DateTime LaunchDate { get; set; }

        public decimal DV { get; set; }

        string? IBodyContainer.BodyName => RefBody.Name;
    }
}