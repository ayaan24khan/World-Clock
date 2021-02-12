using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using RestSharp;
using System.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace World_Clock
{
    public partial class World_Clock_Form : Form
    {
        private static readonly Stopwatch watch = new Stopwatch();

        private int totalSeconds;

        public World_Clock_Form()
        {
            InitializeComponent();
            UpdateTime();
        }
        // Ayaan Khan
        private void bttnAddCity_Click(object sender, EventArgs e)
        {
            string timeStamp = Convert.ToString((int)DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
            string address1 = textBox1.Text;
            string uKey = "&key=";
            string uTstmp = "&timestamp=";
            string comma = ",";
            string key = ConfigurationManager.AppSettings["APIKey"];
            string url1 = "https://maps.googleapis.com/maps/api/geocode/json?address="+address1+uKey+key;
            RestClient client1 = new RestClient(url1);
            var response1 = client1.Execute(new RestRequest(), Method.GET);
            CityInfo cityDetails = JsonConvert.DeserializeObject<CityInfo>(response1.Content);
            int lengt = cityDetails.results.Capacity;

            double lat = cityDetails.results[0].geometry.location.lat;
            double longi = cityDetails.results[0].geometry.location.lng;


            string url2 = "https://maps.googleapis.com/maps/api/timezone/json?location=" + lat.ToString() + comma + longi.ToString() + uTstmp + timeStamp + uKey + key;


            RestClient client2 = new RestClient(url2);
            var response2 = client2.Execute(new RestRequest(), Method.GET);
            Timezone timeZone = JsonConvert.DeserializeObject<Timezone>(response2.Content);
            string timezoneId = timeZone.timeZoneId;
            string timezoneName = timeZone.timeZoneName;

            DateTimeOffset nowDateTime = DateTimeOffset.Now;
            DateTimeOffset newDateTime = TimeZoneInfo.ConvertTime(nowDateTime,TimeZoneInfo.FindSystemTimeZoneById(timezoneName));
            lbldisplay.Text = "City Time : "+newDateTime.ToString("hh:mm:ss tt\n dddd \n dd-MM-yyyy");
            lblLocal.Text = "Local Time : " + DateTime.Now.ToString("hh:mm:ss tt\n dddd \n dd-MM-yyyy");
        }

        private string ToString(double lat)
        {
            throw new NotImplementedException();
        }

        public class AddressComponent
        {
            public string long_name { get; set; }
            public string short_name { get; set; }
            public List<string> types { get; set; }
        }

        public class Location
        {
           
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Northeast
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Southwest
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Viewport
        {
            public Northeast northeast { get; set; }
            public Southwest southwest { get; set; }
        }

        public class Geometry
        {
            public Location location { get; set; }
            public string location_type { get; set; }
            public Viewport viewport { get; set; }
        }

        public class PlusCode
        {
            public string compound_code { get; set; }
            public string global_code { get; set; }
        }

        public class Result
        {
            public List<AddressComponent> address_components { get; set; }
            public string formatted_address { get; set; }
            public Geometry geometry { get; set; }
            public string place_id { get; set; }
            public PlusCode plus_code { get; set; }
            public List<string> types { get; set; }
        }

        public class CityInfo
        { 
            public List<Result> results { get; set; }
            public string status { get; set; }
        }




        public class Timezone
        {
            public int dstOffset { get; set; }
            public int rawOffset { get; set; }
            public string status { get; set; }
            public string timeZoneId { get; set; }
            public string timeZoneName { get; set; }
        }

        



        private void World_Clock_Form_Load(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;

            for (int i = 0; i < 60; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
                this.comboBox3.Items.Add(i.ToString());
            }
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
        }
        

       // Timers starts (Shreyas Patil)

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;

            int hours = int.Parse(this.comboBox1.SelectedItem.ToString());
            int minutes = int.Parse(this.comboBox2.SelectedItem.ToString());
            int seconds = int.Parse(this.comboBox3.SelectedItem.ToString());

            totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            this.timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;
            this.btnStart.Enabled = true;

            totalSeconds = 0;
            this.timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int hours = totalSeconds / 3600;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60) - (hours * 60);
                label1.Text = string.Format("{0:00}:{1:00}:{2:00}", hours.ToString(), minutes.ToString(), seconds.ToString());
            }
            else
            {
                
                this.timer1.Stop();
                MessageBox.Show("Time's Up!");
            }
        }

        // StopWatch Starts Here
        // Ayaan Khan
        private void UpdateTime()
        {
            lblTime.Text = GetTimeString(watch.Elapsed);
        }

        private string GetTimeString(TimeSpan elapsed)
        {
            string result = string.Empty;
            result = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                elapsed.Hours,
                elapsed.Minutes,
                elapsed.Seconds,
                elapsed.Milliseconds);

            return result;
        }
        // Shreyas Patil
        private void bttnStart_Click(object sender, EventArgs e)
        {
            if (bttnStart.Text == "Start")
            {
                watch.Start();
                bttnStart.Text = "Pause";
                timerStopwatch.Enabled = true;
            }
            else
            {
                watch.Stop();
                bttnStart.Text = "Start";
                timerStopwatch.Enabled = false;
            }

        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            watch.Reset();
            timerStopwatch.Enabled = false;
            UpdateTime();
            bttnStart.Text = "Start";
            ListBox1.Items.Clear();
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void bttnLap_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(ListBox1.Items.Count+1+". "+lblTime.Text);
        }

        
       

        
    }
   
}
