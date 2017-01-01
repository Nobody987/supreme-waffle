﻿using System;
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
        List<Population> population_list_accumulative;
        List<IndustryType> AllIndustryType_list;

        public MainScreen(Planet p, List<IndustryType> AllIndustryType_list)
        {
            this.p = p;
            population_list_accumulative = p.planet_population_list_accumulative();
            this.AllIndustryType_list = AllIndustryType_list;
            InitializeComponent();
            GUISetup();

            Image image_f = Image.FromFile(p.Planet_image);

            pictureBox1.BackgroundImage = image_f;
        }

        private void GUISetup() //TODO Srediti sta je zakucano
        {
            labelTime.Text = Time.Date.ToString();

            labelPlanetName.Text = p.Planet_name;

            labelPlanetInformation.Text = "Planet Information";
            listViewPlanetInformation.Items.Add("Sector");
            listViewPlanetInformation.Items.Add("Solar System");
            listViewPlanetInformation.Items.Add("Population");
            listViewPlanetInformation.Items.Add("Surface Area");
            listViewPlanetInformation.Items.Add("Planet Type");
            listViewPlanetInformation.Items.Add("Provinces");

            panelPopulationInfo.Hide();

            //labelPopulationName.Hide();
            //labelPopulationSize.Hide();
            //labelPopulationGrowth.Hide();

            populatePlanetInformation();
            populatePopulationTab();
        }

        private void populatePopulationTab()
        {
            treeViewPopulationBreakdown.Nodes.Add(p.Planet_name);
            foreach (Population item in population_list_accumulative)
            {
                //treeViewPopulationBreakdown.Nodes[0].Nodes.Add(item + " " + Formatting.format_thousands(item.Population_size_total));
                treeViewPopulationBreakdown.Nodes[0].Nodes.Add(item.Population_name);
            }
            treeViewPopulationBreakdown.ExpandAll();

            foreach (var item in AllIndustryType_list)
            {
                listViewIndustryBreakdown.Items.Add(item.ToString());
            }
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

        private void treeViewPopulationBreakdown_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewPopulationBreakdown.SelectedNode != treeViewPopulationBreakdown.Nodes[0])
            {
                IEnumerable<Population> Ipops_list = population_list_accumulative.Where(population => population.Population_name == treeViewPopulationBreakdown.SelectedNode.Text);
                List<Population> pops_list = Ipops_list.ToList();
                if (pops_list.Count() == 1)
                {
                    update_population_statistics(pops_list[0]);
                }
                else throw new Exception("Error with returning selected population");
            }
        }

        private void update_population_statistics(Population population)
        {
            panelPopulationInfo.Show();
            
            labelPopulationName.Text = population.Population_name;
            labelPopulationSize.Text = "Population " + Formatting.format_thousands(population.Population_size_total).ToString();
            labelPopulationGrowth.Text = "Growth " + Formatting.format_percent(population.Population_growth).ToString();

            for (int i = 0; i < listViewIndustryBreakdown.Items.Count; i++)
            {
                string[] parameter_array = new string[2];
                parameter_array[0] = listViewIndustryBreakdown.Items[i].Text;
                parameter_array[1] = Formatting.format_thousands(population.return_number_of_industry_workers(listViewIndustryBreakdown.Items[i].Text)).ToString();
                ListViewItem lvi = new ListViewItem(parameter_array);
                listViewIndustryBreakdown.Items[i] = lvi;
            }
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            Time.increment_date(new TimeSpan(1,0,0,0));
            labelTime.Text = Time.Date.ToString();

            updateAll(Time.Delta);
        }

        private void updateAll(TimeSpan TS)
        {
            updateAllPopulations(TS);
            update_planet_information();
        }

        private void update_planet_information()
        {
            foreach (ListViewItem item in listViewPlanetInformation.Items)
            {
                
            }

            listViewPlanetInformation.Items[0].SubItems.Add(p.Home_sector.ToString());
            listViewPlanetInformation.Items[1].SubItems.Add(p.Home_solarSystem.ToString());
            listViewPlanetInformation.Items[2].SubItems.Add(Formatting.format_thousands(p.Planet_population_size));
            listViewPlanetInformation.Items[3].SubItems.Add(Formatting.format_add_square_kilometers(Formatting.format_thousands(p.Planet_surface_area)));
            listViewPlanetInformation.Items[4].SubItems.Add(p.Planet_type.ToString());
            listViewPlanetInformation.Items[5].SubItems.Add(p.Planet_number_of_provinces.ToString());
        }

        private void updateAllPopulations(TimeSpan TS)
        {
            foreach (Province item in p.Planet_province_list)
            {
                foreach (Population pop in item.Province_population_list)
                {
                    pop.UpdatePopulation(TS);
                    update_population_statistics(pop);
                }
            }
        }
    }
}
