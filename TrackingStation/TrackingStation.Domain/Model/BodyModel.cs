using System;
using System.Collections.Generic;
using System.Text;
using TrackingStation.Domain.Contract;

namespace TrackingStation.Domain.Model
{
    public class BodyModel
    {
        public string Name { get; set; }

        public double Radius { get; set; }

        public double SMA { get; set; }
    }
}
