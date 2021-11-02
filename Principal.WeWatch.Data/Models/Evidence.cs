using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Principal.We_Watch.Data.Models
{
    public class Evidence
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 userId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public byte[] Media { get; set; }
    }
}
