﻿using System;
using System.Collections.Generic;

#nullable disable

namespace customer.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public decimal? CustomerAmount { get; set; }
    }
}
