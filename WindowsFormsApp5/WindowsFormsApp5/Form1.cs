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
using System.Data.SqlClient;
using Dapper;
using System.Collections;



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
            gmap.Position = new GMap.NET.PointLatLng(48.872562, 2.773616/*48.867374, 2.784018*/);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 16;
            gmap.DragButton = MouseButtons.Left;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker[] mark;
            mark = new GMapMarker[1000];



            for (int t = 0; t < DataService.att().Count; t++)
            {
                PointLatLng p = new PointLatLng(DataService.att()[t].Lat, DataService.att()[t].Lon);
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
                marker.ToolTipText = (t + 1).ToString();
                marker.ToolTipMode = MarkerTooltipMode.Always;
                mark[t] = marker;
            }



            //GMapMarker marker1 = new GMarkerGoogle(adventure, GMarkerGoogleType.blue_pushpin);
            /*
            GMapMarker marker2 = new GMarkerGoogle(pirates, GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker2);
            gmap.Overlays.Add(markers);
            GMapMarker marker3 = new GMarkerGoogle(world, GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker3);
            gmap.Overlays.Add(markers);
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

        private void label1_Click(object sender, EventArgs e)
        {
            for (int t = 0; t < DataService.att().Count; t++)
            {
                int x = t + 1;
                string result = "";
                result = x.ToString() + ". " + result + DataService.att()[t].Name + "\n";
                this.label1.Text = this.label1.Text + result;
            }
        }
    }
}
