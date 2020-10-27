using FoodToStep.Models.Configs;
using FoodToStep.Models.ObjectDTO;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodToStep.Models
{
    public class HomeContext : DbContext
    {
        public DbSet<FoodDTO> Foods { get; set; }
        public DbSet<UserDTO> Users { get; set; }

        public HomeContext(DbContextOptions<HomeContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigDB.ConnectionSting);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
