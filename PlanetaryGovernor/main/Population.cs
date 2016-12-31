using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class Population
    {
        string population_name;
        long population_size_total;
        double population_growth;
        long population_size_change;

        public Population(string population_name, long population_size_total, double population_growth)
        {
            this.population_name = population_name;
            this.population_size_total = population_size_total;
            this.population_growth = population_growth;
            Population_size_change = population_size_change;
        }

        public Population()
        {
        }

        public override string ToString()
        {
            return population_name; 
        }

        public string Population_name
        {
            get
            {
                return population_name;
            }

            set
            {
                population_name = value;
            }
        }

        public long Population_size_total
        {
            get
            {
                return population_size_total;
            }

            set
            {
                population_size_total = value;
            }
        }

        public long Population_size_change
        {
            get
            {
                return population_size_change;
            }

            set
            {
                population_size_change = (long)(population_size_total * population_growth);
            }
        }

        public double Population_growth
        {
            get
            {
                return population_growth;
            }

            set
            {
                population_growth = value;
            }
        }
    }
}
