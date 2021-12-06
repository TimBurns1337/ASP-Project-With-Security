using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project.Models
{
    public class Case
    {
        public int CaseId { get; set; }
        [Required]
        public string CaseName { get; set; }
        [Required]
        public double CasePrice { get; set; }
        [Required]
        public string ImageLink { get; set; }
    }
}
