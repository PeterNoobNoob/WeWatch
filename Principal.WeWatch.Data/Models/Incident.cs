using Principal.We_Watch.Data.Enums;
using Principal.We_Watch.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Principal.We_Watch.Data.Models
{
    public class Incident
    {
        [Key]
        public Int64 Id { get; set; }
        public string Title { get; set; }
        public IncidentType Type { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public byte[] Media { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public List<Evidence> Evidences { get; set; }


    }
}
