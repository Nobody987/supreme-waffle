using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class Population
    {
        static List<long> usedIDs = new List<long>();

        long population_id;
        string population_name;
        long population_size_total;
        double population_growth;
        long population_size_change;
        List<Industry> population_industry_list;

        public Population(string population_name, long population_size_total, double population_growth, List<Industry> population_industry_list)
        {
            population_id = get_free_ID();
            usedIDs.Add(population_id);
            this.population_name = population_name;
            this.population_size_total = population_size_total;
            this.population_growth = population_growth;
            this.Population_industry_list = population_industry_list;
            Population_size_change = population_size_change;
        }

        internal void UpdatePopulation(TimeSpan TS)
        {
            Population_size_total += Population_size_change * TS.Days;
        }

        public long return_number_of_industry_workers(IndustryType industryType)
        {
            IEnumerable<Industry> i = Population_industry_list.Where(industry => industry.Industry_type == industryType);
            List<Industry> list_ind = i.ToList();

            if (list_ind.Count() == 1)
            {
                return (long)(population_size_total * list_ind[0].Industry_population_percent);
            }
            else return 0;
        }

        public long return_number_of_industry_workers(string stringIndustryType)
        {
            IEnumerable<Industry> i = Population_industry_list.Where(industry => industry.Industry_type.ToString() == stringIndustryType);
            List<Industry> list_ind = i.ToList();

            if (list_ind.Count() == 1)
            {
                return (long)(population_size_total * list_ind[0].Industry_population_percent);
            }
            else return 0;
        }

        public Population()
        {
        }

        private static long get_free_ID()
        {
            long ID = usedIDs.Count();
            return ID;
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

        public List<Industry> Population_industry_list
        {
            get
            {
                return population_industry_list;
            }

            set
            {
                population_industry_list = value;
            }
        }
    }
}
