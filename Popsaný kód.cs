using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace RustBestSpot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int formWidth;
        int formHeight;

        Bitmap MapSource;
        Bitmap IconSource;

        Bitmap SpotPaint;
        Bitmap HighLighte;
        Graphics g;

        int matchCounter;
        bool Matched = false;

        Dictionary<string, List<Point>> placesOnMap = new Dictionary<string, List<Point>>();

        Dictionary<string, int> mapPlacesValue = new Dictionary<string, int>() { 
            { "gasstation", 1 },
            { "junkyard", 1 },
            { "lighthouse", 1 },
            { "supermarket", 1 },
            { "powerplant", 1 },
            { "airfield", 1 },
            { "trainyard", 1 },
            { "watertreatment", 1 },
            { "militarytunnel", 1 },
            { "launchsite", 1 },
            { "cabin", 1 },
            { "swamp", 1 },
            { "warehouse", 1 },
            { "outpost", 1 },
            { "dome", 1 },
            { "dish", 1 },
            { "fishing", 1 },
            { "harbor", 1 },
            { "radtown", 1 },
            { "excavator", 1 }};

        Dictionary<Point, double> pointValue = new Dictionary<Point, double>();


        Point pointOfInterest;


        private void btnSelectImage_Click(object sender, EventArgs e)  // Po kliknutí vyzve k vybrání podkladu, nastaví podklad aby ho uživatel viděl, napíše rozměry.
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                
                MapSource = new Bitmap(fileDialog.FileName);
                HighLighte = new Bitmap(MapSource);
                pictureBox1.Image = HighLighte;

                imageSizeWidth.Text = MapSource.Width.ToString();
                imageSizeHeight.Text = MapSource.Height.ToString();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Main_Resize(sender, e);
        }

        private void Main_Resize(object sender, EventArgs e) // Hlídá aby velikost okna nebyla menší než limit.
        {
            formWidth = this.Width;
            formHeight = this.Height;

            if (formWidth < 800)
            {
                this.Width = 800;
            }
            else if (formHeight < 700)
            {
                this.Height = 700;
            }

            imageSizeWidth.Text = formWidth.ToString();
            imageSizeHeight.Text = pictureBox1.Width.ToString();

            pictureBox1.Width = formWidth - (115 * 2);          // Nastavuje největší možnou velikost obrázku k velikosti okna.
            pictureBox1.Height = formHeight - (55 * 2);

            if (pictureBox1.Width > pictureBox1.Height)  // Zachovává největší možný čtverec.
            {
                pictureBox1.Width = pictureBox1.Height;
            }
            else
            {
                pictureBox1.Height = pictureBox1.Width;

            }
            pictureBox1.Left = (formWidth / 2) - pictureBox1.Width / 2;

        }

        private void run_Click(object sender, EventArgs e)
        {
            if (!Matched && IconSource != null)
            {
                Processing(true);
                matchCounter = 0;
                MatchTest(0.95f, HighLighte, IconSource);
                Processing(false);
            }
            else if (IconSource != null)
            {
                Reset();
                run_Click(sender, e);
            }

        }

        private void Processing(bool Working = false)  // Deaktivuje ovládací prvky, když program pracuje.
        {
            if (Working)
            {
                Cursor.Current = Cursors.WaitCursor;

                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }
            }

        }

        public void MatchTest(float přesnost, Bitmap ImageSource, Bitmap TeplateSource, string name = "null")
        {
            Matched = true;
                                                                            // Přiřazení obrázku pro porovnání.
            Image<Bgr, byte> Image1 = new Image<Bgr, byte>(ImageSource);
            Image<Bgr, byte> Image2 = new Image<Bgr, byte>(TeplateSource);

            Image<Gray, float> Matches = Image1.MatchTemplate(Image2, TemplateMatchingType.CcoeffNormed);

            g = Graphics.FromImage(pictureBox1.Image);

            for (int y = 0; y < Matches.Data.GetLength(0); y++)         // Posun po x,y 
            {
                for (int x = 0; x < Matches.Data.GetLength(1); x++)
                {
                    if (Matches.Data[y, x, 0] >= přesnost)              // Porovnavaní
                    {
                        if (ImageSource.GetPixel(x, y) == TeplateSource.GetPixel(0, 0))             // Dojde-li ke shodě přidá se pozice do seznamu.
                        {
                            matchCounter++;

                            if (name != "null")
                            {
                                placesOnMap[name].Add(new Point(x, y));
                            }

                            var rectangle = new Rectangle(x, y, TeplateSource.Width, TeplateSource.Height);
                            g.DrawRectangle(new Pen(Color.Red, 3), rectangle);

                        }
                    }
                }
            }
            this.Refresh();

            imageMatches.Text = matchCounter.ToString();
        }

        private void findAll_Click(object sender, EventArgs e)      // Porovná všechny obrázky ze složky s podkladem.
        {
            if (!Matched && MapSource != null)
            {
                Processing(true);
                matchCounter = 0;
                DirectoryInfo di = new DirectoryInfo(@"Models\Icons");
                foreach (FileInfo n in di.GetFiles("*.png"))
                {                  
                    placesOnMap.Add(n.Name.Replace(".png", ""), new List<Point>());
                    MatchTest(0.95f, HighLighte, (Bitmap)Image.FromFile(n.FullName), n.Name.Replace(".png",""));
                }
                Processing(false);
            }
            else if (MapSource != null)
            {
                Reset();
                findAll_Click(sender, e);
            }

        }

        private void removeMark_Click(object sender, EventArgs e)
        {
            if (MapSource != null)
            {
                Processing(true);
                Reset();
                Processing(false);
            }

        }

        private void Reset()                // Vrátí zpět neupravený podklad.
        {
            placesOnMap.Clear();
            HighLighte = new Bitmap(MapSource);
            pictureBox1.Image = HighLighte;
            Matched = false;
        }

        private void DistanceToPoint()      // Spočítá vzdálenost mezi body.
        {
            double distance = int.MaxValue;
            Point temp = new Point();
            foreach (List<Point> n in placesOnMap.Values)
            {
                foreach (Point p in n)
                {
                    if (distance > Math.Sqrt(Math.Pow(Math.Abs(p.X - pointOfInterest.X), 2) + Math.Pow(Math.Abs(p.Y - pointOfInterest.Y), 2)))
                    {
                        distance = Math.Sqrt(Math.Pow(Math.Abs(p.X - pointOfInterest.X), 2) + Math.Pow(Math.Abs(p.Y - pointOfInterest.Y), 2));
                        temp = p;
                    }
                }
            }

            var rectangle = new Rectangle(temp.X, temp.Y, 14, 14);
            g.DrawRectangle(new Pen(Color.Blue, 3), rectangle);

            this.distance.Text = Math.Round(distance, 2).ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)  // Označí nejbližší bod k místu kliknutí myši.
        {
            if (Matched)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                distance.Text = "Working";
                pointOfInterest = pointCorrection(me.Location);
                DistanceToPoint();
                this.Refresh();
            }
        }

        private Point pointCorrection(Point input)  // Při změně poměru stran obrázku opravu pozici.
        {
            double widthRate = ((double)MapSource.Width / (double)pictureBox1.Width) * input.X;
            double heightRate = ((double)MapSource.Height / (double)pictureBox1.Height) * input.Y;

            Point output = new Point((int)Math.Round(widthRate), (int)Math.Round(heightRate));
            return output;
        }

        private void selectIcon_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                IconSource = new Bitmap(fileDialog.FileName);
                pictureBox2.Image = IconSource;
            }
        }

        private void BestSpotCalculation()  // Vybere místo s největší hodnotou podle okolních bodů.
        {
            SpotPaint = new Bitmap(HighLighte);
            pictureBox1.Image = SpotPaint;
            g = Graphics.FromImage(SpotPaint);

            int size = 40;
            int squares = 0;

            for (int H = 0; H < 1490; H += size)
            {
                for (int W = 0; W < 1490; W += size)
                {                
                 
                    squares++;

                    pointValueCalculate(new Point(W + 5, H + 5));

                }
            }
            label1.Text = squares.ToString();

            var minValue = pointValue.Values.Min();
            foreach(Point T in pointValue.Keys)
            {
                if (pointValue[T] == minValue)
                {
                    Debug.Write(T);

                    var rectangle = new Rectangle(T.X - 5, T.Y - 5, 40, 40);
                    g.DrawRectangle(new Pen(Color.Green, 3), rectangle);

                    break;
                }
            }

            this.Refresh();
        }

        private void pointValueCalculate(Point position) // Počítá hodnotu bodu dle kritérii.
        {
            double value = 0;
            double distance = int.MaxValue;

            for (int N = 0; N < placesOnMap.Count; N++)
            {
                foreach (Point T in placesOnMap[placesOnMap.Keys.ElementAt(N)])
                {
                    distance = Math.Sqrt(Math.Pow(Math.Abs(T.X - position.X), 2) + Math.Pow(Math.Abs(T.Y - position.Y), 2));
                    value += distance * (double)mapPlacesValue[placesOnMap.Keys.ElementAt(N)];
                }
            }

            pointValue.Add(position, value);
        }


        private void bestSpot_Click(object sender, EventArgs e)
        {
            BestSpotCalculation();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form SettingsObj = new Settings(mapPlacesValue, this);
            SettingsObj.ShowDialog();
        }

        public void ValueChanged(Dictionary<string, int> n)
        {
            mapPlacesValue = n;
        }
    }
}
