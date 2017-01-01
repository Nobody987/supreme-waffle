using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaryGovernor.main
{
    public static class Time
    {
        static DateTime date;
        static DateTime previous_date;
        static TimeSpan delta;

        public static void increment_date(TimeSpan time)
        {
            Previous_date = Date;
            Date += time;
            Delta = update_delta();
        }

        private static TimeSpan update_delta()
        {
            return Date - Previous_date;
        }

        public static DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public static DateTime Previous_date
        {
            get
            {
                return previous_date;
            }

            set
            {
                previous_date = value;
            }
        }

        public static TimeSpan Delta
        {
            get
            {
                return delta;
            }

            set
            {
                delta = value;
            }
        }
    }
}
