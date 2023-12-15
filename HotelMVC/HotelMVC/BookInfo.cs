using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class BookInfo
    {
        private int _numberPerson;
        private int _numberNight;
        private DateTime _dateDepart;
        private DateTime _dateArrivee;

        public int NumberPerson { get => _numberPerson; set => _numberPerson = value; }
        public int NumberNight { get => _numberNight; set => _numberNight = value; }
        public DateTime DateDepart { get => _dateDepart; set => _dateDepart = value; }
        public DateTime DateArrivee { get => _dateArrivee; set => _dateArrivee = value; }
    }
}
