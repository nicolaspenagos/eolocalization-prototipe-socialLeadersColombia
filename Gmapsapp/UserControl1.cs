using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Gmapsapp
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void gMapLoad(object sender, EventArgs e)
        {
            gmap1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gmap1.Zoom = 10;
            gmap1.MinZoom = 5;
            gmap1.MaxZoom = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GMapOverlay route = new GMapOverlay("layerRoute");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(10.9799669, -74.8013085));
            points.Add(new PointLatLng(10.238488238048035, -73.7030786046109));
            points.Add(new PointLatLng(11.682708309612607, -72.27343566838658));
            points.Add(new PointLatLng(8.984075876127989, -73.1989844606689));
            points.Add(new PointLatLng(7.394770540124568, -73.56340270650223));
            points.Add(new PointLatLng(8.7558921, -75.887029));
            GMapRoute routePoints = new GMapRoute(points, "Route");
            route.Routes.Add(routePoints);
            // gmap1.Overlays.Add(route);

            List<PointLatLng> pointsSo = new List<PointLatLng>();
            pointsSo.Add(new PointLatLng(4.433818434700072, -69.81259081035644));
            pointsSo.Add(new PointLatLng(3.8020982923705304, -67.95961285055465));
            pointsSo.Add(new PointLatLng(3.4760976694812626, -69.82226813188387));
            pointsSo.Add(new PointLatLng(4.05094603392196, -73.90967874235682));
            pointsSo.Add(new PointLatLng(1.306188981851065, -71.99480628344756));

            List<PointLatLng> pointsS = new List<PointLatLng>();
            pointsS.Add(new PointLatLng(1.163988608068152, -77.29107536552507));
            pointsS.Add(new PointLatLng(2.393819504599165, -76.61469809078275));
            pointsS.Add(new PointLatLng(1.0036880948262308, -75.92867293750417));
            pointsS.Add(new PointLatLng(-0.0600518, -74.6671585));

            var polygon = new GMapPolygon(points, "MyArea")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.FromArgb(50, 0, 0, 255))
            };

            var polygonSo = new GMapPolygon(pointsSo, "MyAreaSo")
            {
                Stroke = new Pen(Color.Red, 2),
                Fill = new SolidBrush(Color.FromArgb(50, 255, 0, 0))
            };

            var polygonS = new GMapPolygon(pointsS, "MyAreaS")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.FromArgb(50, 0, 153, 57))
            };


            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);

            var polygonsSo = new GMapOverlay("polygonsSo");
            polygonsSo.Polygons.Add(polygonSo);

            var polygonsS = new GMapOverlay("polygonsS");
            polygonsS.Polygons.Add(polygonS);

            gmap1.Overlays.Add(polygons);
            gmap1.Overlays.Add(polygonsSo);
            gmap1.Overlays.Add(polygonsS);








            GMapOverlay route1 = new GMapOverlay("layerRoute1");
            List<PointLatLng> points1 = new List<PointLatLng>();
            points1.Add(new PointLatLng(10.9799669, -74.8013085));
            points1.Add(new PointLatLng(10.394770540124568, -73.56340270650223));
            points1.Add(new PointLatLng(8.7558921, -75.887029));
            points1.Add(new PointLatLng(8.984075876127989, -73.1989844606689));
            GMapRoute routePoints1 = new GMapRoute(points1, "Route1");
            route1.Routes.Add(routePoints1);
           // gmap1.Overlays.Add(route1);




            Bitmap bmpMarker = (Bitmap)Image.FromFile("..\\..\\Properties\\marker1.png");
            Bitmap bmpMarker1 = (Bitmap)Image.FromFile("..\\..\\Properties\\leaderPic.png");
            GMapOverlay markers = new GMapOverlay("markers");
           // List<Leader> currentList = p.getLeaders();
            //int N = currentList.Count;
            GMapMarker marker1 = new GMarkerGoogle(
              new PointLatLng(10.9799669, -74.8013085),
              bmpMarker1);
            markers.Markers.Add(marker1);

            GMapMarker marker2 = new GMarkerGoogle(
            new PointLatLng(10.238488238048035, -73.7030786046109),
           bmpMarker1);
            markers.Markers.Add(marker2);

            GMapMarker marker3 = new GMarkerGoogle(
           new PointLatLng(11.682708309612607, -72.27343566838658),
           bmpMarker1);
            markers.Markers.Add(marker3);

            GMapMarker marker4 = new GMarkerGoogle(
         new PointLatLng(8.984075876127989, -73.1989844606689),
         bmpMarker1);
            markers.Markers.Add(marker4);

            GMapMarker marker5 = new GMarkerGoogle(
        new PointLatLng(7.394770540124568, -73.56340270650223),
        bmpMarker1);
            markers.Markers.Add(marker5);

            GMapMarker marker6 = new GMarkerGoogle(
       new PointLatLng(8.7558921, -75.887029),
       bmpMarker1);
            markers.Markers.Add(marker6);
            gmap1.Overlays.Add(markers);

            GMapMarker marker7 = new GMarkerGoogle(
      new PointLatLng(4.433818434700072, -69.81259081035644),
      bmpMarker1);
            markers.Markers.Add(marker7);
            gmap1.Overlays.Add(markers);

            GMapMarker marker8 = new GMarkerGoogle(
      new PointLatLng(3.8020982923705304, -67.95961285055465),
      bmpMarker1);
            markers.Markers.Add(marker8);
            gmap1.Overlays.Add(markers);

            GMapMarker marker9 = new GMarkerGoogle(
      new PointLatLng(3.4760976694812626, -69.82226813188387),
      bmpMarker1);
            markers.Markers.Add(marker9);
            gmap1.Overlays.Add(markers);

            GMapMarker marker10 = new GMarkerGoogle(
      new PointLatLng(1.163988608068152, -77.29107536552507),
      bmpMarker1);
            markers.Markers.Add(marker10);
            gmap1.Overlays.Add(markers);

            GMapMarker marker11 = new GMarkerGoogle(
      new PointLatLng(2.393819504599165, -76.61469809078275),
      bmpMarker1);
            markers.Markers.Add(marker11);
            gmap1.Overlays.Add(markers);


            GMapMarker marker12 = new GMarkerGoogle(
   new PointLatLng(4.05094603392196, -73.90967874235682),
   bmpMarker1);
            markers.Markers.Add(marker12);
            gmap1.Overlays.Add(markers);

            GMapMarker marker13 = new GMarkerGoogle(
   new PointLatLng(1.306188981851065, -71.99480628344756),
   bmpMarker1);
            markers.Markers.Add(marker13);
            gmap1.Overlays.Add(markers);




            GMapMarker marker14 = new GMarkerGoogle(
     new PointLatLng(1.0036880948262308, -75.92867293750417),
     bmpMarker1);
            markers.Markers.Add(marker14);
            gmap1.Overlays.Add(markers);

            GMapMarker marker15 = new GMarkerGoogle(
     new PointLatLng(-0.0600518, -74.6671585),
     bmpMarker1);
            markers.Markers.Add(marker15);
            gmap1.Overlays.Add(markers);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayudaaa");
        }
    }
}
