using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neta
{
    public partial class dtformat : Form
    {
        public dtformat()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            System.Collections.ObjectModel.ReadOnlyCollection<TimeZoneInfo> zoneinfo
        = TimeZoneInfo.GetSystemTimeZones();

            foreach (TimeZoneInfo z in zoneinfo)
            {
                comboBox2.Items.Add(z.DisplayName + " - " + z.Id);
            }

            textBox1.Text = Properties.Settings.Default.lefttimeformat;
            textBox2.Text = Properties.Settings.Default.datetimeformat;
            checkBox1.Checked = Properties.Settings.Default.useutc;
            checkBox2.Checked = Properties.Settings.Default.usems;
            comboBox1.Text = Properties.Settings.Default.useutczone;
            comboBox2.Text = Properties.Settings.Default.msstring ;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.lefttimeformat = textBox1.Text;
        }

        private void dtformat_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.useutc = checkBox1.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.useutczone = comboBox1.Text;
            Properties.Settings.Default.useutcint = gettimeoffset(comboBox1.Text);
        }

        private double gettimeoffset(string dt)
        {
            double i = 9;
            var m = Regex.Match(dt, "\\+?\\-?\\d\\d");
            if (m.Success)
            {
                i = Convert.ToDouble(m.Value);
                Properties.Settings.Default.useutch = m.Value;
                m = m.NextMatch();
                i = i + Convert.ToDouble(m.Value) / 60;
                Properties.Settings.Default.useutcm = m.Value;
            }


            return i;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.usems = checkBox2.Checked;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var m = Regex.Match(comboBox2.Text, " \\-.+");
            if (m.Success)
            {
                string tm = m.Value.Replace(" -", "").Trim();
                try
                {
                    TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(tm);

                    Properties.Settings.Default.mstime = tm;
                }
                catch (Exception ex){
                    MessageBox.Show("廃止されたタイムゾーンのため、東京に差し替えます。\r\n"+ex.ToString());
                    Properties.Settings.Default.mstime = "Tokyo Standard Time";
                }
            }
            else
            {
                Properties.Settings.Default.mstime = "Tokyo Standard Time";
            }

            Properties.Settings.Default.msstring = comboBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.datetimeformat = textBox2.Text;
        }
    }
}
