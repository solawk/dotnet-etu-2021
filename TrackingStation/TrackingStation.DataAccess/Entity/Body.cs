using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrackingStation.DataAccess.Entity
{
    public class Body
    {
        public Body()
        {
            Vessel = new HashSet<Vessel>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Name { get; set; }
        public double Radius { get; set; }
        public decimal SMA { get; set; }

        public virtual ICollection<Vessel> Vessel { get; set; }
    }
}
