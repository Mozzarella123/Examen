using ExamenProj.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProj
{
    public class AppDbContext : DbContext
    {

        public DbSet<Film> Films { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Seans> Seanses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}
