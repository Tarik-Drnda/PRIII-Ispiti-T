using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
        public class KonekcijaNaBazu : DbContext
        {
            private string dbPutanja { get; set; }
            public KonekcijaNaBazu() 
            {
                dbPutanja = ConfigurationManager.ConnectionStrings["DLWMSPutanja"].ConnectionString;
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite(dbPutanja);
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Student>().ToTable("Studenti");
                modelBuilder.Entity<StudentiPredmeti>().ToTable("StudentiPredmeti");
                modelBuilder.Entity<Predmet>().ToTable("Predmeti");
                modelBuilder.Entity<PredmetiSeminarski>().ToTable("PredmetiSeminarski");
            modelBuilder.Entity<Student>().HasMany(s => s.predmetiSeminarski).WithOne(sp => sp.Student);
            }
            public DbSet<Student> Studenti { get; set; }
            public DbSet<StudentiPredmeti> StudentiPredmeti { get; set; }
            public DbSet<Predmet> Predmeti { get; set; }
            public DbSet<PredmetiSeminarski> PredmetiSeminarski { get; set; }
        } 
}
