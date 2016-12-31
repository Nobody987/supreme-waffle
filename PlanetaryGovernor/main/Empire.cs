using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{

    public class Empire
    {
        string empire_name;
        string empire_government; //TODO - za sadsa samo string
        long empire_numberOf_sectores;
        long empire_numberOf_systems;
        long empire_numberOf_planets;
        long empire_population;
        string empire_head;
        string empire_capital;

        public Empire()
        {

        }

        public override string ToString()
        {
            return empire_name;
        }

        public string Empire_name
        {
            get
            {
                return empire_name;
            }

            set
            {
                empire_name = value;
            }
        }

        public string Empire_government
        {
            get
            {
                return empire_government;
            }

            set
            {
                empire_government = value;
            }
        }

        public long Empire_numberOf_sectores
        {
            get
            {
                return empire_numberOf_sectores;
            }

            set
            {
                empire_numberOf_sectores = value;
            }
        }

        public long Empire_numberOf_systems
        {
            get
            {
                return empire_numberOf_systems;
            }

            set
            {
                empire_numberOf_systems = value;
            }
        }

        public long Empire_numberOf_planets
        {
            get
            {
                return empire_numberOf_planets;
            }

            set
            {
                empire_numberOf_planets = value;
            }
        }

        public long Empire_population
        {
            get
            {
                return empire_population;
            }

            set
            {
                empire_population = value;
            }
        }

        public string Empire_head
        {
            get
            {
                return empire_head;
            }

            set
            {
                empire_head = value;
            }
        }

        public string Empire_capital
        {
            get
            {
                return empire_capital;
            }

            set
            {
                empire_capital = value;
            }
        }
    }
}
