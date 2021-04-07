using System;
using System.Collections.Generic;
using System.Text;

namespace TrackingStation.WebClient.Models
{
    public class InputVessel
    {
        public string Name { get; set; }

        public string Affiliation { get; set; }

        public string? BodyName { get; set; }

        public double DV { get; set; }

        public int FlightState { get; set; }
    }
}
