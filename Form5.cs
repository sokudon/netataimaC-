using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text.RegularExpressions;

using System.Threading;
namespace neta
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.idol = this.comboBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            DateTime dt = DateTime.Now;

            string url =textBox1.Text;
            string url2 = textBox2.Text;

            string idol = (comboBox2.SelectedIndex+1).ToString();
            string rank = comboBox1.Text;

            url = Regex.Replace(url, "\\/\\d?\\d\\/", "/" + idol + "/");
            url2 = Regex.Replace(url2, "\\/\\d?\\d\\/", "/" + idol + "/");
            url = Regex.Replace(url, "\\/(\\d+,)*\\d+$", "/" + rank);
            url2 = Regex.Replace(url2, "\\/(\\d+,)*\\d+$", "/" + rank);

            textBox1.Text = url;

            textBox2.Text = url2;

            string parseop = Properties.Settings.Default.parse;
            string text = ""; 
            string text2 = "";
            try
            {
                text = wc.DownloadString(url);
                File.WriteAllText(@"tmp.js", text);
            }
            catch (WebException exc)
            {
                wc.Dispose();
                MessageBox.Show(exc.Message);
                return;
            }


            try
            {
                text2 = wc.DownloadString(url2);
                File.WriteAllText(@"tmp2.js", text2);
            }
            catch (WebException exc)
            {
                MessageBox.Show(exc.Message);
                wc.Dispose();
                return;
            }

            wc.Dispose();

            var jsonlast = Codeplex.Data.DynamicJson.Parse(text);
            var json = Codeplex.Data.DynamicJson.Parse(text2);

            var j = json[0];
            var jj = jsonlast[0];
            int[] arr = j.data;
            int length = arr.Length-1;


            var finaldata = j.data[length].summaryTime;
            var finaldatas = j.data[length].score;

            
            length -= 3;

            var ffinaldata = jj.data[length].summaryTime;
            var ffinaldatas = jj.data[length].score;


            label3.Text = finaldata;
            label4.Text = String.Format("{0:#,0}",finaldatas);


            label5.Text = ffinaldata;
            label6.Text = String.Format("{0:#,0}", ffinaldatas);


            label7.Text = String.Format("{0:#,0}", finaldatas- ffinaldatas );

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.rank = this.comboBox1.Text;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Text = Properties.Settings.Default.rank;
            comboBox2.Text = Properties.Settings.Default.idol;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            DateTime dt = DateTime.Now;

            string url = textBox1.Text;
            string url2 = textBox2.Text;

            string idol = (comboBox2.SelectedIndex + 1).ToString();
            string rank = comboBox1.Text;

            url = Regex.Replace(url, "\\/\\d?\\d\\/", "/" + idol + "/");
            url2 = Regex.Replace(url2, "\\/\\d?\\d\\/", "/" + idol + "/");
            url = Regex.Replace(url, "\\/\\d+$", "/1,2,3,10,100,1000" );
            url2 = Regex.Replace(url2, "\\/\\d+$", "/1,2,3,10,100,1000" );

            textBox1.Text = url;

            textBox2.Text = url2;

            string idolname = Regex.Replace(comboBox2.Text, "\\d+[ 　\\t]", "");

            string parseop = Properties.Settings.Default.parse;
            string text = "";
            string text2 = "";
            try
            {
                text = wc.DownloadString(url);
                File.WriteAllText(@"d1.js", "var bn='後" + idolname +"';var bd=" +text);
            }
            catch (WebException exc)
            {
                wc.Dispose();
                MessageBox.Show(exc.Message);
                return;
            }


            try
            {
                text2 = wc.DownloadString(url2);
                File.WriteAllText(@"d2.js","var cn='前"+idolname +"'; var data=" +text2);
            }
            catch (WebException exc)
            {
                MessageBox.Show(exc.Message);
                wc.Dispose();
                return;
            }

            wc.Dispose();
            System.Diagnostics.Process.Start("Highstock compare.html");
            


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/sokudon/netataimaC-/tree/master/bin/Release");
        }

        private void button3_Click(object sender, EventArgs e)
        {


            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            DateTime dt = DateTime.Now;

            string url = textBox1.Text;
            string url2 = textBox2.Text;

            string idol = (comboBox2.SelectedIndex + 1).ToString();
            string rank = comboBox1.Text;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
          
            for (int i = 1; i < 53; i++)
            {

                url = Regex.Replace(url, "\\/\\d?\\d\\/", "/" + i.ToString() + "/");
                url2 = Regex.Replace(url2, "\\/\\d?\\d\\/", "/" + i.ToString() + "/");
                url = Regex.Replace(url, "\\/(\\d+,)*\\d+$", "/" + rank);
                url2 = Regex.Replace(url2, "\\/(\\d+,)*\\d+$", "/" + rank);

                textBox1.Text = url;

                textBox2.Text = url2;

                string parseop = Properties.Settings.Default.parse;
                string text = "";
                string text2 = "";
                try
                {
                    text = wc.DownloadString(url);
                    File.WriteAllText(@"tmp.js"+ i.ToString(), text);
                }
                catch (WebException exc)
                {
                    wc.Dispose();
                    MessageBox.Show(exc.Message);
                    return;
                }


                try
                {
                    text2 = wc.DownloadString(url2);
                    File.WriteAllText(@"tmp2.js"+i.ToString(), text2);
                }
                catch (WebException exc)
                {
                    MessageBox.Show(exc.Message);
                    wc.Dispose();
                    return;
                }

                wc.Dispose();

                var jsonlast = Codeplex.Data.DynamicJson.Parse(text);
                var json = Codeplex.Data.DynamicJson.Parse(text2);

                var j = json[0];
                var jj = jsonlast[0];
                int[] arr = j.data;
                int length = arr.Length - 1;


                var finaldata = j.data[length].summaryTime;
                var finaldatas = j.data[length].score;

                comboBox2.SelectedIndex = i-1;
                sb.Append(comboBox2.Text);
                sb.Append(" ");
                sb.Append(finaldata);
                sb.Append(" ");
                sb.Append(finaldatas);
                sb.Append(" ");

                length -= 3;

                var ffinaldata = jj.data[length].summaryTime;
                var ffinaldatas = jj.data[length].score;
                sb.Append(ffinaldata);
                sb.Append(" ");
                sb.Append(ffinaldatas);
                sb.AppendLine(); 
                Thread.Sleep(500);
            }
            string str2 = sb.ToString();

            File.WriteAllText(@"alldata.txt", str2);
        }
    }
}
