using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LogisticsApp
{
    public partial class LogisticsContextDB : DbContext
    {
        public LogisticsContextDB()
            : base("name=LogisticsContextDB")
        {
        }

        public virtual DbSet<Logistic> Logistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logistic>()
                .Property(e => e.Id)
                .IsFixedLength();
        }
    }
}
