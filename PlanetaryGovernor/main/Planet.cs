using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class Planet
    {
        string planet_image;

        string planet_name;
        long planet_population_size;
        long planet_radius;
        long planet_surface_area;
        long planet_number_of_provinces;
        long planet_total_province_size;
        List<Province> planet_province_list;

        public Planet(string planet_name, long planet_radius, List<Province> planet_province_list, string planet_image)
        {
            this.planet_name = planet_name;
            this.planet_province_list = planet_province_list;
            this.planet_radius = planet_radius;
            this.Planet_image = planet_image;
            Planet_surface_area = (long)(4 * planet_radius * planet_radius * Math.PI);
            planet_set_population_size(planet_province_list);
            planet_set_total_province_size(planet_province_list);
            planet_set_total_numberOf_provinces(planet_province_list);
        }

        public void planet_set_population_size(List<Province> planet_province_list)
        {
            if (planet_province_list != null)
            {
                foreach (Province item in planet_province_list)
                {
                    Planet_population_size += item.Province_population.Population_size_total;
                }
            }
            else Planet_population_size = 0;
        }

        public void planet_set_total_province_size(List<Province> planet_province_list)
        {
            if (planet_province_list != null)
            {
                foreach (Province item in planet_province_list)
                {
                    Planet_total_province_size += item.Province_size;
                }
            }
            else Planet_total_province_size = 0;
        }

        public void planet_set_total_numberOf_provinces(List<Province> planet_province_list)
        {
            if (planet_province_list != null)
            {
                Planet_number_of_provinces = planet_province_list.Count();
            }
            else Planet_number_of_provinces = 0;
        }

        public override string ToString()
        {
            return Planet_name;
        }

        public string Planet_name
        {
            get
            {
                return Planet_name;
            }

            set
            {
                Planet_name = value;
            }
        }

        public long Planet_population_size
        {
            get
            {
                return planet_population_size;
            }

            set
            {
                planet_population_size = value;
            }
        }

        public long Planet_radius
        {
            get
            {
                return planet_radius;
            }

            set
            {
                planet_radius = value;
            }
        }

        public long Planet_surface_area
        {
            get
            {
                return planet_surface_area;
            }

            set
            {
                planet_surface_area = value;
            }
        }

        public long Planet_number_of_provinces
        {
            get
            {
                return planet_number_of_provinces;
            }

            set
            {
                planet_number_of_provinces = value;
            }
        }

        public long Planet_total_province_size
        {
            get
            {
                return planet_total_province_size;
            }

            set
            {
                planet_total_province_size = value;
            }
        }

        internal List<Province> Planet_province_list
        {
            get
            {
                return planet_province_list;
            }

            set
            {
                planet_province_list = value;
            }
        }

        public string Planet_image
        {
            get
            {
                return planet_image;
            }

            set
            {
                planet_image = value;
            }
        }
    }
}
