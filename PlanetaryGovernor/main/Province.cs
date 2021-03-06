﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class Province
    {
        string province_name;
        long province_size;
        double province_unreast;
        bool province_isCapital;
        List<Population> province_population_list;
        List<Province> province_list_neighbours;
        List<Building> province_building_list;

        public Province(string province_name, long province_size, double province_unreast, bool province_isCapital, List<Population> province_population_list, List<Province> province_list_neighbours, List<Building> province_building_list)
        {
            this.Province_name = province_name;
            this.Province_size = province_size;
            this.Province_unreast = province_unreast;
            this.Province_isCapital = province_isCapital;
            this.province_population_list = province_population_list;
            this.Province_list_neighbours = province_list_neighbours;
            this.province_building_list = province_building_list;
        }

        public Province()
        {

        }

        public string Province_name
        {
            get
            {
                return province_name;
            }

            set
            {
                province_name = value;
            }
        }

        public long Province_size
        {
            get
            {
                return province_size;
            }

            set
            {
                province_size = value;
            }
        }

        public double Province_unreast
        {
            get
            {
                return province_unreast;
            }

            set
            {
                province_unreast = value;
            }
        }

        public bool Province_isCapital
        {
            get
            {
                return province_isCapital;
            }

            set
            {
                province_isCapital = value;
            }
        }

        internal List<Population> Province_population_list
        {
            get
            {
                return province_population_list;
            }

            set
            {
                province_population_list = value;
            }
        }

        internal List<Province> Province_list_neighbours
        {
            get
            {
                return province_list_neighbours;
            }

            set
            {
                province_list_neighbours = value;
            }
        }

    }
}
