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
        public string Name { get; set; }
        public double Radius { get; set; }
        public double SMA { get; set; }

        public virtual List<VesselEntity> Vessel { get; set; }
    }
}
