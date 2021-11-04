using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Principal.WeWatch.Data.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string BlobFileAddress { get; set; }
        public DateTime Created { get; set; }
    }
}
