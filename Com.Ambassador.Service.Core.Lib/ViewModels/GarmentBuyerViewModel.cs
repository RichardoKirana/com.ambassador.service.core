﻿using Com.Ambassador.Service.Core.Lib.Helpers;
using System;

namespace Com.Ambassador.Service.Core.Lib.ViewModels
{
    public class GarmentBuyerViewModel : BasicViewModel
    {
        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string Country { get; set; }

        /* Int */
        public dynamic Tempo { get; set; }

        public string Contact { get; set; }

        public string Type { get; set; }
        
        public string NPWP { get; set; }

        public string BuyerType { get; set; }
        public string NIK { get; set; }
    }
}
