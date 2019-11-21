using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitecWithTemplateAPI.Models;

namespace VitecWithTemplateAPI.Data
{
    public class VitecWithTemplateAPIContext : DbContext
    {
        public VitecWithTemplateAPIContext(DbContextOptions<VitecWithTemplateAPIContext> options)
    : base(options) {
        }

        public DbSet<Product> Product { get; set; }
    }
}
