using System;
using TrackingStation.Domain.Contract;
using TrackingStation.Domain.Model;

namespace TrackingStation.Domain
{
    public class Vessel : IBodyContainer
    {
        public string Name { get; set; }

        public string Affiliation { get; set; }

        public BodyModel RefBody { get; set; }

        public double DV { get; set; }

        public int FlightState { get; set; }

        string? IBodyContainer.BodyName => RefBody.BodyName;
    }
}