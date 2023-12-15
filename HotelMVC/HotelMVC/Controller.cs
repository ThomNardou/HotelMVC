using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC
{
    public class Controller
    {
        Model _model;
        Form1 _view;

        public Model Model { get => _model; set => _model = value; }
        public Form1 View { get => _view; set => _view = value; }

        public void processBooking(BookInfo bi)
        {
            Model.processBooking(bi);
        }
    }
}
