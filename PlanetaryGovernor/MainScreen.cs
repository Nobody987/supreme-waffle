using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanetaryGovernor.main;
using System.Globalization;
using PlanetaryGovernor.tools;

namespace PlanetaryGovernor
{
    public partial class MainScreen : Form
    {

        public Planet p;

        public MainScreen(Planet p)
        {
            this.p = p;
            InitializeComponent();
            GUISetup();

            Image image_f = Image.FromFile(p.Planet_image);

            pictureBox1.BackgroundImage = image_f;
        }

        private void GUISetup()
        {
            labelPlanetName.Text = p.Planet_name;
            labelPlanetInformation.Text = "Planet Information";

            listViewPlanetInformation.Items.Add("Sector");
            listViewPlanetInformation.Items.Add("Solar System");
            listViewPlanetInformation.Items.Add("Population");
            listViewPlanetInformation.Items.Add("Surface Area");
            listViewPlanetInformation.Items.Add("Planet Type");
            listViewPlanetInformation.Items.Add("Provinces");
            populatePlanetInformation();
        }

        private void populatePlanetInformation()
        {

            listViewPlanetInformation.Items[0].SubItems.Add(p.Home_sector.ToString());
            listViewPlanetInformation.Items[1].SubItems.Add(p.Home_solarSystem.ToString());
            listViewPlanetInformation.Items[2].SubItems.Add(Formatting.format_thousands(p.Planet_population_size));
            listViewPlanetInformation.Items[3].SubItems.Add(Formatting.format_add_square_kilometers(Formatting.format_thousands(p.Planet_surface_area)));
            listViewPlanetInformation.Items[4].SubItems.Add(p.Planet_type.ToString());
            listViewPlanetInformation.Items[5].SubItems.Add(p.Planet_number_of_provinces.ToString());
        }
    }
}
