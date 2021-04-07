using System.Collections.Generic;
using TrackingStation.Domain.Model;

namespace TrackingStation.Domain
{
    public class Body
    {
        public string BodyName { get; set; }

        public double Radius { get; set; }

        public double SMA { get; set; }

        public double V1 { get; set; }

        public double V2 { get; set; }

        public int Type { get; set; }

        public int Color { get; set; }

        public List<VesselModel> Vessel { get; set; }
    }
}
