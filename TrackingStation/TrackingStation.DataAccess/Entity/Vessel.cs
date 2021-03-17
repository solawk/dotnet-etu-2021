using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TrackingStation.Domain;

namespace TrackingStation.DataAccess.Entity
{
    public class Vessel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Name { get; set; }
        public string Affiliation { get; set; }
        public DateTime LaunchDate { get; set; }
        public string? BodyName { get; set; }

        public virtual Body RefBody { get; set; }
    }
}
