using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VitecMv_MVC.Models
{
    public class VitecMv_MVCContext : DbContext
    {
        public VitecMv_MVCContext (DbContextOptions<VitecMv_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<VitecMv_MVC.Models.Product> Product { get; set; }
    }
}
