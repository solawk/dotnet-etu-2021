using System;
using System.Collections.Generic;
using System.Text;
using TrackingStation.WebClient.Models;

namespace TrackingStation.WebClient.Models
{
    public class VesselModel
    {
        public string Name { get; set; }
        public string Affiliation { get; set; }
        public BodyModel RefBody { get; set; }
        public double DV { get; set; }
        public int FlightState { get; set; }
        public string? BodyName { get; set; }       
    }
}
