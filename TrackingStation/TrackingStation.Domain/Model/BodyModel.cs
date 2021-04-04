using System;
using System.Collections.Generic;
using System.Text;
using TrackingStation.Domain.Contract;

namespace TrackingStation.Domain.Model
{
    public class BodyModel : IBodyContainer
    {
        public string BodyName { get; set; }

        public double Radius { get; set; }

        public double SMA { get; set; }

        public double V1 { get; set; }

        public double V2 { get; set; }

        public int Type { get; set; }

        public int Color { get; set; }
    }
}
