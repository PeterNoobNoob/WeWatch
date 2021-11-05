using Principal.WeWatch.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.WeWatch.ApiShare.DtoModels
{
    public class GridListModelDto
    {
        public int Id { get; set; }
        public User Owner { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
