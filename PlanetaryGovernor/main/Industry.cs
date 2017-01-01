using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class Industry
    {
        string industry_name;
        IndustryType industry_type;
        double industry_population_percent; //what percent of attached population is working in this industry
        //Population industry_workers;
        long industry_size;

        public Industry(string industry_name, IndustryType industry_type, double industry_population_percent, long industry_size)
        {
            this.industry_name = industry_name;
            this.industry_type = industry_type;
            this.industry_population_percent = industry_population_percent;
            this.industry_size = industry_size;
        }

        public override string ToString()
        {
            return industry_name;
        }

        public string Industry_name
        {
            get
            {
                return industry_name;
            }

            set
            {
                industry_name = value;
            }
        }

        public IndustryType Industry_type
        {
            get
            {
                return industry_type;
            }

            set
            {
                industry_type = value;
            }
        }

        //public Population Industry_workers
        //{
        //    get
        //    {
        //        return industry_workers;
        //    }

        //    set
        //    {
        //        industry_workers = value;
        //    }
        //}

        public long Industry_size
        {
            get
            {
                return industry_size;
            }

            set
            {
                industry_size = value;
            }
        }

        public double Industry_population_percent
        {
            get
            {
                return industry_population_percent;
            }

            set
            {
                industry_population_percent = value;
            }
        }
    }
}
