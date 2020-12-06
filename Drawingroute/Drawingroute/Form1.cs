using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace Drawingroute
{
    public partial class Form1 : Form
    {
        park disneyland;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1100, 1000);
            this.Paint += this.drawroute;
            disneyland = new park(); //creates the park as object, meaning a list of all the attractions with their corresponding paths.
        }

        public void drawroute(object o, PaintEventArgs pea)
        {
            Graphics gr = pea.Graphics;
            ResourceManager resourcemanager = 
                new ResourceManager("Drawingroute.Properties.Resources", Assembly.GetExecutingAssembly());
            Image background = (Image)resourcemanager.GetObject("disneylandmap");
            gr.DrawImage(background, 0, 0); //shows the map of disneyland in the application.

            Brush br = Brushes.Black;
            Pen p = Pens.Black;
            disneyland.Draw(gr, br, p); //takes care of drawing the locations of the attractions and their corresponding paths.

        }
    }
}
