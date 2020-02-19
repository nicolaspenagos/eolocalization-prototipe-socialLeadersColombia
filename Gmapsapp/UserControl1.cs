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
using GMap.NET.MapProviders;

namespace Gmapsapp
{
    public partial class UserControl1 : UserControl
    {
        List<PointLatLng> _points;
        private bool button1P;
        private bool button2P;
        private GMarkerGoogle marker;
        private GMapOverlay markerOverlay;

        public UserControl1()
        {
            //GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            InitializeComponent();
            button1P = false;
            button2P = false;
            _points = new List<PointLatLng>();
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
                Stroke = new Pen(Color.FromArgb(255, 125, 201, 163), 2),
                Fill = new SolidBrush(Color.FromArgb(50, 125, 201, 163))
            };

            var polygonSo = new GMapPolygon(pointsSo, "MyAreaSo")
            {
                Stroke = new Pen(Color.Violet, 2),
                Fill = new SolidBrush(Color.FromArgb(50, 255, 51, 199))
            };

            var polygonS = new GMapPolygon(pointsS, "MyAreaS")
            {
                Stroke = new Pen(Color.Violet, 2),
                Fill = new SolidBrush(Color.FromArgb(50, 255, 51, 199))
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






        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayudaaa");
        }

        private void gmap1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Space)
            {
                MessageBox.Show("MARIA ANGELA TORRES ESTA SUFRIENDO UN EMERGENCIA");
                marker = new GMarkerGoogle(new PointLatLng(10.9799669, -74.8013085), GMarkerGoogleType.red);
                marker.Position = new PointLatLng(10.9799669, -74.8013085);
                markerOverlay = new GMapOverlay("Marker");
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("\n M. Angela Torres \n Latitude: {0} \n Longitud: {1}", 10.9799669, -74.8013085);
                markerOverlay.Markers.Add(marker);
                gmap1.Overlays.Add(markerOverlay);
                Console.WriteLine(_points.Count());
                _points.Add(new PointLatLng(10.9799669, -74.8013085));
                _points.Add(new PointLatLng(10.899177, -74.777662));
                Console.WriteLine(_points.Count());




            }
        }

        GMapOverlay markers = new GMapOverlay("markers");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            button1P = button1P?false:true;

            if (button1P)
            {
                pictureBox1.Image = Image.FromFile("..\\..\\Properties\\b1T-01.jpg");
                Bitmap bmpMarker = (Bitmap)Image.FromFile("..\\..\\Properties\\a-01.png");
                Bitmap bmpMarker1 = (Bitmap)Image.FromFile("..\\..\\Properties\\maa-01.png");
                
                // List<Leader> currentList = p.getLeaders();
                //int N = currentList.Count;
                GMapMarker marker1 = new GMarkerGoogle(
                  new PointLatLng(10.9799669, -74.8013085),
                  GMarkerGoogleType.green);
                markers.Markers.Add(marker1);

                GMapMarker marker2 = new GMarkerGoogle(
                new PointLatLng(10.238488238048035, -73.7030786046109),
              GMarkerGoogleType.green);
                markers.Markers.Add(marker2);

                GMapMarker marker3 = new GMarkerGoogle(
               new PointLatLng(11.682708309612607, -72.27343566838658),
              GMarkerGoogleType.green);
                markers.Markers.Add(marker3);

                GMapMarker marker4 = new GMarkerGoogle(
             new PointLatLng(8.984075876127989, -73.1989844606689),
             GMarkerGoogleType.green);
                markers.Markers.Add(marker4);

                GMapMarker marker5 = new GMarkerGoogle(
            new PointLatLng(7.394770540124568, -73.56340270650223),
            GMarkerGoogleType.green);
                markers.Markers.Add(marker5);

                GMapMarker marker6 = new GMarkerGoogle(
           new PointLatLng(8.7558921, -75.887029),
           GMarkerGoogleType.green);
                markers.Markers.Add(marker6);
                gmap1.Overlays.Add(markers);

                GMapMarker marker7 = new GMarkerGoogle(
          new PointLatLng(4.433818434700072, -69.81259081035644),
          GMarkerGoogleType.green);
                markers.Markers.Add(marker7);
                gmap1.Overlays.Add(markers);

                GMapMarker marker8 = new GMarkerGoogle(
          new PointLatLng(3.8020982923705304, -67.95961285055465),
          GMarkerGoogleType.green);
                markers.Markers.Add(marker8);
                gmap1.Overlays.Add(markers);

                GMapMarker marker9 = new GMarkerGoogle(
          new PointLatLng(3.4760976694812626, -69.82226813188387),
          GMarkerGoogleType.green);
                markers.Markers.Add(marker9);
                gmap1.Overlays.Add(markers);

                GMapMarker marker10 = new GMarkerGoogle(
          new PointLatLng(1.163988608068152, -77.29107536552507),
          GMarkerGoogleType.green);
                markers.Markers.Add(marker10);
                gmap1.Overlays.Add(markers);

                GMapMarker marker11 = new GMarkerGoogle(
          new PointLatLng(2.393819504599165, -76.61469809078275),
          GMarkerGoogleType.green);
                markers.Markers.Add(marker11);
                gmap1.Overlays.Add(markers);


                GMapMarker marker12 = new GMarkerGoogle(
       new PointLatLng(4.05094603392196, -73.90967874235682),
       GMarkerGoogleType.green);
                markers.Markers.Add(marker12);
                gmap1.Overlays.Add(markers);

                GMapMarker marker13 = new GMarkerGoogle(
       new PointLatLng(1.306188981851065, -71.99480628344756),
       GMarkerGoogleType.green);
                markers.Markers.Add(marker13);
                gmap1.Overlays.Add(markers);




                GMapMarker marker14 = new GMarkerGoogle(
         new PointLatLng(1.0036880948262308, -75.92867293750417),
         GMarkerGoogleType.green);
                markers.Markers.Add(marker14);
                gmap1.Overlays.Add(markers);

                GMapMarker marker15 = new GMarkerGoogle(
         new PointLatLng(-0.0600518, -74.6671585),
         GMarkerGoogleType.green);
                markers.Markers.Add(marker15);
                gmap1.Overlays.Add(markers);

                
            }
            else {
                pictureBox1.Image = Image.FromFile("..\\..\\Properties\\b1-01.jpg");
         

                gmap1.Overlays.Clear();
            }
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            button2P = button2P ? false : true;

            if (button2P) {
                pictureBox2.Image = Image.FromFile("..\\..\\Properties\\B2T-01.jpg");
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
                    Stroke = new Pen(Color.FromArgb(255, 125, 201, 163), 2),
                    Fill = new SolidBrush(Color.FromArgb(50, 125, 201, 163))
                };

                var polygonSo = new GMapPolygon(pointsSo, "MyAreaSo")
                {
                    Stroke = new Pen(Color.Violet, 2),
                    Fill = new SolidBrush(Color.FromArgb(50, 255, 51, 199))
                };

                var polygonS = new GMapPolygon(pointsS, "MyAreaS")
                {
                    Stroke = new Pen(Color.Violet, 2),
                    Fill = new SolidBrush(Color.FromArgb(50, 255, 51, 199))
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
            }
            else {
                pictureBox2.Image = Image.FromFile("..\\..\\Properties\\b2-01.png");
                gmap1.Overlays.Clear();
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bitmap bmpMarker1 = (Bitmap)Image.FromFile("..\\..\\Properties\\aa-01.png");
            Bitmap bmpMarker2 = (Bitmap)Image.FromFile("..\\..\\Properties\\cr-01.png");
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(10.979879, -74.800958));
            points.Add(new PointLatLng(10.979342, -74.801217));
            points.Add(new PointLatLng(10.97826, -74.801826));
            points.Add(new PointLatLng(10.977956, -74.801975));
            points.Add(new PointLatLng(10.976678, -74.8027));
            points.Add(new PointLatLng(10.9755, -74.803256));
            points.Add(new PointLatLng(10.975643, -74.803939));
            points.Add(new PointLatLng(10.975217, -74.803937));
            GMapRoute route = new GMapRoute(points, "A walk in the park");
            route.Stroke = new Pen(Color.Green, 3);
            routes.Routes.Add(route);
            gmap1.Overlays.Add(routes);

            GMapMarker marker12 = new GMarkerGoogle(
      new PointLatLng(10.974805, -74.80396),
      bmpMarker1);
            markers.Markers.Add(marker12);
            gmap1.Overlays.Add(markers);


            GMapMarker marker13 = new GMarkerGoogle(
      new PointLatLng(10.982107,-74.803246),
      bmpMarker2);
            markers.Markers.Add(marker13);
            gmap1.Overlays.Add(markers);

            GMapOverlay routes1 = new GMapOverlay("routes1");
            List<PointLatLng> points1 = new List<PointLatLng>();

            
            points1.Add(new PointLatLng(10.979636, -74.80185));
            points1.Add(new PointLatLng(10.979904, -74.802559));
            points1.Add(new PointLatLng(10.981074, -74.802033));
            points1.Add(new PointLatLng(10.981578, -74.803299));
            points1.Add(new PointLatLng(10.981811, -74.803147));
     
            GMapRoute route1 = new GMapRoute(points1, "A");
            route1.Stroke = new Pen(Color.Red, 3);
            routes1.Routes.Add(route1);
            gmap1.Overlays.Add(routes1);
            /*
           string start = "Avenida Armando Tivane, Maputo, Mozambique";
           string end = "Rua 1301, Maputo, Mozambique";
           MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(
             start, end, false, false, 15);

           GMapRoute r = new GMapRoute(route.Points, "My route");
           GMapOverlay routesOverlay = new GMapOverlay("routes");
           routesOverlay.Routes.Add(r);
           gmap1.Overlays.Add(routesOverlay);
           */

        }
    }
}
