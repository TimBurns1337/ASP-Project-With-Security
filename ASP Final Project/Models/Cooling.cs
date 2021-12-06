using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project.Models
{
    public class Cooling
    {
        public int CoolingId { get; set; }
        [Required]
        public string CoolingName { get; set; }
        [Required]
        public double CoolingPrice { get; set; }
        [Required]
        public string ImageLink { get; set; }
    }
}
