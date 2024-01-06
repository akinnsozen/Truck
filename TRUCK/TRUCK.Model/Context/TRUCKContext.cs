using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Map;
using TRUCK.Model.Entities;
using TRUCK.Model.Maps;

namespace TRUCK.Model.Context
{
    public class TRUCKContext : DbContext
    {
        public TRUCKContext(DbContextOptions<TRUCKContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminUserMap()); 
            modelBuilder.ApplyConfiguration(new SalesMap());
            modelBuilder.ApplyConfiguration(new WorkMachineMap());
            modelBuilder.ApplyConfiguration(new DriverMap());
           

            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<WorkMachine> WorkMachines { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}
