using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.JSON;

namespace HotelMVC
{
    public class Model
    {
        private Controller _controller;

        public Controller Controller { get => _controller; set => _controller = value; }

        public bool processBooking(BookInfo bi)
        {
            if (bi.NumberNight > 0 && bi.NumberNight <= 7)
            {
                File.WriteAllText("BookInfo.txt", )
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
