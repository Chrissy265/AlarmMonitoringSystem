using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Data
{
    class AlarmMonitorDbContext : DbContext
    {
        //Entities 
        public DbSet<Log> logger { get; set; }

        public AlarmMonitorDbContext()
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
