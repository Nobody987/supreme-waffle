using PlanetaryGovernor.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class _Controller
    {
        static _Controller controller = null;

        private _Controller() { }

        //MainScreen main;
        //Planet planet;

        public static _Controller Instance
        { 
            get
            {
                if (controller == null)
                {
                    controller = new _Controller();
                }
                return controller;
            }
        }

        internal string[,] get_planet_information(Planet p)
        {
            string[,] result = new string[2,6];

            result[0, 0] = "Sector";             result[1, 0] = p.Home_sector.ToString();
            result[0, 1] = "Solar System";       result[1, 1] = p.Home_solarSystem.ToString();
            result[0, 2] = "Population";         result[1, 2] = Formatting.format_thousands(p.Planet_population_size);
            result[0, 3] = "Surface Area";       result[1, 3] = Formatting.format_add_square_kilometers(Formatting.format_thousands(p.Planet_surface_area));
            result[0, 4] = "Planet Type";        result[1, 4] = p.Planet_type.ToString();
            result[0, 5] = "Provinces";          result[1, 5] = p.Planet_number_of_provinces.ToString();

            return result;
        }
    }
}
