using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.Models
{
    public partial class Product
    {
        public int ProdId { get; set; }
        public int? Id { get; set; }
        public int? ProductSku { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public int? IsActive { get; set; }
    }
}
