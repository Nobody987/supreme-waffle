using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class Building
    {
        string building_name;
        string building_image;

        public string Building_name
        {
            get
            {
                return building_name;
            }

            set
            {
                building_name = value;
            }
        }

        public string Building_image
        {
            get
            {
                return building_image;
            }

            set
            {
                building_image = value;
            }
        }
    }
}
