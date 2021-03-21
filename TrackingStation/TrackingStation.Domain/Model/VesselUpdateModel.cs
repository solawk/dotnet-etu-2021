using System;
using System.Collections.Generic;
using System.Text;
using TrackingStation.Domain.Contract;

namespace TrackingStation.Domain.Model
{
    public class VesselUpdateModel : IVesselIdentity, IBodyContainer
    {
        public string Name { get; set; }

        public string Affiliation { get; set; }

        public DateTime LaunchDate { get; set; }

        public string? BodyName { get; set; }
    }
}
