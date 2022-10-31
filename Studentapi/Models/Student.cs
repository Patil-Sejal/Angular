using System;
using System.Collections.Generic;

#nullable disable

namespace Studentapi.Models
{
    public partial class Student
    {
        public int Sid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int? Tid { get; set; }
    }
}
