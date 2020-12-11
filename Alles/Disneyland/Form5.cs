
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Disneyland
{
    public partial class Form5 : Form
    {
        
        public Form5(List<attraction> list)
        {
            InitializeComponent();
            
           // System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/plattegronden/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 rides = new Form3();
            rides.Show();
            this.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        //    this.webBrowser1.Navigate("https://www.google.nl/maps/dir/It's+a+Small+World,+Disneyland/Adventure+Isle,+/Pirates+of+the+Caribbean,+Disneyland/");                                                               ");
            webBrowser1.ScriptErrorsSuppressed = true;
            
        }
        //tijdfunctie

        public class attraction
        {
            public string Name;
            public double Lat;
            public double Lon;
        }
    }
}
