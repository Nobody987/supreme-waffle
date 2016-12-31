using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanetaryGovernor.main;
using System.Drawing;

namespace PlanetaryGovernor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Planet p = new Planet("Aurelius", 6371, null, PlanetaryGovernor.Properties.Resources.PLANET_IMAGES + "planet_1.jpg");

            //Console.ReadLine();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen(p));


        }
    }
}
