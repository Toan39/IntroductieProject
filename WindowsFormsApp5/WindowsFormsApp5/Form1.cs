using GMap.NET.MapProviders;
using GMap.NET;
using GMap;
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
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(-25.974134, 32.593042/*48.867374, 2.784018*/);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 16;
            gmap.DragButton = MouseButtons.Left;

            PointLatLng start = new PointLatLng(-25.974134, 32.593042);
            PointLatLng end = new PointLatLng(-25.959048, 32.592827);
            
            MapRoute route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);

            GMapRoute r = new GMapRoute(route.Points, "My route");
            r.Stroke = new Pen(Color.Red, 20);
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
