using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class Sector
    {
        string sector_name;
        long sector_numberOf_solarSystems;
        string sector_head;

        public Sector(string sector_name, long sector_numberOf_solarSystems, string sector_head)
        {
            this.sector_name = sector_name;
            this.sector_numberOf_solarSystems = sector_numberOf_solarSystems;
            this.sector_head = sector_head;
        }

        public override string ToString()
        {
            return sector_name;
        }

        public string Sector_name
        {
            get
            {
                return sector_name;
            }

            set
            {
                sector_name = value;
            }
        }

        public long Sector_numberOf_solarSystems
        {
            get
            {
                return sector_numberOf_solarSystems;
            }

            set
            {
                sector_numberOf_solarSystems = value;
            }
        }

        public string Sector_head
        {
            get
            {
                return sector_head;
            }

            set
            {
                sector_head = value;
            }
        }
    }
}
