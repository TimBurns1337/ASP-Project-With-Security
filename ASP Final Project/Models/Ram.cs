using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project.Models
{
    public class Ram
    {
        public int RamId { get; set; }
        
        public string RamName { get; set; }
       
        public double RamPrice { get; set; }
        
        public string ImageLink { get; set; }

        // may want to add image link and brnad name in further migrations 
    }
}
