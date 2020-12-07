using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Disneyland
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Attracties", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            ImageList img = new ImageList();
            img.ImageSize = new Size(250, 250);

            string[] paths = { };
            paths = Directory.GetFiles("C:/users/Renata Shamon/Documents/GitHub/IntroductieProject/Disneyland/attracties");

            try
            {
                foreach (string path in paths)
                {
                    img.Images.Add(Image.FromFile(path));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            listView1.SmallImageList = img;
            listView1.Items.Add("It's a small world", 0);
            listView1.Items.Add("Adventure Isle", 1);
            listView1.Items.Add("Alice's Curious Labyrinth", 2);
        }
        private void Form6_MouseClick(object sender, MouseEventArgs mea)
        {
            // var keuze = listView1.SelectedItems[0].SubItems[0].;
            listView1.Items[0].Tag = "Hijs de zeilen voor een wonderbaarlijke wereldreis, terwijl poppen van over de hele wereld 'it's a small world' zingen.";
            listView1.Items[1].Tag = "Familieplezier ten top! Verzamel al je moed om dit mysterieuze land te ontdekken en kijk of je de geheimen van Skull Rock kunt ontrafelen.";
            listView1.Items[2].Tag = "Dwaal door je eigen avontuur in Wonderland waar achter elke hoek een lach op je wacht zo breed als die van de Kolderkat.";
            string selected = listView1.SelectedItems[0].Tag.ToString();
            MessageBox.Show(selected);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 map = new Form5();
            map.Show();
            this.Hide();
        }
    }
}
