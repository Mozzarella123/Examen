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

        DbSet<Film> Films { get; set; }
        DbSet<Hall> Halls { get; set; }
        DbSet<Place> Places { get; set; }
        DbSet<Seans> Seanses { get; set; }
        DbSet<Ticket> Tickets { get; set; }

    }
}
