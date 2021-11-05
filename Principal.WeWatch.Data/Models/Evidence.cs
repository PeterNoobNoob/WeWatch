using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class Evidence
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Incident")]
        public int IncidentId { get; set; }
        [ForeignKey("User")]
        public int OwnerId { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
