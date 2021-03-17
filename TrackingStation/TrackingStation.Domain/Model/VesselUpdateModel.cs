using System;
using System.Collections.Generic;
using System.Text;

namespace TrackingStation.Domain.Model
{
    public class VesselUpdateModel
    {
        public string Name { get; set; }

        public string Affiliation { get; set; }

        public DateTime LaunchDate { get; set; }

        public string? BodyName { get; set; }
    }
}
