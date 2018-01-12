using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenProj.Models;

namespace ExamenProj.Controllers
{
    class MainUserController
    {
        public ICollection<Film> GetFilms(DateTime date)
        {
            return null;
        }

        public ICollection<Film> GetFilms()
        {
            return null;
        }

        public ICollection<Seans> GetSeans(Film film)
        {
            return null;
        }

        public ICollection<Place> GetPlace(Seans seans)
        {
            return null;
        }

        public bool Buy(Seans seans,ICollection<Place> place)
        {
            return false;
        }

        public bool TicketReturn(DateTime dateTime,Film film,int HallId)
        {
            return false;
        }
    }
}
