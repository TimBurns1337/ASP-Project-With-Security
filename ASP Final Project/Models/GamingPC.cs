﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project.Models
{
    public class GamingPC
    {
        public int GamingPCId { get; set; }
        // see all the details of the pc 
        public string Componets { get; set; }
        // proived a shorted view of components - cpu and gpu 
        public string Summary { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public int Price { get; set; }

    }
}
