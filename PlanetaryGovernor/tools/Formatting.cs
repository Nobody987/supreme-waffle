using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.tools
{
    public static class Formatting
    {
        public static string format_thousands(long number)
        {
            return number.ToString("N0", CultureInfo.CreateSpecificCulture("en-UK"));
        }

        public static string format_add_square_kilometers(string number)
        {
            return number + " km²";
        }
    }
}
