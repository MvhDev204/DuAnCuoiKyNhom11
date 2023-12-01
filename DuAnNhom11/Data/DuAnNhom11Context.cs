using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DuAnNhom11.Models;

namespace DuAnNhom11.Data
{
    public class DuAnNhom11Context : DbContext
    {
        public DuAnNhom11Context (DbContextOptions<DuAnNhom11Context> options)
            : base(options)
        {
        }

        public DbSet<DuAnNhom11.Models.User> User { get; set; } = default!;

        public DbSet<DuAnNhom11.Models.Brand> Brand { get; set; } = default!;

        public DbSet<DuAnNhom11.Models.Category> Category { get; set; } = default!;

        public DbSet<DuAnNhom11.Models.Product> Product { get; set; } = default!;
    }
}
