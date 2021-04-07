using System;
using System.Collections.Generic;
using System.Text;
using TrackingStation.Domain.Contract;

namespace TrackingStation.Domain.Model
{
    public class VesselModel : IVesselIdentity, IBodyContainer
    {
        public string Name { get; set; }

        public string Affiliation { get; set; }

        public string? BodyName { get; set; }

        public double DV { get; set; }

        public int FlightState { get; set; }
    }
}
