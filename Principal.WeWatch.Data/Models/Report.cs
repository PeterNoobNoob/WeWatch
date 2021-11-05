using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Incident")]
        public int IncidentId { get; set; }
        public string HttpLink { get; set; }
    }
}
