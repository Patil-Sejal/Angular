using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Models
{
    public class Empcontext:DbContext
    
        {
            public Empcontext(DbContextOptions options) : base(options)
            {

            }
            DbSet<Employee> Employess { get; set; }
        }
}

