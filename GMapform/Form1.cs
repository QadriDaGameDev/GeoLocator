using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMapform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void namebtn_MouseHover(object sender, EventArgs e)
        {
            namebtn.BackColor = Color.Orange;
        }    
              

        private void namebtn_MouseLeave_1(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(51, 51, 76);
            namebtn.BackColor = customColor;
        }

        private void contactbtn_MouseHover(object sender, EventArgs e)
        {
            contactbtn.BackColor = Color.Orange;
        }

        private void contactbtn_MouseLeave(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(51, 51, 76);
            contactbtn.BackColor = customColor;
        }

        private void locationbtn_MouseHover(object sender, EventArgs e)
        {
            locationbtn.BackColor = Color.Orange;
        }

        private void locationbtn_MouseLeave(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(51, 51, 76);
           locationbtn.BackColor = customColor;
        }

        private void viewbtn_MouseHover(object sender, EventArgs e)
        {
           viewbtn.BackColor = Color.Orange;
        }

        private void viewbtn_MouseLeave(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(51, 51, 76);
            viewbtn.BackColor = customColor;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            //code for showing map on screen//
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            double lat, lon;
            lat = 24.9795066883323;
            lon = 67.0655250549316;
            gMapControl1.Position = new PointLatLng(lat, lon);
            gMapControl1.Zoom = 17;

            //code for marker//

            GMapOverlay o = new GMapOverlay("o");
            GMapMarker m = new GMarkerGoogle(new PointLatLng(lat, lon), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);

            gMapControl1.Overlays.Add(o);
            o.Markers.Add(m);
            gMapControl1.Invalidate();
            gMapControl1.Update();
        }

        private void sidebar_Scroll(object sender, ScrollEventArgs e)
        {
            gMapControl1.Zoom = sidebar.Value;
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleKoreaSatelliteMapProvider.Instance;
        }
    }
}
