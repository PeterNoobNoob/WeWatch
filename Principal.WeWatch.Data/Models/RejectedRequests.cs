using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class RejectedRequests
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Incident")]
        public int IncidentId { get; set; }
        public DateTime Created { get; set; }
    }
}
