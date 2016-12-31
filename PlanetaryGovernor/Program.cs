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
            SolarSystem hydra = new SolarSystem("Hydra", "NONE", 7);
            Sector segmentusObscurus = new Sector("Segmentus Obscurus", 26, "NONE");

            Population human_population = new Population("Human", 100000, 0);
            Province p = new Province("A", 1000, 0, false, human_population, null, null);
                    

            List<Province> province_list = new List<Province>();
            province_list.Add(p);

            Planet Aurelius = new Planet("Aurelius", "Continental" ,6371, province_list, PlanetaryGovernor.Properties.Resources.PLANET_IMAGES + "planet_1.jpg", hydra, segmentusObscurus, null);

            //Console.ReadLine();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen(Aurelius));


        }
    }
}
