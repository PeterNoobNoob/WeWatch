using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Evidence")]
        public int EvidenceId { get; set; }
        [ForeignKey("Incident")]
        public int IncidentId { get; set; }
        public string Name { get; set; }
        public string BlobFileAddress { get; set; }
        public DateTime Created { get; set; }
    }
}
