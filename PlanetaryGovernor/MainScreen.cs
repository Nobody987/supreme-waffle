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

namespace PlanetaryGovernor
{
    public partial class MainScreen : Form
    {
        public Planet p;

        public MainScreen(Planet p)
        {
            InitializeComponent();
            this.p = p;

            Image image_f = Image.FromFile(p.Planet_image);

            pictureBox1.BackgroundImage = image_f;
        }
    }
}
