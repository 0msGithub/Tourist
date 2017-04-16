using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MetadataExtractor;
using GMap;
namespace Tourist
{
    public partial class Main : Form
    {
        private Tourist.TouristSetting settings;
        private string selectedPath = "";
        private ListViewItem FileListView;
        GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");

        public Main()
        {
            InitializeComponent();
            settings = new Tourist.TouristSetting();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // GMap 기본설정
            TouristGmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            TouristGmap.Position = new GMap.NET.PointLatLng(37.398889, 126.726111);
            TouristGmap.DragButton = MouseButtons.Left;




        }
        private void setImageListView(string[] filelist)
        {
            //detailView.Clear();
            foreach (string objFile in filelist)
            {
                // Exif Format을 가진 이미지파일만 작업 수행
                if (Tourist.TouristBasicUtil.checkExifFile(objFile))
                {
                    Tourist.PropertyFileInfo pf = Tourist.TouristFileInfo.getFileInfo(objFile);
                    FileListView = new ListViewItem(pf.filename);
                    FileListView.SubItems.Add("test");
                    FileListView.SubItems.Add(Tourist.TouristBasicUtil.GetFileSize(pf.filesize));
                    detailView.Items.Add(FileListView);
                    FileStream fs = new FileStream(objFile, FileMode.Open, FileAccess.Read);
                    IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(fs);
                    var subIfdDirectory = directories.OfType<MetadataExtractor.Formats.Exif.GpsDirectory>().FirstOrDefault();
                    var gpsLatitude = subIfdDirectory?.GetDescription(MetadataExtractor.Formats.Exif.GpsDirectory.TagLatitude);
                    var gpsLongitude = subIfdDirectory?.GetDescription(MetadataExtractor.Formats.Exif.GpsDirectory.TagLongitude);
                    double Latitude = Tourist.TouristBasicUtil.ConvertGPSLocation(subIfdDirectory?.GetDescription(MetadataExtractor.Formats.Exif.GpsDirectory.TagLatitude));
                    double Longitude = Tourist.TouristBasicUtil.ConvertGPSLocation(subIfdDirectory?.GetDescription(MetadataExtractor.Formats.Exif.GpsDirectory.TagLongitude));

                    TouristGmap.Overlays.Add(SetMarkers(Latitude, Longitude));

                }
                detailView.EndUpdate();
                if (detailView.Items.Count == 0)
                    detailViewLabel.Visible = true;
                else
                    detailViewLabel.Visible = false;
            }
        }

        private void DeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/exploitforme");
        }

        private void ExifLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TouristDirBrowser.ShowDialog() == DialogResult.OK)
            {
                selectedPath = TouristDirBrowser.SelectedPath;
                label_selectedPath.Text = selectedPath;

                // ListView Setting
                setImageListView(System.IO.Directory.GetFiles(selectedPath));
            }
            else
                MessageBox.Show("분석대상 디렉터리를 지정해주십시오.", "Tourist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public GMap.NET.WindowsForms.GMapOverlay SetMarkers(double temp_1, double temp_2)
        {

            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(temp_1, temp_2),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker);
            return markers;
        }




    }
}