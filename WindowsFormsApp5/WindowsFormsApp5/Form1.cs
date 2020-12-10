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
using System.Resources;
using System.Reflection;



namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<Point> locations;
        List<string> attractions;
        public Form1()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            gmap.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(48.872562, 2.773616/*48.867374, 2.784018*/);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 16;
            gmap.DragButton = MouseButtons.Left;
            GMapOverlay markers = new GMapOverlay("markers");
            ResourceManager resourcemanager= new ResourceManager("WindowsFormsApp5.Properties.Resources", Assembly.GetExecutingAssembly());

            PointLatLng adventure = new PointLatLng(48.872562, 2.773616);
            PointLatLng pirates = new PointLatLng(48.873491, 2.773383);
            PointLatLng world = new PointLatLng(48.874590, 2.776050);
            GMapMarker[] mark;
            mark = new GMapMarker[1000];
           
                //string mark = "marker" + t;
                bool c;
                
                for(int t = 0; t<attractions.Count; t++)
                {
                GMapMarker result = new GMarkerGoogle(attraction.Location, GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(result);
                gmap.Overlays.Add(markers);
                result.ToolTipText = t.ToString();
                mark[t] = result;
                }

            //GMapMarker marker1 = new GMarkerGoogle(adventure, GMarkerGoogleType.blue_pushpin);
            /*
            GMapMarker marker2 = new GMarkerGoogle(pirates, GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker2);
            gmap.Overlays.Add(markers);
            GMapMarker marker3 = new GMarkerGoogle(world, GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker3);
            gmap.Overlays.Add(markers);
            marker1.ToolTipMode = MarkerTooltipMode.Always;
            marker2.ToolTipMode = MarkerTooltipMode.Always;
            marker3.ToolTipMode = MarkerTooltipMode.Always;
            marker1.ToolTipText = "1";
            marker2.ToolTipText = "2";
            marker3.ToolTipText = "3";*/
        }

            // disable the red cross
            private void Form1_Load(object sender, EventArgs e)
        {
            gmap.ShowCenter = false; 
        }
    }
}
