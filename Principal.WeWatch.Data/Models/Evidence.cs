using Principal.We_Watch.Domain.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class Evidence
    {
        public int Id { get; set; }
        public User Owner { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Media> AttachedMedia { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Incident IncidentId { get; set; }
    }
}
