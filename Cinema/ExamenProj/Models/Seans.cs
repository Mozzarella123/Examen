using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProj.Models
{
    public class Seans
    {
        public int SeansId { get; set; }
        public Hall Hall { get; set; }
        public DateTime Time { get; set; }
        public double Price { get; set; }
        public Film Film { get; set; }
        public  ICollection<Ticket> Tickets { get; set; }
    }
}
