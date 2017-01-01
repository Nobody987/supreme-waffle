using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanetaryGovernor.main;
using System.Drawing;

namespace PlanetaryGovernor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<IndustryType> IndustryType_list = initialize_Industries();

            SolarSystem hydra = Initialize_SolarSystem();
            Sector segmentusObscurus = Initialize_Sector();

            List<Industry> human_industry_list = new List<Industry>();
            human_industry_list.Add(new Industry("Agriculture", IndustryType_list[0], 0.60, 0));
            human_industry_list.Add(new Industry("Manufacture", IndustryType_list[1], 0.25, 0));
            human_industry_list.Add(new Industry("Services", IndustryType_list[2], 0.10, 0));
            human_industry_list.Add(new Industry("Security", IndustryType_list[3], 0.05, 0));

            List<Industry> xeno1_industry_list = new List<Industry>();
            xeno1_industry_list.Add(new Industry("Agriculture", IndustryType_list[0], 0.80, 0));
            xeno1_industry_list.Add(new Industry("Manufacture", IndustryType_list[1], 0.05, 0));
            xeno1_industry_list.Add(new Industry("Services", IndustryType_list[2], 0.15, 0));

            List<Industry> xeno2_industry_list = new List<Industry>();
            xeno2_industry_list.Add(new Industry("Agriculture", IndustryType_list[0], 1, 0));

            List<Population> population_list = new List<Population>();
            population_list.Add(new Population("Human", 100000, 0.0657, human_industry_list));
            population_list.Add(new Population("Xeno1", 300000, 0.0236, xeno1_industry_list));
            population_list.Add(new Population("Xeno2", 500000, 0.018, xeno2_industry_list));

            Province p = new Province("A", 1000, 0, false, population_list, null, null);

            List<Province> province_list = new List<Province>();
            province_list.Add(p);

            Planet Aurelius = new Planet("Danicicak", "Continental", 6371, province_list, Properties.Resources.PLANET_IMAGES + "planet_1.jpg", hydra, segmentusObscurus, null);

            //Console.ReadLine();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen(Aurelius, IndustryType_list));

        }

        private static Sector Initialize_Sector()
        {
            return new Sector("Segmentus Obscurus", 26, "NONE");
        }

        private static SolarSystem Initialize_SolarSystem()
        {
            return new SolarSystem("Hydra", "NONE", 7);
        }

        private static List<IndustryType> initialize_Industries()
        {
            List<IndustryType> IndustryType_list = new List<IndustryType>();
            IndustryType_list.Add(new IndustryType("Agriculture"));
            IndustryType_list.Add(new IndustryType("Manufacture"));
            IndustryType_list.Add(new IndustryType("Services"));
            IndustryType_list.Add(new IndustryType("Security"));
            IndustryType_list.Add(new IndustryType("Governance"));
            IndustryType_list.Add(new IndustryType("Unemployed"));

            return IndustryType_list;
        }
    }
}
