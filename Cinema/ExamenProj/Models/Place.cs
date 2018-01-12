using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProj.Models
{
    public class Place
    {
        public int PlaceId { get; set; }
        public int Seat { get; set; }
        public double Price { get; set; }
        public Hall Hall { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
