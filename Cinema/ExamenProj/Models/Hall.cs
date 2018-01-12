using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProj.Models
{
    public class Hall
    {
        public int HallId { get; set; }
        public int PlaceCount { get; set; }
        public int RowCount { get; set; }
        public ICollection<Place> Places { get; set; }

    }
}
