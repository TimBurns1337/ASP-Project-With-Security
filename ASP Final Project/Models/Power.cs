using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project.Models
{
    public class Power
    {
        public int PowerId { get; set; }
        
        public string PowerName { get; set; }
        
        public double PowerPrice { get; set; }
        
        public string ImageLink { get; set; }

        // may want to add image link and brnad name in further migrations 
    }
}
