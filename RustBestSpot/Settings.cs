using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustBestSpot
{
    public partial class Settings : Form
    {
        Dictionary<string, int> mapPlacesValue = new Dictionary<string, int>();
        Main main;

        public Settings(Dictionary<string, int> mapPlacesValue, Main f)
        {
            InitializeComponent();
            this.mapPlacesValue = mapPlacesValue;
            this.main = f;
        }



        private void Values()
        {
            textBox1.Text = mapPlacesValue["gasstation"].ToString();
            textBox2.Text = mapPlacesValue["junkyard"].ToString();
            textBox3.Text = mapPlacesValue["lighthouse"].ToString();
            textBox4.Text = mapPlacesValue["supermarket"].ToString();
            textBox5.Text = mapPlacesValue["powerplant"].ToString();
            textBox6.Text = mapPlacesValue["airfield"].ToString();
            textBox7.Text = mapPlacesValue["trainyard"].ToString();
            textBox8.Text = mapPlacesValue["watertreatment"].ToString();
            textBox9.Text = mapPlacesValue["militarytunnel"].ToString();
            textBox10.Text = mapPlacesValue["launchsite"].ToString();
            textBox11.Text = mapPlacesValue["cabin"].ToString();
            textBox12.Text = mapPlacesValue["swamp"].ToString();
            textBox13.Text = mapPlacesValue["warehouse"].ToString();
            textBox14.Text = mapPlacesValue["outpost"].ToString();
            textBox15.Text = mapPlacesValue["dome"].ToString();
            textBox16.Text = mapPlacesValue["dish"].ToString();
            textBox17.Text = mapPlacesValue["fishing"].ToString();
            textBox18.Text = mapPlacesValue["excavator"].ToString();
            textBox19.Text = mapPlacesValue["harbor"].ToString();
            textBox20.Text = mapPlacesValue["radtown"].ToString();
        }
    

        private void Settings_Load(object sender, EventArgs e)
        {
            Values();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            mapPlacesValue["gasstation"] = Int32.Parse(textBox1.Text);
            mapPlacesValue["junkyard"] = Int32.Parse(textBox2.Text);
            mapPlacesValue["lighthouse"] = Int32.Parse(textBox3.Text);
            mapPlacesValue["supermarket"] = Int32.Parse(textBox4.Text);
            mapPlacesValue["powerplant"] = Int32.Parse(textBox5.Text);
            mapPlacesValue["airfield"] = Int32.Parse(textBox6.Text);
            mapPlacesValue["trainyard"] = Int32.Parse(textBox7.Text);
            mapPlacesValue["watertreatment"] = Int32.Parse(textBox8.Text);
            mapPlacesValue["militarytunnel"] = Int32.Parse(textBox9.Text);
            mapPlacesValue["launchsite"] = Int32.Parse(textBox10.Text);
            mapPlacesValue["cabin"] = Int32.Parse(textBox11.Text);
            mapPlacesValue["swamp"] = Int32.Parse(textBox12.Text);
            mapPlacesValue["warehouse"] = Int32.Parse(textBox13.Text);
            mapPlacesValue["outpost"] = Int32.Parse(textBox14.Text);
            mapPlacesValue["dome"] = Int32.Parse(textBox15.Text);
            mapPlacesValue["dish"] = Int32.Parse(textBox16.Text);
            mapPlacesValue["fishing"] = Int32.Parse(textBox17.Text);
            mapPlacesValue["excavator"] = Int32.Parse(textBox18.Text);
            mapPlacesValue["harbor"] = Int32.Parse(textBox19.Text);
            mapPlacesValue["radtown"] = Int32.Parse(textBox20.Text);

            main.ValueChanged(mapPlacesValue);
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
