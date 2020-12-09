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
            /*
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(48.8589507, 2.2775175);
            gmap.ShowCenter = false;
            */
            
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new GMap.NET.PointLatLng(48.872618, 2.776765/*48.867374, 2.784018*/); 
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 16;
            gmap.DragButton = MouseButtons.Left;

        }
        
        // disable the red cross
        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.ShowCenter = false; 
        }
    }
}
