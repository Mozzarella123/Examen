using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProj.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public Place Place { get; set; }
        public double Summ { get; set; }
        public Seans Seans { get; set; }
    }
}
