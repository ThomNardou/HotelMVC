using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMVC
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 view = new Form1();
            Controller controller = new Controller();
            Model model = new Model();

            model.Controller = controller;
            view.Controller = controller;
            controller.Model = model;
            controller.View = view;

            Application.Run(view);
        }
    }
}
