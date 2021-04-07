using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingStation.WebClient.Models
{
    public class InputBody
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
