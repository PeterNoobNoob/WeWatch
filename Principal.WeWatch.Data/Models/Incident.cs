using Principal.We_Watch.Data.Enums;
using Principal.We_Watch.Domain.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public User Owner { get; set; }
        public DateTime DateOfEvent { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Media> AttachedMedia { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public List<Evidence> AttachedEvidence { get; set; }
        public IncidentType Type { get; set; }
        public bool IsClosed { get; set; }
        public bool IsOwnerVictim { get; set; }
    }
}
