using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new GMap.NET.PointLatLng(48.872618, 2.776765/*48.867374, 2.784018*/); 
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 16;
            gmap.DragButton = MouseButtons.Left;

            PointLatLng start = new PointLatLng(51.84906928092645, 4.674627074271992/*48.87273928374085, 2.7780222603896094*/);
            PointLatLng end = new PointLatLng(51.83607539301313, 4.690368966202675/*48.873275591357896, 2.776069612232649*/);
            MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(start, end, true, true, 15);

            GMapRoute r = new GMapRoute(route.Points, "My route");
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            gmap.Overlays.Add(routesOverlay);

        }

        // disable the red cross
        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.ShowCenter = false; 
        }
    }
}
