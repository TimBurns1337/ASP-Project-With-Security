using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project.Models
{
    public class Hdd
    {
        public int HddId { get; set; }
        
        public string HddName { get; set; }
        
        public double HddPrice { get; set; }
        
        public string ImageLink { get; set; }

        // may want to add image link and brnad name in further migrations 
    }
}
