using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class Planet
    {
        string planet_image;

        string planet_name;
        string planet_type;
        long planet_population_size;
        long planet_radius;
        long planet_surface_area;
        long planet_number_of_provinces;
        long planet_total_province_size;
        List<Province> planet_province_list;
        SolarSystem home_solarSystem;
        Sector home_sector;
        Empire home_empire;

        public Planet(string planet_name, string planet_type, long planet_radius, List<Province> planet_province_list, string planet_image, SolarSystem home_solarSystem, Sector home_sector, Empire home_empire)
        {
            this.planet_name = planet_name;
            this.planet_type = planet_type;
            this.planet_province_list = planet_province_list;
            this.planet_radius = planet_radius;
            this.planet_image = planet_image;
            planet_surface_area = (long)(4 * planet_radius * planet_radius * Math.PI);
            planet_set_population_size();
            planet_set_total_province_size();
            planet_set_total_numberOf_provinces();
            planet_number_of_provinces = Planet_number_of_provinces;
            this.home_solarSystem = home_solarSystem;
            this.home_sector = home_sector;
            this.home_empire = home_empire;
        }

        public List<Population> planet_population_list_accumulative()
        {
            List<Population> population_list = new List<Population>();
            List<Population> population_list_accumulative = new List<Population>();

            foreach (Province province in Planet_province_list)
            {
                population_list.AddRange(province.Province_population_list);
            }
            
            foreach (Population population in population_list)
            {
                if (population_list_accumulative.Count > 0)
                {
                    foreach (Population pop in population_list_accumulative)
                    {
                        if (pop.Population_name == population.Population_name) //TODO change to ID comparison
                        {
                            pop.Population_size_total += population.Population_size_total;
                        }
                        else
                        {
                            population_list_accumulative.Add(population);
                            break;
                        }
                    }
                }
                else
                {
                    population_list_accumulative.Add(population);
                }
            }
            return population_list_accumulative;
        }

        public void planet_set_population_size()
        {
            if (planet_province_list != null)
            {
                foreach (Province item in planet_province_list)
                {
                    Planet_population_size = item.Province_population_list.Sum(pop => pop.Population_size_total);
                }
            }
            else Planet_population_size = 0;
        }

        public void planet_set_total_province_size()
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

        public void planet_set_total_numberOf_provinces()
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
                return planet_name;
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

        public List<Province> Planet_province_list
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

        public SolarSystem Home_solarSystem
        {
            get
            {
                return home_solarSystem;
            }

            set
            {
                home_solarSystem = value;
            }
        }

        public Sector Home_sector
        {
            get
            {
                return home_sector;
            }

            set
            {
                home_sector = value;
            }
        }

        public Empire Home_empire
        {
            get
            {
                return home_empire;
            }

            set
            {
                home_empire = value;
            }
        }

        public string Planet_type
        {
            get
            {
                return planet_type;
            }

            set
            {
                planet_type = value;
            }
        }
    }
}
