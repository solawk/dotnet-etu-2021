using System;

namespace TrackingStation.Domain
{
    public class Vessel
    {
        public string name { get; set; }

        public string affiliation { get; set; }

        public Location location { get; set; }

        public DateTime launchDate { get; set; }

        public decimal dv { get; set; }
    }
}