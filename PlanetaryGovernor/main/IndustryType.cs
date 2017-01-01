using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class IndustryType
    {
        string industryType_name;

        public IndustryType(string industryType_name)
        {
            this.industryType_name = industryType_name;
        }

        public override string ToString()
        {
            return industryType_name; 
        }

        public string IndustryType_name
        {
            get
            {
                return industryType_name;
            }

            set
            {
                industryType_name = value;
            }
        }
    }
}
