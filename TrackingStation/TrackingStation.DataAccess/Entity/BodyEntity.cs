using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrackingStation.DataAccess.Entity
{
    public class BodyEntity
    {
        public BodyEntity()
        {
            Vessel = new List<VesselEntity>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BodyName { get; set; }
        public double Radius { get; set; }
        public double SMA { get; set; }
        public double V1 { get; set; }
        public double V2 { get; set; }
        public int Type { get; set; }
        public int Color { get; set; }

        public virtual List<VesselEntity> Vessel { get; set; }
    }
}
