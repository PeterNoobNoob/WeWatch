using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class RejectedRequests
    {
        public int UserId { get; set; }
        public int IncidentId { get; set; }
        public DateTime Created { get; set; } // tento atr je možno zbytočný
    }
}
