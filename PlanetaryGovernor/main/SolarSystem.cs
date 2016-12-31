using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public class SolarSystem
    {
        string solarSystem_name;
        string solarSystem_head;
        long solarSystem_numberOf_planets;

        public SolarSystem(string solarSystem_name, string solarSystem_head, long solarSystem_numberOf_planets)
        {
            this.solarSystem_name = solarSystem_name;
            this.solarSystem_head = solarSystem_head;
            this.solarSystem_numberOf_planets = solarSystem_numberOf_planets;
        }

        public override string ToString()
        {
            return solarSystem_name;
        }

        public string SolarSystem_name
        {
            get
            {
                return solarSystem_name;
            }

            set
            {
                solarSystem_name = value;
            }
        }

        public string SolarSystem_head
        {
            get
            {
                return solarSystem_head;
            }

            set
            {
                solarSystem_head = value;
            }
        }

        public long SolarSystem_numberOf_planets
        {
            get
            {
                return solarSystem_numberOf_planets;
            }

            set
            {
                solarSystem_numberOf_planets = value;
            }
        }
    }
}
