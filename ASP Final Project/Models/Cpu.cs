using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project.Models
{
    public class Cpu
    {
        public int CpuId { get; set; }
        [Required]
        public string CpuName { get; set; }
        
        public double CpuPrice { get; set; }
       
        public string ImageLink { get; set; }
    }
}
