using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.Collections;


namespace Disneyland
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
       
            // System.Diagnostics.Process.Start("https://www.disneylandparis.com/nl-nl/plattegronden/");
        }


        private void label1_Click(object sender, EventArgs e)
        {
            for (int t = 0; t < Form3.DataService.att.Count; t++)
            {
                int x = t + 1;
                string result = "";
                result = x.ToString() + ". " + result + Form3.DataService.att[t].Name + "\n";
                this.label1.Text = this.label1.Text + result;
            }
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

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(48.872562, 2.773616);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 16;
            gmap.ShowCenter = false;
            gmap.DragButton = MouseButtons.Left;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker[] mark;
            mark = new GMapMarker[1000];



            for (int t = 0; t < Form3.DataService.att.Count; t++)
            {
                PointLatLng p = new PointLatLng(Form3.DataService.att[t].Lat, Form3.DataService.att[t].Lon);
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
                marker.ToolTipText = (t + 1).ToString();
                marker.ToolTipMode = MarkerTooltipMode.Always;
                mark[t] = marker;
            }
        }
    }
    public class attraction
    {
        public string Name;
        public double Lat;
        public double Lon;
    }
}
