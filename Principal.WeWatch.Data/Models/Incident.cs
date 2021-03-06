using Principal.We_Watch.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class Incident
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int OwnerId { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsClosed { get; set; }
        public bool IsOwnerVictim { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
