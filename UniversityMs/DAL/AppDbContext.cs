using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityMs.Models;

namespace UniversityMs.DAL
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Graduate> Graduates { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Mezun> Mezunlar { get; set; }
        public DbSet<RektorPage> Rektorlar { get; set; }
        public DbSet<Prorektorpage> Prorektorlar { get; set; }
        public DbSet<Elmishurapage> Elmishuralar { get; set; }
        public DbSet<Newspage> Newspages { get; set; }
        public DbSet<Aboutpage> Aboutpages { get; set; }
        public DbSet<Googlemap> Maps { get; set; }
        public DbSet<Settings> Settings { get; set; }

    }
}
