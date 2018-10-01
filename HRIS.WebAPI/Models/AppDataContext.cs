using HRIS.WebAPI.Models.Master_Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.WebAPI.Models
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        {

        }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
