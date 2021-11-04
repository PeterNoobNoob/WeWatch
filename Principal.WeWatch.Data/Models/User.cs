using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Principal.We_Watch.Domain.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid Token { get; set; } // tu este pozriet
        public string Forename { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}
