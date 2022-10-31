using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.Models
{
    public partial class Login1
    {
        public int Lid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public int? IsActive { get; set; }
    }
}
